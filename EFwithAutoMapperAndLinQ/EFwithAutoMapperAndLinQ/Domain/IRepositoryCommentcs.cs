using EFwithAutoMapperAndLinQ.Domain.DTO;
using EFwithAutoMapperAndLinQ.Domain.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace EFwithAutoMapperAndLinQ.Domain
{
    public interface IRepositoryCommentcs
    {
        public IQueryable GetAllComment();
        public Task<Comment> AddComment(CommentDTO commentDTO);
        public Task<Comment> UpdateComment(int id, CommentDTO commentDTO);
        public Task<Comment> DeleteComment(int id);
    }
}
