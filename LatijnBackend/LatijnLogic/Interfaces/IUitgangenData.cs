using LatijnLogic.Types;

namespace LatijnLogic.Interfaces
{
    public interface IUitgangenData
    {
        public Task<List<Uitgang>> GetAllUitgangen();

        public Task<List<Uitgang>> GetUitgangen(List<int> uitgangenIDs);
    }
}
