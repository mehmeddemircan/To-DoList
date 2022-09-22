using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using To_DoList.Business.Abstract;
using To_DoList.Entities.Concrete;

namespace To_DoList.WebApi.Areas.Admin
{

    [Area("Admin")]
    [Route("api/admin/[controller]")]
    [ApiController]
    public class ThemesController : ControllerBase
    {
        IThemeService _themeService;

        public ThemesController(IThemeService themeService)
        {
            _themeService = themeService;
        }

    

        [HttpPost("add-theme")]

        public async Task<ActionResult<Theme>> AddTheme(Theme theme)
        {
            return await _themeService.AddAsync(theme);
        }


        [HttpDelete("delete-theme")]

        public async Task DeleteTheme(int id)
        {
           await _themeService.TDelete(id); 
        }

        [HttpPut("update-theme")]

        public async Task UpdateTheme(int id ,Theme theme)
        {
            id = theme.Id;
            await _themeService.TUpdate(id, theme); 
        }


        [HttpGet("get-something")]
        public IActionResult Get() { return Ok("api controller"); }

    }
}
