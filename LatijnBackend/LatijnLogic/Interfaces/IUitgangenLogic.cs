using LatijnLogic.Types;

namespace LatijnLogic.Interfaces
{
    public interface IUitgangenLogic
    {
        public Task<List<Uitgang>> GetAllUitgangen();
    }
}
