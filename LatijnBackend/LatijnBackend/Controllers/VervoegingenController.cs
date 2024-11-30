using LatijnLogic.Interfaces;
using LatijnLogic.Types;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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

        [HttpGet]
        public async Task<List<Vervoeging>> Get(int amount)
        {
            _logic.
        }
    }
}
