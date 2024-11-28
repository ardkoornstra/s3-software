using Microsoft.AspNetCore.Mvc;
using LatijnLogic.Types;
using LatijnLogic.Interfaces;

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

        // GET alle Werkwoorden
        [HttpGet]
        public async Task<List<Werkwoord>> Get()
        {
            List<Werkwoord> werkwoorden = await _logic.GetAllWerkwoorden();
            return werkwoorden;
        }
    }
}
