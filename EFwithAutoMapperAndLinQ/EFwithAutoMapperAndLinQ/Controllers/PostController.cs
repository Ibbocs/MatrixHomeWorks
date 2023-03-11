using AutoMapper;
using EFwithAutoMapperAndLinQ.Domain;
using EFwithAutoMapperAndLinQ.Domain.DTO;
using EFwithAutoMapperAndLinQ.Domain.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFwithAutoMapperAndLinQ.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private IRepositoryPost repository;
        public PostController(IRepositoryPost _repository)
        {
            repository = _repository;
        }

        [HttpGet]
        public IQueryable GetAllPost()
        {
            return  repository.GetAllPost();
        //        List<PostDTO> posts = new List<PostDTO>();
        //        var all = await _blogDbContext.Posts.ToListAsync();

        //        mapper.Map<Post>(all);

        //        return posts;
            
        }

        [HttpPost]
        public async Task<PostDTO> AddPost([FromQuery] PostDTO postDTO)
        {
            return await repository.AddPost(postDTO);
        }

        [HttpPut]
        public async Task<Post> UpdatePost(int id, [FromQuery] PostDTO postDTO)
        {
            //burda comment null gelir(burda inculud ettmeliyik bildim), id de 0nniye?
            return await repository.UpdatePost(id, postDTO);
        }

        [HttpDelete]
        public async Task<Post> DeletePost(int id)
        {
            return await repository.DeletePost(id);
        }
    }
}
