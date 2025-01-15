using AutoMapper;
using LatijnData.Models;
using LatijnLogic.DTOs;
using LatijnLogic.Types;

namespace LatijnAPI
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile() {
            CreateMap<WerkwoordEF, Werkwoord>();
            CreateMap<UitgangEF, Uitgang>();
            CreateMap<VervoegingEF, Vervoeging>();
            CreateMap<ToetsEF, Toets>();
            CreateMap<SessionEF, Session>();
            CreateMap<ToetsDTO, ToetsEF>();
        }
    }
}
