using BookStore.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Repositories.Interfaces
{
    public interface IBookRepository
    {
        List<Book> GetAll();
        Book GetById(int id);
        List<Book> GetByAuthor(string author);
        void Add(Book dbBook);
        void Update(Book book);
        void Delete(Book dbBook);
    }
}
