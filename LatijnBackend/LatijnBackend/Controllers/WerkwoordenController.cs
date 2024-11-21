using Microsoft.AspNetCore.Mvc;
using LatijnLogic;
using LatijnLogic.Types;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LatijnAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WerkwoordenController : ControllerBase
    {
        private readonly IWerkwoordenLogic _logic;

        public WerkwoordenController(IWerkwoordenLogic logic)
        {
            _logic = logic;
        }


        // GET: api/<WerkwoordenController>
        [HttpGet("All")]
        public async Task<List<Werkwoord>> Get()
        {
            List<Werkwoord> werkwoorden = await _logic.GetAllWerkwoorden();
            return werkwoorden;
        }

        // GET api/<WerkwoordenController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }
    }
}
