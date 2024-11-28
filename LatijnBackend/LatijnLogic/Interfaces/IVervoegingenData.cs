using LatijnLogic.Types;

namespace LatijnLogic.Interfaces
{
    public interface IVervoegingenData
    {
        public Task<List<Vervoeging>> GetAllVervoegingen();
    }
}
