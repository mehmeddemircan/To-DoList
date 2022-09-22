using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using To_DoList.Business.Abstract;
using To_DoList.Entities.Concrete;

namespace To_DoList.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ThemesController : ControllerBase
    {
        IThemeService _themeService;

        public ThemesController(IThemeService themeService)
        {
            _themeService = themeService;
        }


        [HttpGet("get-all-theme")]

        public async Task<ActionResult<List<Theme>>> GetAllTheme()
        {
            return await _themeService.GetAllAsync(); 
        }


      

    }
}
