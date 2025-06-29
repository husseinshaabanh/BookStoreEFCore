using Guna.UI2.WinForms;
using OnlineBookStoreWithASPNETCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBookStoreWithASPNETCore.Interfaces
{
    public interface IBookService
    {
        Task<bool> AddBookWithCategoryAsync(string title, string author, string categoryName, int quantity, double price);
        List<BookViewModel> GetBooksByCategory(string category);
        Task<bool> DeleteBookByIdAsync(int bookId);
        void IncreaseQuantity(DataGridView dataBooks, Guna2TextBox quantity, int newQuantity, decimal pricePerBook, Guna2TextBox newPrice);
        void DecreaseQuantity(DataGridView dataBooks, Guna2TextBox quantity, int newQuantity, decimal pricePerBook, Guna2TextBox newPrice);

    }
}
