using Guna.UI2.WinForms;
using OnlineBookStoreWithASPNETCore.Entities;
using OnlineBookStoreWithASPNETCore.Interfaces;
using OnlineBookStoreWithASPNETCore.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBookStoreWithASPNETCore.Services
{
    public class BookService : IBookService
    {
        private readonly IBookRepository bookRepo;
        private readonly ICategoryRepository categoryRepo;
        public BookService(IBookRepository _bookRepo, ICategoryRepository _categoryRepo)
        {
            bookRepo = _bookRepo;
            categoryRepo = _categoryRepo;
        }

        public async Task<bool> AddBookWithCategoryAsync(string title, string author, string categoryName, int quantity, double price)
        {
            try
            {
                var existingBook = bookRepo.GetBookByTitle(title);
                if (existingBook != null)
                {
                    existingBook.Quantity += quantity;
                    existingBook.Price = price;
                    await bookRepo.UpdateBookAsync(existingBook);
                    return true;
                }
                var category = categoryRepo.GetOrCreateCategoryByName(categoryName);
                var book = new Book
                {
                    Title = title,
                    AuthorName = author,
                    CategoryID = category.CategoryId,
                    Quantity = quantity,
                    Price = price
                };
                await bookRepo.AddBookAsync(book);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding books to DB: " + ex.Message);
                return false;
            }
            
        }

        public List<BookViewModel> GetBooksByCategory(string category)
        {
            return bookRepo.GetBooks(category);
        }
        public async Task<bool> DeleteBookByIdAsync(int bookId)
        {
            var book = bookRepo.GetBookById(bookId);
            if (book == null) return false;

            await bookRepo.DeleteBookAsync(book);
            return true;
        }

        public void IncreaseQuantity(DataGridView dataBooks, Guna2TextBox quantity, int newQuantity, decimal pricePerBook, Guna2TextBox newPrice)
        {
            if (dataBooks.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataBooks.SelectedRows[0];
                int currentQuantity = Convert.ToInt32(selectedRow.Cells["Quantity"].Value);
                pricePerBook = Convert.ToDecimal(selectedRow.Cells["Price"].Value);

                if (newQuantity < currentQuantity)
                {
                    newQuantity++;
                    quantity.Text = newQuantity.ToString();
                    decimal total = pricePerBook * newQuantity;
                    newPrice.Text = total.ToString();
                }
                else
                {
                    MessageBox.Show("Entered quantity is greater than or equal to the available quantity.");
                }
            }
        }
        public void DecreaseQuantity(DataGridView dataBooks, Guna2TextBox quantity, int newQuantity, decimal pricePerBook, Guna2TextBox newPrice)
        {
            if (dataBooks.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataBooks.SelectedRows[0];
                int currentQuantity = Convert.ToInt32(selectedRow.Cells["Quantity"].Value);
                pricePerBook = Convert.ToDecimal(selectedRow.Cells["Price"].Value);

                if (newQuantity > 1)
                {
                    newQuantity--;
                    quantity.Text = newQuantity.ToString();
                    decimal total = pricePerBook * newQuantity;
                    newPrice.Text = total.ToString();
                }
                else
                {
                    MessageBox.Show("Entered quantity is equal to one.");
                }
            }
        }

    }
}
