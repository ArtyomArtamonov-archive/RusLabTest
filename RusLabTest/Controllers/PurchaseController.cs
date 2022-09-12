using Microsoft.AspNetCore.Mvc;
using RusLabTest.Models;

namespace RusLabTest.Controllers
{
    [ApiController]
    [Route("purchase")]
    public class PurchaseController : ControllerBase
    {
        private readonly ILogger<PurchaseController> _logger;

        public PurchaseController(ILogger<PurchaseController> logger)
        {
            _logger = logger;
        }

        [HttpGet("{id}")]
        public ActionResult<Purchase> Get(int id)
        {
            return Ok(new Purchase());
        }

        [HttpGet]
        public ActionResult<List<Purchase>> Get()
        {
            return Ok(new List<Purchase>());
        }
    }
}