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
    public class ThemeManager : IThemeService
    {

        IThemeRepository _themeRepository;

        public ThemeManager(IThemeRepository themeRepository)
        {
            _themeRepository = themeRepository; 
        }

        public async Task<Theme> AddAsync(Theme entity)
        {
            return await _themeRepository.AddNewAsync(entity);
        }

        public Task<IResult> AddNewAsync2(Theme entity)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Theme>> GetAllAsync()
        {
            return await _themeRepository.GetAllAsync();
        }

        public Task<Theme> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task TDelete(int id)
        {
            throw new NotImplementedException();
        }

        public Task TUpdate(int id, Theme entity)
        {
            throw new NotImplementedException();
        }
    }
}
