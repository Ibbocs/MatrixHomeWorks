using ApiEFwithRepository.Data;
using ApiEFwithRepository.Data.Entity;
using ApiEFwithRepository.Data.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApiEFwithRepository.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private BookAtticDbContext BookAtticDbContext;

        public BookController(BookAtticDbContext _BookAtticDbContext)
        {
            BookAtticDbContext= _BookAtticDbContext;
        }

        [HttpGet]
        public async Task<List<Book>> GetBooks()
        {
            return await BookAtticDbContext.books.ToListAsync();
        }

        [HttpPost]
        public async Task<Book> AddBook([FromBody] Book book)
        {
            await BookAtticDbContext.books.AddAsync(book);
            await BookAtticDbContext.SaveChangesAsync();

            return book;
        }

        [HttpPut]
        public async Task<Book> UpdateBook(int id, BookUpdateDTO bookUpdateDto)
        {
            var book = await BookAtticDbContext.books.FirstOrDefaultAsync(s=> s.Id == id);
            book.BookName = bookUpdateDto.BookName;
            await BookAtticDbContext.SaveChangesAsync();
            return book;
        }

        [HttpDelete]
        public async Task<Book> DeleteBook(int id)
        {
            var book = await BookAtticDbContext.books.FirstOrDefaultAsync(s => s.Id == id);
            BookAtticDbContext.books.Remove(book);
            await BookAtticDbContext.SaveChangesAsync();
            return book;

        }
    }
}
