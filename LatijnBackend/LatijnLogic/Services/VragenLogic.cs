using LatijnLogic.DTOs;
using LatijnLogic.Interfaces;
using LatijnLogic.Types;

namespace LatijnLogic.Services
{
    public class VragenLogic : IVragenLogic
    {
        private readonly IVervoegingenData _data;

        public VragenLogic(IVervoegingenData data)
        {
            _data = data;
        }

        public async Task<List<VraagDTO>> GetVragenByToetsID(int toetsId)
        {
            List<Vervoeging> vervoegingen = await _data.GetVervoegingenByToetsID(toetsId);
            List<VraagDTO> vragen = new List<VraagDTO>();

            foreach (Vervoeging vervoeging in vervoegingen)
            {
                VraagDTO vraag = new VraagDTO() {
                    Id = vervoeging.Id,
                    Vorm = vervoeging.Vorm,
                    Infinitivus = vervoeging.Infinitivus,
                    Praesens = vervoeging.Praesens,
                    Perfectum = vervoeging.Perfectum,
                    Supinum = vervoeging.Supinum,
                    Betekenis = vervoeging.Betekenis,
                };
                vragen.Add(vraag);
            }

            return vragen;
        }
    }
}
