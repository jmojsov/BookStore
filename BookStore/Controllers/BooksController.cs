using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.Data;
using BookStore.DtoModels;
using BookStore.Helpers;
using BookStore.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IBookService bookService;

        public BooksController(IBookService bookService)
        {
            this.bookService = bookService;
        }
        [HttpGet]
        public IActionResult Get()
        {
            var books = bookService.GetAll();

            return Ok(books);
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult Get(int id)
        {
            var book = bookService.GetById(id);

            return Ok(book);
        }

        [HttpGet]
        [Route("author")]
        public IActionResult Get(string author)
        {
            var book = bookService.GetByAuthor(author);

            return Ok(author);
        }
        [HttpPost]
        public IActionResult Add(DtoBook dtoBook)
        {
            bookService.Add(dtoBook);
            return Ok();
        }
        [HttpPut]
        public IActionResult Update(DtoBook dtoBook)
        {
            bookService.Update(dtoBook);
            return Ok();
        }
        [HttpDelete]
        [Route("{id}")]
        public IActionResult Delete(int id)
        {
            bookService.Delete(id);
            return Ok();
        }
    }
}