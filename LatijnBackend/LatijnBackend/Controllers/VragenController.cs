using AutoMapper;
using LatijnLogic.DTOs;
using LatijnLogic.Interfaces;
using LatijnLogic.Types;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace LatijnAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VragenController : ControllerBase
    {
        private readonly IVragenLogic _logic;

        public VragenController(IVragenLogic logic)
        {
            _logic = logic;
        }

        [HttpGet]
        public async Task<List<VraagDTO>> GetVragenByToetsID(int toetsId)
        {
            return await _logic.GetVragenByToetsID(toetsId);
        }

        [HttpPost]
        public async Task<bool> SubmitAntwoord(AntwoordDTO antwoordDTO)
        {
            return await _logic.SubmitAntwoord(antwoordDTO);
        }
    }
}
