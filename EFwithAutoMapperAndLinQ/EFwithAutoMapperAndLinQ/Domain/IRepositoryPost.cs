using EFwithAutoMapperAndLinQ.Domain.DTO;
using EFwithAutoMapperAndLinQ.Domain.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace EFwithAutoMapperAndLinQ.Domain
{
    public interface IRepositoryPost
    {
        public Task<PostDTO> AddPost(PostDTO postDTO);
        public IQueryable GetAllPost();
        public Task<Post> UpdatePost(int id, PostDTO postDTO);
        public Task<Post> DeletePost(int id);
    }
}
