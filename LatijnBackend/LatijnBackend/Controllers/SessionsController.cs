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
    public class SessionsController : ControllerBase
    {
        private readonly ISessionsLogic _logic;

        public SessionsController(ISessionsLogic logic)
        {
            _logic = logic;
        }

        [HttpGet]
        public async Task<Session> GetSession(int id)
        {
            return await _logic.GetSession(id);
        }

        [HttpGet("docent/")]
        public async Task<List<Session>> GetSessionsByDocent(int docentId)
        {
            return await _logic.GetSessionsByDocent(docentId);
        }

        [HttpPost]
        public async Task<int> CreateSession(int docentId)
        {
            return await _logic.CreateSession(docentId);
        }
    }
}
