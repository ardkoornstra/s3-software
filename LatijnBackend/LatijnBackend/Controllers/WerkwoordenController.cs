using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LatijnBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WerkwoordenController : ControllerBase
    {
        // GET: api/<WerkwoordenController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<WerkwoordenController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }
    }
}
