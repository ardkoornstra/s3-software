using LatijnBackend.Models;
using Microsoft.EntityFrameworkCore;

namespace LatijnBackend.Data
{
    public class WerkwoordenDataAccess : IWerkwoordenDataAccess
    {
        private readonly LatijnContext _dbContext;

        WerkwoordenDataAccess(LatijnContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Werkwoord> GetAllWerkwoorden()
        {
            return _dbContext.Werkwoorden.ToList();
        }
    }
}
