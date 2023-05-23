using Microsoft.EntityFrameworkCore;
using MovieCAApi.Domain.Repository;
using MovieCAApi.Infrastructure.Context;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MovieCAApi.Percistance.Domain.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private MovieDbContext movieDbContext;
        private readonly DbSet<TEntity> _entity;

        public Repository(MovieDbContext movieDbContext)
        {
            this.movieDbContext = movieDbContext;
            _entity = movieDbContext.Set<TEntity>();
        }

        public async void Add(TEntity entity)
        {
            await movieDbContext.AddAsync(entity); //bu database ile isleyir pramoy
                                                   // _entity.Add(entity); //bu ise entity ile isleyir
        }

        public void Update(TEntity entity)
        {
            movieDbContext.Update(entity);
        }

        public void Delete(TEntity entity)
        {
            movieDbContext.Remove(entity);
        }

        public async Task<IEnumerable<TEntity>> GetAll()
        {
            return await _entity.ToListAsync();
        }
    }
}
