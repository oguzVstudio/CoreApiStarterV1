using Microsoft.EntityFrameworkCore;
using sTest.MetaData.Core.Interfaces.Repositories.Base;
using sTest.MetaData.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace sTest.MetaData.DataAccess.Repositories.Base
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly ApplicationDbContext Context;


        public Repository(ApplicationDbContext context)
        {
            this.Context = context;
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await Context
                .Set<TEntity>()
                .AsNoTracking()
                .ToListAsync();
        }

        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate,
            params Expression<Func<TEntity, object>>[] navigationProperties)
        {
            IQueryable<TEntity> dbQuery = Context
                .Set<TEntity>();

            foreach (Expression<Func<TEntity, object>> navigationProperty in navigationProperties)
                dbQuery = dbQuery.Include<TEntity, object>(navigationProperty);

            return dbQuery
                .AsNoTracking()
                .Where(predicate)
                .ToList<TEntity>();
        }

        public Task<TEntity> SingleOrDefaultAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return Context
                .Set<TEntity>()
                .AsNoTracking()
                .SingleOrDefaultAsync(predicate);
        }

        public async Task AddAsync(TEntity entity)
        {
            await Context
                .Set<TEntity>()
                .AddAsync(entity);
        }

        public async Task AddAsync(params TEntity[] entities)
        {
            foreach (TEntity entity in entities)
                await Context.Set<TEntity>()
                    .AddAsync(entity);
        }

        public void Remove(TEntity entity)
        {
            Context
                .Set<TEntity>()
                .Remove(entity);
        }

        public void Remove(params TEntity[] entities)
        {
            foreach (var entity in entities)
                Context
                    .Set<TEntity>()
                    .Remove(entity);
        }

        public void Update(TEntity entity)
        {
            Context
                .Set<TEntity>()
                .Update(entity);
        }

        public void Update(params TEntity[] entities)
        {
            foreach (var entity in entities)
                Context
                    .Set<TEntity>()
                    .Update(entity);
        }
    }
}
