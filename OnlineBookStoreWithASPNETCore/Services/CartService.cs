using OnlineBookStoreWithASPNETCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBookStoreWithASPNETCore.Services
{
    public class CartService : ICartService
    {
        public void AddOrUpdateCart(DataGridView dataItems, string title, int quantity, decimal price)
        {
            try
            {
                decimal unitPrice = price / quantity;
                decimal totalPrice = unitPrice * quantity;

                foreach (DataGridViewRow row in dataItems.Rows)
                {
                    if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == title)
                    {
                        int existingQty = int.Parse(row.Cells[1].Value.ToString());
                        int newQty = existingQty + quantity;
                        row.Cells[1].Value = newQty.ToString();
                        row.Cells[3].Value = (unitPrice * newQty).ToString("0.00");
                        return;
                    }
                }

                dataItems.Rows.Add(title, quantity.ToString(), unitPrice.ToString("0.00"), totalPrice.ToString("0.00"));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in cart service: " + ex.Message);
            }
        }
    }
}
