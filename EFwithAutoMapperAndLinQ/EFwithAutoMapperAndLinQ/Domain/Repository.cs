using AutoMapper;
using EFwithAutoMapperAndLinQ.Domain.DTO;
using EFwithAutoMapperAndLinQ.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using System;


namespace EFwithAutoMapperAndLinQ.Domain
{
    public class Repository : IRepositoryPost, IRepositoryCommentcs
    {
        private BlogDbConText _blogDbContext;
        private IMapper mapper;
        public Repository(BlogDbConText blogDbContext, IMapper _mapper)
        {
            _blogDbContext = blogDbContext;
            mapper = _mapper;
        }

        /*buna task yazmadim, cunki await hara yazacagimi bilmedim...*/
        public IQueryable GetAllPost()
        {
            //bele bir istifade ne ucundu??
            //using (var ctx = new BlogDbConText())B
            //{

            //}
            /*commenti bele elave elmeyim ne olur ki?*/
            var data = from s in _blogDbContext.Posts
                       select new { Id = s.Id, AuthorId = s.AuthorId, Text = s.Text, PubDate = s.PublishedData, Comments = s.Comments };

            return data;

            #region cehdler
            ////List<Post> postList = post;

            ////var posts = from p in post.Posts
            ////                select p;

            //List<PostDTO> posts = new List<PostDTO>();
            //var all = await _blogDbContext.Posts.ToListAsync();

            //mapper.Map<Post>(all);

            //return posts;


            ////using ( var context = new BlogDbConText())
            ////{
            ////    var all = await context.Posts.ToListAsync();
            ////}
            #endregion
        }

        public async Task<PostDTO> AddPost(PostDTO postDTO)
        {
            var data = mapper.Map<Post>(postDTO);
            await _blogDbContext.Posts.AddAsync(data);
            await _blogDbContext.SaveChangesAsync();
            return postDTO;
        }

        public async Task<Post> UpdatePost(int id, PostDTO postDTO)
        {
            
            var oldData = await _blogDbContext.Posts.FirstOrDefaultAsync(s => s.Id == id);
            var newData = mapper.Map<Post>(postDTO);
            //bu setiri yazmasam mapperle atib savechange eleyende niye update elemir ki?
            _blogDbContext.Entry(oldData).CurrentValues.SetValues(newData);
            await _blogDbContext.SaveChangesAsync();
            return newData;
        }

        public async Task<Post> DeletePost(int id) 
        {
            Post post = _blogDbContext.Posts.FirstOrDefault(s=> s.Id == id);
            _blogDbContext.Posts.Remove(post);
            await _blogDbContext.SaveChangesAsync();
            return post;
        }

        public IQueryable GetAllComment()
        {
            //bu yazi men nece eleyim??
            //var data = from s in _blogDbContext.Comments
            //           select s.FirstOrDefault<Comment>();

            var data = from s in _blogDbContext.Comments
                       select new { Id = s.Id, AuthorId = s.AuthorId, Text = s.Text, Post = s.Post};

            return data;
        }

        public async Task<Comment> AddComment(CommentDTO commentDTO)
        {
            var data = mapper.Map<Comment>(commentDTO);
            await _blogDbContext.Comments.AddAsync(data);
            await _blogDbContext.SaveChangesAsync();
            return data;
        }

        public async Task<Comment> UpdateComment(int id, CommentDTO commentDTO)
        {

            var oldData = await _blogDbContext.Comments.FirstOrDefaultAsync(s => s.Id == id);
            var newData = mapper.Map<Comment>(commentDTO);
            //bu setiri yazmasam mapperle atib savechange eleyende niye update elemir ki?
            _blogDbContext.Entry(oldData).CurrentValues.SetValues(newData);
            await _blogDbContext.SaveChangesAsync();
            return newData;
        }

        public async Task<Comment> DeleteComment(int id)
        {
            Comment coment = _blogDbContext.Comments.FirstOrDefault(s => s.Id == id);
            _blogDbContext.Comments.Remove(coment);
            await _blogDbContext.SaveChangesAsync();
            return coment;
        }
    }
}
