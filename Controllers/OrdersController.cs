using MicroservicesSample.Models;
using Microsoft.AspNetCore.Mvc;

namespace MicroservicesSample.Controllers
{
    [ApiController]
    //[Route("api/orders")]
    [Route("[controller]")]
    public class OrdersController : ControllerBase
    {
        private static List<Order> Orders = new();

        private readonly ILogger<OrdersController> _logger;

        public OrdersController(ILogger<OrdersController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public IActionResult CreateOrder(Order order)
        {
            order.Status = "Pending";
            Orders.Add(order);

            return Ok(order);
        }
    }

}
