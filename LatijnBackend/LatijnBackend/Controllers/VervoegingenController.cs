using Microsoft.AspNetCore.Mvc;
using LatijnLogic.Types;
using LatijnLogic.Interfaces;

namespace LatijnAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VervoegingenController : ControllerBase
    {
        private readonly IVervoegingenLogic _logic;

        public VervoegingenController(IVervoegingenLogic logic)
        {
            _logic = logic;
        }

        //GET alle Vervoegingen
        [HttpGet]
        public async Task<List<Vervoeging>> Get()
        {
            List<Vervoeging> vervoegingen = await _logic.GetAllVervoegingen();
            return vervoegingen;
        }
    }
}
