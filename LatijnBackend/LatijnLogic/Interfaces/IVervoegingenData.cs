using LatijnLogic.Types;

namespace LatijnLogic.Interfaces
{
    public interface IVervoegingenData
    {
        public Task<List<Vervoeging>> GetAllVervoegingen();
        public Task<bool> CreateVervoegingen(List<Vervoeging> vervoegingen);
    }
}
