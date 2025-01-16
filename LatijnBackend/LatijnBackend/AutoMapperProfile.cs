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
            CreateMap<Vervoeging, VervoegingEF>();
            CreateMap<ToetsEF, Toets>();
            CreateMap<SessionEF, Session>();
            CreateMap<ToetsDTO, ToetsEF>();
            CreateMap<ToetsEF, ToetsDTO>();
        }
    }
}
