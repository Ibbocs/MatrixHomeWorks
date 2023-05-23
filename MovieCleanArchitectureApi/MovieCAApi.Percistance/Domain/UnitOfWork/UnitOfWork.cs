using MovieCAApi.Domain.Repository;
using MovieCAApi.Domain.UnitOfWork;
using MovieCAApi.Infrastructure.Context;
using MovieCAApi.Percistance.Domain.Repository;
using System.Threading.Tasks;

namespace MovieCAApi.Percistance.Domain.UnitOfWork
{
    public class UnitOfWork<TRepo> : IUnitOfWork<TRepo> where TRepo : class
    {
        private MovieDbContext movieDbContext;
        private IRepository<TRepo> myRepo;
        public UnitOfWork(MovieDbContext _movieDbContext)
        {
            movieDbContext = _movieDbContext;
        }
        public IRepository<TRepo> repository
        {
            get
            {
                if (myRepo == null)
                {
                    myRepo = new Repository<TRepo>(movieDbContext);
                }
                return myRepo;
            }
        }

        public void Dispose()
        {
            movieDbContext.Dispose();
        }

        public async Task<bool> SaveChangesAsync()
        {
            await movieDbContext.SaveChangesAsync();
            return true;
        }
    }
}
