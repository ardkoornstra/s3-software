using LatijnLogic.Types;
using LatijnLogic.Interfaces;

namespace LatijnLogic.Services
{
    public class UitgangenLogic : IUitgangenLogic
    {
        private readonly IUitgangenData _data;

        public UitgangenLogic(IUitgangenData data)
        {
            _data = data;
        }

        public async Task<List<Uitgang>> GetAllUitgangen()
        {
            return await _data.GetAllUitgangen();
        }
    }
}
