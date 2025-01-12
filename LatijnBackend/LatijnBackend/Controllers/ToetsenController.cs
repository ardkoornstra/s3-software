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
        private readonly IMapper _mapper;

        public ToetsenController(IToetsenLogic logic, IMapper mapper)
        {
            _logic = logic;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<int> CreateToets(ToetsDTO toetsDTO)
        {
            
            int Id = await _logic.CreateToets(toetsDTO);
            return Id;
        }
    }
}
