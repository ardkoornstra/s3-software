using LatijnLogic.Interfaces;
using LatijnLogic.Types;

namespace LatijnLogic.Services
{
    public class SessionsLogic : ISessionsLogic
    {
        private readonly ISessionsData _data;

        public SessionsLogic(ISessionsData data)
        {
            _data = data;
        }

        public async Task<Session> GetSession(int id)
        {
            return await _data.GetSession(id);
        }

        public async Task<List<Session>> GetSessionsByDocent(int docentId)
        {
            return await _data.GetSessionsByDocent(docentId);
        }

        public async Task<int> CreateSession(int docentId)
        {
            return await _data.CreateSession(docentId);
        }
    }
}
