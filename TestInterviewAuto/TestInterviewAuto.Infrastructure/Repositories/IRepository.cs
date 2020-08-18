using System.Collections.Generic;
using System.Threading.Tasks;
using TestInterviewAuto.Domain.Model;

namespace TestInterviewAuto.Infrastructure.Repositories
{
    public interface IRepository<TEntity> : IReadOnlyRepository<TEntity> where TEntity : Entity<long>
    {
        AutoDbContext Context { get; }

        Task<TEntity> AddAsync(TEntity entity);
        Task AddRangeAsync(IEnumerable<TEntity> entities);
        Task RemoveAsync(TEntity entity);
        Task RemoveRangeAsync(IEnumerable<TEntity> entities);
    }
}