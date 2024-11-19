using LatijnAPI.Models;

namespace LatijnAPI.Data
{
    public interface IWerkwoordenDataAccess
    {
        public List<Werkwoord> GetAllWerkwoorden();
    }
}
