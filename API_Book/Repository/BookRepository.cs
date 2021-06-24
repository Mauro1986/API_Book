using API_Book.Data;
using API_Book.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Book.Repository
{
    public class BookRepository
    {
        private readonly App_Context _dbContext;
        public BookRepository(App_Context context)
        {
            _dbContext = context;
        }
        public void AddBook(Book book)
        {

            _dbContext.Book.Add(book);
            _dbContext.SaveChanges();
        }
        public List<Book> GetAllBook()
        {
           return _dbContext.Book.ToList();
        }

        public void DeleteBook(int id)
        {
            var book = _dbContext.Book.FirstOrDefault(b => b.Id == id);
            if (book != null)
            {
                _dbContext.Book.Remove(book);
                _dbContext.SaveChanges();
            }
        }

        public void UpdateBook(int id, Book book)
        {
            var FindBookToUpdate = _dbContext.Book.FirstOrDefault(b => b.Id == id);
            if (FindBookToUpdate != null)
            {
                FindBookToUpdate.Title = book.Title;
                FindBookToUpdate.Description = book.Description;
                FindBookToUpdate.Rate = book.Rate;
                FindBookToUpdate.Genre = book.Genre;
                FindBookToUpdate.DateRead = book.DateRead;
                //_dbContext.Book.Update(FindBookToUpdate);
                _dbContext.SaveChanges();
            }
           // return FindBookToUpdate;
        }
    }
}
