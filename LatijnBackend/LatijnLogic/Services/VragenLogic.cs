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

        public async Task<bool> SubmitAntwoord(AntwoordDTO antwoordDTO)
        {
            Vervoeging vervoeging = await _data.GetVervoeging(antwoordDTO.Id);
            bool isCorrect = false;
            if (antwoordDTO.Modus == vervoeging.Modus &&
                antwoordDTO.Tempus == vervoeging.Tempus &&
                antwoordDTO.Genus == vervoeging.Genus &&
                antwoordDTO.Persoon == vervoeging.Persoon &&
                antwoordDTO.Getal == vervoeging.Getal)
            {
                isCorrect = true;
            } else
            {
                isCorrect = false;
            }
            return await _data.UpdateIsCorrect(antwoordDTO.Id, isCorrect);
        }
    }
}
