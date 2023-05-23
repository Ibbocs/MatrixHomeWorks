using BookAtticApi.Domain.DTO;
using BookAtticApi.Domain.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BookAtticApi.Business.Services
{
    public interface IBookRepositoryService
    {
        public Task<List<Book>> GetAllBooks();
    }
}
