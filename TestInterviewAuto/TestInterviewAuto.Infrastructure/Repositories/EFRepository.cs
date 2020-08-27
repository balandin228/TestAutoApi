using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TestInterviewAuto.Domain.Model;

namespace TestInterviewAuto.Infrastructure.Repositories
{
      public abstract class EFRepository<TEntity> : IRepository<TEntity> where TEntity : Entity<long>
    {
        protected EFRepository(AutoDbContext context)
        {
            Context = context;
            _items = Context.Set<TEntity>();
        }

        private DbSet<TEntity> _items { get; }
        protected virtual IQueryable<TEntity> Items => _items;
        public AutoDbContext Context { get; }

        public async Task<TEntity> AddAsync(TEntity entity)
        {
            var entry = await _items.AddAsync(entity);
            return entry.Entity;
        }

        public Task AddRangeAsync(IEnumerable<TEntity> entities)
        {
            return _items.AddRangeAsync(entities);
        }

        public Task RemoveAsync(TEntity entity)
        {
            _items.Remove(entity);
            return Task.CompletedTask;
        }

        public Task RemoveRangeAsync(IEnumerable<TEntity> entities)
        {
            _items.RemoveRange(entities);
            return Task.CompletedTask;
        }

        public Task<List<TEntity>> ListAsync()
        {
            return Items.ToListAsync();
        }

        public Task<List<TEntity>> ListAsync(Expression<Func<TEntity, bool>> options)
        {
            return Items.Where(options).ToListAsync();
        }

        public Task<TEntity> FirstAsync()
        {
            return Items.FirstAsync();
        }

        public Task<TEntity> FirstAsync(Expression<Func<TEntity, bool>> options)
        {
            return Items.FirstAsync(options);
        }

        public Task<TEntity> FirstOrDefaultAsync()
        {
            return Items.FirstOrDefaultAsync();
        }

        public Task<TEntity> FirstOrDefaultAsync(Expression<Func<TEntity, bool>> options)
        {
            return Items.FirstOrDefaultAsync(options);
        }

        public Task<TEntity[]> GetWithInclude(params Expression<Func<TEntity, object>>[] options)
        {
            return options.Aggregate(Items,
                (current, includeOptions) => current.Include(includeOptions)).ToArrayAsync();
        }
    }
}