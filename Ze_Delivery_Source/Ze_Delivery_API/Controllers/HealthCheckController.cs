using Microsoft.AspNetCore.Mvc;

namespace Ze_Delivery.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class HealthCheckController : ControllerBase
    {
        [HttpGet]
        public ActionResult Get()
        {
            return StatusCode(200);
        }
    }
}
