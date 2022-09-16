using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using To_DoList.Entities.Common;

namespace To_DoList.Core.DataAccess
{
    public interface IEntityRepository<T> where T : BaseEntity , new() 
    {

        public Task<List<T>> GetAllAsync();

        public Task<T> GetSingle(Expression<Func<T, bool>> filter);

        public Task<List<T>> GetList(Expression<Func<T, bool>> filter = null);

        public Task TUpdate(int id, T entity); 
        public Task TDelete(int id); 

        public Task<T>  AddNewAsync2(T entity); 
        public Task<T> AddNewAsync(T entity);
    }
}
