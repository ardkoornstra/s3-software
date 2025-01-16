using AutoMapper;
using LatijnData.Models;
using LatijnLogic.DTOs;
using LatijnLogic.Interfaces;
using LatijnLogic.Types;
using Microsoft.EntityFrameworkCore;

namespace LatijnData.Repositories
{
    public class SessionsData : ISessionsData
    {
        private readonly LatijnDbContext _dbContext;
        private readonly IMapper _mapper;

        public SessionsData(LatijnDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<Session> GetSession(int id)
        {
            SessionEF sessionEF = await _dbContext.Sessions.Include(s => s.ToetsenEF).FirstOrDefaultAsync(s => s.Id == id);
            Session session = _mapper.Map<Session>(sessionEF);
            return session;
        }

        public async Task<List<Session>> GetSessionsByDocent(int docentId)
        {
            List<SessionEF> sessionsEF = await _dbContext.Sessions.Where(s => s.DocentId == docentId).ToListAsync();
            List<Session> sessions = _mapper.Map<List<Session>>(sessionsEF);
            return sessions;
        }

        public async Task<int> CreateSession(int docentId)
        {
            SessionEF session = new SessionEF() { Id = 0, DocentId = docentId };
            _dbContext.Sessions.Add(session);
            await _dbContext.SaveChangesAsync();
            return session.Id;
        }
    }
}
