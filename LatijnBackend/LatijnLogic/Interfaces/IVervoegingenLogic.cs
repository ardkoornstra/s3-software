using LatijnLogic.Types;

namespace LatijnLogic.Interfaces
{
    public interface IVervoegingenLogic
    {
        public Task<List<Vervoeging>> GetVervoegingen(int amount);
    }
}
