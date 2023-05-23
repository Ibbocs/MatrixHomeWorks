using BookAtticApi.Business.Services;
using BookAtticApi.Domain.DTO;
using BookAtticApi.Domain.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BookAtticApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private IBookRepositoryService BookRepositoryService;
        public BookController(IBookRepositoryService _bookRepositoryService)
        {
            BookRepositoryService= _bookRepositoryService;
        }

        [HttpGet]
        [Microsoft.AspNetCore.Authorization.Authorize]
        public Task <List<Book>> GetAllBooks()
        {
            return BookRepositoryService.GetAllBooks();
        }
    }
}
