using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using To_DoList.Entities.Common;

namespace To_DoList.Core.DataAccess.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
        where TEntity : BaseEntity, new()
        where TContext : DbContext , new()
    {
        public async Task<TEntity> AddNewAsync(TEntity entity)
        {
            using (var context = new TContext())
            {
                await context.Set<TEntity>().AddAsync(entity);
                await context.SaveChangesAsync();

                return entity;
            }
        }

        public async Task<TEntity> AddNewAsync2(TEntity entity)
        {
            using (var context = new TContext())
            {
                await context.Set<TEntity>().AddAsync(entity);
                await context.SaveChangesAsync();
                return entity;
            }

         
        }

        public async Task<TEntity> GetSingle(Expression<Func<TEntity, bool>> filter)
        {
            using (var context = new TContext())
            {
                return await context.Set<TEntity>().SingleOrDefaultAsync(filter); 
            }
        }

        public async Task<List<TEntity>> GetAllAsync()
        {
            using (var context = new TContext())
            {
                return await context.Set<TEntity>().ToListAsync();
            }
        }

        public async Task<List<TEntity>> GetList(Expression<Func<TEntity, bool>> filter = null)
        {
            using (var context = new TContext())
            {
                return filter == null
                    ? await  context.Set<TEntity>().ToListAsync()
                    : await  context.Set<TEntity>().Where(filter).ToListAsync();
            }
        }

        public async Task TUpdate(int id, TEntity entity)
        {
            using (var context = new TContext())
            {
                context.Set<TEntity>().Update(entity); 
                await context.SaveChangesAsync();    
            }
        }

        public async Task TDelete(int id)
        {
            using (var context = new TContext())
            {   

                var entity = await GetSingle((e) => e.Id == id);

                context.Set<TEntity>().Remove(entity);
                await context.SaveChangesAsync(); 
            }
        }
    }
}
