using BookStore.Data;
using BookStore.DtoModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Helpers
{
    public static class Converter
    {
        public static DtoBook ToDtoBook(this Book book)
        {
            return new DtoBook
            {
                Id = book.Id,
                Title = book.Title,
                Author = book.Author,
                Genre = book.Genre,
                Description = book.Description,
                Price = book.Price,
                Quantity = book.Quantity
            };
        }

        public static Book ToBook(this DtoBook book)
        {
            return new Book
            {
                Id = book.Id,
                Title = book.Title,
                Author = book.Author,
                Genre = book.Genre,
                Description = book.Description,
                Price = book.Price,
                Quantity = book.Quantity
            };
        }
    }
}
