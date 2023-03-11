using EFwithAutoMapperAndLinQ.Domain;
using EFwithAutoMapperAndLinQ.Domain.DTO;
using EFwithAutoMapperAndLinQ.Domain.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace EFwithAutoMapperAndLinQ.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentController : ControllerBase
    {
        private IRepositoryCommentcs repository;
        public CommentController(IRepositoryCommentcs _repository)
        {
            repository = _repository;
        }

        [HttpGet]
        public IQueryable GetAllComments()
        {
            //burda post null gelir, include elememisem bu ders keceiyik deye. ancaq postum get eleyende commenti cekir
            return repository.GetAllComment();
        }

        [HttpPost]
        public async Task<Comment> AddComment([FromQuery] CommentDTO commentDTO)
        {
            return await repository.AddComment(commentDTO);
        }

        [HttpPut]
        public async Task<Comment> UpdateComment(int id, [FromQuery] CommentDTO commentDTO)
        {
            return await repository.UpdateComment(id, commentDTO);
        }

        [HttpDelete]
        public async Task<Comment> DeleteComment(int id)
        {
            return await repository.DeleteComment(id);
        }
    }
}
