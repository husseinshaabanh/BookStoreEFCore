using OnlineBookStoreWithASPNETCore.Entities;
using OnlineBookStoreWithASPNETCore.Models;
using System.Data;

namespace OnlineBookStoreWithASPNETCore.Interfaces
{
    public interface IBookRepository
    {
        List<BookViewModel> GetBooks(string category = "All");
        Task AddBookAsync(Book book);
        Book GetBookByTitle(string title);
        Book GetBookById(int bookId);
        Task DeleteBookAsync(Book book);
        Task UpdateBookAsync(Book book);
    }
}
