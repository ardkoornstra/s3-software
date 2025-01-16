﻿using LatijnLogic.Types;

namespace LatijnLogic.Interfaces
{
    public interface ISessionsData
    {
        public Task<Session> GetSession(int id);
        public Task<List<Session>> GetSessionsByDocent(int docentId);
        public Task<int> CreateSession(int docentId);
    }
}
