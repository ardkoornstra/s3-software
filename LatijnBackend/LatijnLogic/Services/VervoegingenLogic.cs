using LatijnLogic.Interfaces;
using LatijnLogic.Types;

namespace LatijnLogic.Services
{
    public class VervoegingenLogic : IVervoegingenLogic
    {
        private readonly IUitgangenData _uitgangenData;
        private readonly IWerkwoordenData _werkwoordenData;

        public VervoegingenLogic(IUitgangenData uitgangenData, IWerkwoordenData werkwoordenData)
        {
            _uitgangenData = uitgangenData;
            _werkwoordenData = werkwoordenData;
        }

        public async Task<List<Vervoeging>> GetVervoegingen(int amount)
        {

        }
    }
}
