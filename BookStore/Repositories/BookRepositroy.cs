using BookStore.Data;
using BookStore.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Repositories
{
    public class BookRepositroy : IBookRepository
    {
        private readonly BookStoreDbContext context;

        public BookRepositroy(BookStoreDbContext context)
        {
            this.context = context;
        }

        public void Add(Book dbBook)
        {
            context.Books.Add(dbBook);
            context.SaveChanges();
        }

        public void Delete(Book dbBook)
        {
            context.Books.Remove(dbBook);
        }

        public List<Book> GetAll()
        {
            return context.Books.ToList();
        }

        public List<Book> GetByAuthor(string author)
        {
            return context.Books.Where(x => x.Author == author).ToList();
        }

        public Book GetById(int id)
        {
            return context.Books.FirstOrDefault(x => x.Id == id);
        }

        public void Update(Book book)
        {
            context.Update(book);
            context.SaveChanges();
        }
    }
}
