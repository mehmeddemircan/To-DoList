using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelefonRehberi.Core.Utilities.Results;

namespace To_DoList.Business.Abstract
{
    public interface IGenericService<T>
    {

        public Task<List<T>> GetAllAsync();


        public Task<T> GetById(int id); 

        public Task TUpdate(int id, T entity);
        public Task TDelete(int id);

        public Task<IResult> AddNewAsync2(T entity); 

        public Task<T> AddAsync(T entity);


    }
}
