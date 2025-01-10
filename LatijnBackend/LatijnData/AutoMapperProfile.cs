﻿using AutoMapper;
using LatijnData.Models;
using LatijnLogic.Types;

namespace LatijnData
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile() {
            CreateMap<WerkwoordEF, Werkwoord>();
            CreateMap<UitgangEF, Uitgang>();
            CreateMap<VervoegingEF, Vervoeging>();
            CreateMap<ToetsEF, Toets>();
            CreateMap<KlasEF, Klas>();
        }
    }
}