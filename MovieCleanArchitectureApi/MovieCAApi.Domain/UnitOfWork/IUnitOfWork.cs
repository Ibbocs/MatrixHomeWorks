using MovieCAApi.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieCAApi.Domain.UnitOfWork
{
    public interface IUnitOfWork<TRepo> : IDisposable where TRepo : class
    {
        public IRepository<TRepo> repository { get; }
        Task<bool> SaveChangesAsync();
    }
}
