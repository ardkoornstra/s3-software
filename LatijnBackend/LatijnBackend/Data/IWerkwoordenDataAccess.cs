using LatijnBackend.Models;

namespace LatijnBackend.Data
{
    public interface IWerkwoordenDataAccess
    {
        public List<Werkwoord> GetAllWerkwoorden();
    }
}
