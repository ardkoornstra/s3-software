using LatijnLogic.Types;

namespace LatijnLogic.Interfaces
{
    public interface IVervoegingenData
    {
        public Task<List<Vervoeging>> GetAllVervoegingen();
        public Task<Vervoeging> GetVervoeging(int Id);
        public Task<List<Vervoeging>> GetVervoegingenByToetsID(int toetsId);
        public Task<bool> CreateVervoegingen(List<Vervoeging> vervoegingen);
    }
}
