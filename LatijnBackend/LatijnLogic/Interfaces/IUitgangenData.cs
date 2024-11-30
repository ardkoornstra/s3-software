using LatijnLogic.Types;

namespace LatijnLogic.Interfaces
{
    public interface IUitgangenData
    {
        public Task<List<Uitgang>> GetAllUitgangen();
    }
}
