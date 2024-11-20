using AutoMapper;
using LatijnData.Models;
using LatijnLogic.Types;

namespace LatijnLogic
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile() {
            CreateMap<WerkwoordEF, Werkwoord>();
        }
    }
}
