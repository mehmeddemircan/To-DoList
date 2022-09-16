using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelefonRehberi.Core.Utilities.Results;
using To_DoList.Business.Abstract;
using To_DoList.DataAccess.Abstract;
using To_DoList.Entities.Concrete;

namespace To_DoList.Business.Concrete
{
    public class ColorManager : IColorService
    {

        IColorRepository _colorRepository;

        public ColorManager(IColorRepository colorRepository)
        {
            _colorRepository = colorRepository; 
        }

        public async Task<Color> AddAsync(Color entity)
        {
            return await _colorRepository.AddNewAsync(entity);
        }

        public Task<IResult> AddNewAsync2(Color entity)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Color>> GetAllAsync()
        {
            return await _colorRepository.GetAllAsync();
        }

        public Task<Color> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task TDelete(int id)
        {
            throw new NotImplementedException();
        }

        public Task TUpdate(int id, Color entity)
        {
            throw new NotImplementedException();
        }
    }
}
