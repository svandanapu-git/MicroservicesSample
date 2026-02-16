using Microsoft.AspNetCore.Mvc;

namespace MicroservicesSample.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PaymentController : ControllerBase
    {
        [HttpPost]
        public IActionResult ProcessPayment(decimal amount)
        {
            if (amount > 1000)
                return BadRequest("Payment Failed");

            return Ok("Payment Success");
        }
    }

}
