using LatijnBackend.Models;
using Microsoft.EntityFrameworkCore;

namespace LatijnBackend.Data
{
    public class WerkwoordenDataAccess : IWerkwoordenDataAccess
    {
        private readonly LatijnContext ?_dbContext;

        public WerkwoordenDataAccess()
        {
            //_dbContext = dbContext;
        }

        public List<Werkwoord> GetAllWerkwoorden()
        {
            return _dbContext.Werkwoorden.ToList();
        }
    }
}
