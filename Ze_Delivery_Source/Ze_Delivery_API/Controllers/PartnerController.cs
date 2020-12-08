using Microsoft.AspNetCore.Mvc;
using Ze_Delivery_Domain.Entities;
using Ze_Delivery_Domain.Interfaces;

namespace Ze_Delivery_API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PartnerController : ControllerBase
    {
        public IPartnerService _partnerService;

        public PartnerController(IPartnerService partnerService)
        {
            _partnerService = partnerService;
        }

        [HttpGet]
        public ActionResult Get()
        {
            return StatusCode(200, _partnerService.Select());
        }

        [HttpGet("{id}")]
        public ActionResult Get(string id)
        {
            return StatusCode(200, _partnerService.Select(id));
        }

        [HttpPost("PDVS")]
        public ActionResult Post([FromBody] PDVs value)
        {
            _partnerService.Insert(value);
            return StatusCode(201, value);
        }

        [HttpPost]
        public ActionResult Post([FromBody] Partner value)
        {
            _partnerService.Insert(value);
            return StatusCode(201, value);
        }

        [HttpPut("{id}")]
        public ActionResult Put(string id, [FromBody] Partner value)
        {
            _partnerService.Update(id, value);
            return StatusCode(201, value);
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(string id)
        {
            _partnerService.Delete(id);
            return StatusCode(204);
        }
    }
}