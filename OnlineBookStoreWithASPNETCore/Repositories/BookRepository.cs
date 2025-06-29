using OnlineBookStoreWithASPNETCore.Contexts;
using OnlineBookStoreWithASPNETCore.Entities;
using OnlineBookStoreWithASPNETCore.Interfaces;
using OnlineBookStoreWithASPNETCore.Models;
using System.Data;

namespace OnlineBookStoreWithASPNETCore.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly OnlineBookStoreDbContext dbContext;
        public BookRepository(OnlineBookStoreDbContext _dbContext)
        {
            dbContext = _dbContext;
        }
        public List<BookViewModel> GetBooks(string category = "All")
        {
            try
            {
                var getBooks = dbContext.Books
                    .Where(C => category == "All" || C.Category.CategoryName == category)
                    .Select(B => new BookViewModel
                    {
                        Id = B.BookId,
                        BookTitle = B.Title,
                        AuthorName = B.AuthorName,
                        Category = B.Category.CategoryName,
                        Price = B.Price,
                        Quantity = B.Quantity

                    }).ToList();
                return getBooks;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading books: " + ex.Message);
                return new List<BookViewModel>(); 
            }
        }
        public async Task AddBookAsync(Book book)
        {
            await dbContext.Books.AddAsync(book);
            await dbContext.SaveChangesAsync();
        }
        public Book? GetBookByTitle(string title)
        {
            return dbContext.Books.FirstOrDefault(b => b.Title == title);
        }
        public async Task UpdateBookAsync(Book book)
        {
            dbContext.Books.Update(book);
            await dbContext.SaveChangesAsync();
        }
        public Book? GetBookById(int bookId)
        {
            return dbContext.Books.FirstOrDefault(b => b.BookId == bookId);
        }

        public async Task DeleteBookAsync(Book book)
        {
            dbContext.Books.Remove(book);
            await dbContext.SaveChangesAsync();
        }
    }
}
