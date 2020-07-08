using BookStore.Data;
using BookStore.DtoModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Services.Interfaces
{
    public interface IBookService
    {
        List<DtoBook> GetAll();
        DtoBook GetById(int id);
        List<DtoBook> GetByAuthor(string author);
        void Add(DtoBook dtoBook);
        void Update(DtoBook dtoBook);
        void Delete(int id);
    }
}
