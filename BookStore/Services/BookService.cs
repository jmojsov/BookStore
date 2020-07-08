using BookStore.Data;
using BookStore.DtoModels;
using BookStore.Helpers;
using BookStore.Repositories.Interfaces;
using BookStore.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Services
{
    public class BookService : IBookService
    {
        private readonly IBookRepository bookRepository;

        public BookService(IBookRepository bookRepository)
        {
            this.bookRepository = bookRepository;
        }

        public void Add(DtoBook dtoBook)
        {
            var dbBook = dtoBook.ToBook();
            bookRepository.Add(dbBook);
        }

        public void Delete(int id)
        {
            var dbBook = bookRepository.GetById(id);

            if (dbBook != null)
            {
                bookRepository.Delete(dbBook);
            }

        }

        public List<DtoBook> GetAll()
        {
            var dbBooks = bookRepository.GetAll();
            return dbBooks.Select(x => x.ToDtoBook()).ToList();
        }

        public List<DtoBook> GetByAuthor(string author)
        {
            var dbBooks = bookRepository.GetByAuthor(author);
            return dbBooks.Select(x => x.ToDtoBook()).ToList();
        }

        public DtoBook GetById(int id)
        {
            var dbBook = bookRepository.GetById(id);

            return dbBook.ToDtoBook();
        }

        public void Update(DtoBook dtoBook)
        {
            var book = bookRepository.GetById(dtoBook.Id);

            if (dtoBook != null)
            {
                book.Title = dtoBook.Title;
                book.Author = dtoBook.Author;
                book.Genre = dtoBook.Genre;
                book.Description = dtoBook.Description;
                book.Quantity = dtoBook.Quantity;
                book.Price = dtoBook.Price;

                bookRepository.Update(book);
            }
        }
    }
}
