using Microsoft.EntityFrameworkCore;
using OnlineBookStoreWithASPNETCore.Contexts;
using OnlineBookStoreWithASPNETCore.Entities;
using OnlineBookStoreWithASPNETCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBookStoreWithASPNETCore.Services
{
    public class OrderService : IOrderService
    {
        private readonly OnlineBookStoreDbContext dbContext;
        public OrderService(OnlineBookStoreDbContext _dbContext)
        {
            dbContext = _dbContext;
        }
        public bool PlaceOrder(List<DataGridViewRow> cartItems, string customerId, DataGridView dataReceipt, Label totalL)
        {
            using var transaction = dbContext.Database.BeginTransaction();

            try
            {
                dataReceipt.Rows.Clear();
                decimal totalPrice = 0;
                foreach (var row in cartItems.Where(r => !r.IsNewRow))
                {
                    string title = row.Cells["Column1"].Value?.ToString() ?? "";
                    int quantity = Convert.ToInt32(row.Cells["Column2"].Value);
                    decimal unitPrice = Convert.ToDecimal(row.Cells["Column3"].Value);
                    decimal totalRowPrice = quantity * unitPrice;

                    dataReceipt.Rows.Add(title, unitPrice.ToString("0.00"), quantity);
                    totalPrice += totalRowPrice;


                    var book = dbContext.Books.FirstOrDefault(b => b.Title == title);

                    if (book == null)
                        throw new Exception($"Book '{title}' not found.");

                    if (book.Quantity < quantity)
                        throw new Exception($"Not enough quantity for book '{title}'.");

                    var order = new Order
                    {
                        Quantity = quantity,
                        CustomerId = int.Parse(customerId)
                    };

                    dbContext.Orders.Add(order);
                    dbContext.SaveChanges();

                    var orderBook = new OrderBook
                    {
                        OrderId = order.OrderId,
                        BookId = book.BookId
                    };

                    dbContext.OrderBooks.Add(orderBook);

                    book.Quantity -= quantity;

                    if (book.Quantity == 0)
                        dbContext.Books.Remove(book);
                    else
                        dbContext.Books.Update(book);
                }
                totalL.Text = $"Total: {totalPrice:0.00}";
                dbContext.SaveChanges();
                transaction.Commit();
                return true;
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                MessageBox.Show("Order failed: " + ex.Message);
                return false;
            }
        }

    }
}
