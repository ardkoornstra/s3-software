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
    public class ToetsenController : ControllerBase
    {
        private readonly IToetsenLogic _logic;

        public ToetsenController(IToetsenLogic logic)
        {
            _logic = logic;
        }

        [HttpGet]
        public async Task<ToetsDTO> GetToets(int id)
        {
            return await _logic.GetToets(id);
        }

        [HttpPost]
        public async Task<int> CreateToets(ToetsDTO toetsDTO)
        {            
            int Id = await _logic.CreateToets(toetsDTO);
            return Id;
        }
    }
}
