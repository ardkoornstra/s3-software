using LatijnBackend.Models;
using LatijnBackend.Data;
using Microsoft.EntityFrameworkCore;

namespace LatijnBackend.Logic
{
    public class WerkwoordenLogic : IWerkwoordenLogic
    {
        private readonly IWerkwoordenDataAccess _dataAccess;

        public WerkwoordenLogic(IWerkwoordenDataAccess dataAccess) {
            _dataAccess = dataAccess;
        }

        public List<Werkwoord> GetAllWerkwoorden()
        {
            List<Werkwoord> werkwoorden = _dataAccess.GetAllWerkwoorden();
            return werkwoorden;
        }

    }
}
