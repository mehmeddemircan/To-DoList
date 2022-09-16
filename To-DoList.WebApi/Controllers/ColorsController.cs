using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using To_DoList.Business.Abstract;
using To_DoList.Entities.Concrete;

namespace To_DoList.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ColorsController : ControllerBase
    {
        IColorService _colorService;

        public ColorsController(IColorService colorService)
        {
            _colorService = colorService;
        }



        [HttpPost("add-color")]

        public async Task<ActionResult<Color>> AddColor(Color color)
        {
            return await _colorService.AddAsync(color); 
        }


        [HttpGet("get-all-color")]

        public async Task<ActionResult<List<Color>>> GetColors()
        {
            return await _colorService.GetAllAsync();
        }

        


    }
}
