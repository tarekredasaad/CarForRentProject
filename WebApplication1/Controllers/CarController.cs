using Microsoft.AspNetCore.Mvc;
using Services;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : Controller
    {
        private readonly CarServices carServices;
        public CarController(CarServices _carServices) 
        {
            carServices = _carServices;
        }
        [HttpGet("GetCars")]
        public async Task<IActionResult> GetCars(int brand = 0,string name = null,int year = 0)
        {

            return Json(carServices.Get(brand,name,year));
        }
        //public async Task<IActionResult> GetCarsAfterFilter(int id)
        //{
            
        //    return Ok(carServices.Get(id));
        //}
        
    }
}
