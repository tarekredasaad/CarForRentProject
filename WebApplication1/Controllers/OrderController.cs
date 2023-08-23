using DTO;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using Services;
using WebApplication1.Data.UnitOfWork;

namespace WebApplication1.Controllers
{
        [Route("api/[controller]")]
        [ApiController]
    public class OrderController : Controller
    {
        private readonly OrderServices orderServices;
        public OrderController( OrderServices orderServices
            )
        {
            this.orderServices = orderServices;        
        }
        [HttpPost("AddOrder")]
        public async Task<IActionResult> AddOrder(OrderDTO orderDTO)
        {
           return Ok(orderServices.AddOrder(orderDTO));
        }

        [HttpPost("addOrderCars")]
        public async Task<ActionResult> AddOrderCars(OrderCarsDTO carsDTOs)
        {
            // Handle carsDTOs
            return Ok(orderServices.AddCars(carsDTOs));
        }
    }
}
