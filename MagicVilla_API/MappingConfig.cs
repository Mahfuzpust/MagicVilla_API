﻿using AutoMapper;
using MagicVilla_API.Models.DTO;
using MagicVilla_API.Models;

namespace MagicVilla_API
{
    public class MappingConfig : Profile
    {
        public MappingConfig()
        {
            CreateMap<Villa, VillaDTO>();
            CreateMap<VillaDTO, Villa>();

            CreateMap<Villa, VillaCrateDTO>().ReverseMap();
            CreateMap<Villa, VillaUpdateDTO>().ReverseMap();

            CreateMap<VillaNumber, VillaNumberDTO>().ReverseMap();

            CreateMap<VillaNumber, VillaNumberCrateDTO>().ReverseMap();
            CreateMap<VillaNumber, VillaNumberUpdateDTO>().ReverseMap();
        }
    }
}
