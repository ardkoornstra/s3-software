using Microsoft.AspNetCore.Mvc;
using LatijnLogic.Types;
using LatijnLogic.Interfaces;

namespace LatijnAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UitgangenController : ControllerBase
    {
        private readonly IUitgangenLogic _logic;

        public UitgangenController(IUitgangenLogic logic)
        {
            _logic = logic;
        }

        //GET alle Uitgangen
        [HttpGet]
        public async Task<List<Uitgang>> Get()
        {
            List<Uitgang> Uitgangen = await _logic.GetAllUitgangen();
            return Uitgangen;
        }
    }
}
