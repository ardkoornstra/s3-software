using Microsoft.AspNetCore.Mvc;
using LatijnBackend.Models;
using LatijnBackend.Logic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LatijnBackend.Controllers
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
        [HttpGet]
        public IEnumerable<Werkwoord> Get()
        {
            List<Werkwoord> werkwoorden = _logic.GetAllWerkwoorden();
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
