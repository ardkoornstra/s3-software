using LatijnLogic.Types;

namespace LatijnLogic.Interfaces
{
    public interface IVervoegingenLogic
    {
        public Task<bool> CreateVervoegingen(int amount, int toetsId);
    }
}
