using LatijnLogic.DTOs;

namespace LatijnLogic.Interfaces
{
    public interface IVragenLogic
    {
        public Task<List<VraagDTO>> GetVragenByToetsID(int toetsId);
        public Task<bool> SubmitAntwoord(AntwoordDTO antwoordDTO);
    }
}
