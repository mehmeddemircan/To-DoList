using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using To_DoList.Entities.Common;

namespace To_DoList.Core.DataAccess.Dapper
{
    public class DapperRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
        where TEntity : BaseEntity, new()
        where TContext : DbContext
    {
        public Task<TEntity> AddNewAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> AddNewAsync2(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> GetSingle(Expression<Func<TEntity, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public Task<List<TEntity>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<List<TEntity>> GetList(Expression<Func<TEntity, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Task TUpdate(int id, TEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task TDelete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
