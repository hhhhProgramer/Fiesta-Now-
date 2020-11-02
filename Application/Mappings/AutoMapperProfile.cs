using AutoMapper;
using Domain.DTOs;
using Entity;

namespace Infrestructure.Mappings
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Academia,AcademiaRequestDto>();
            CreateMap<Academia,AcademiaResponseDto>();
            CreateMap<AcademiaRequestDto,Academia>();

            CreateMap<Cuenta,CuentaRequestDto>();
            CreateMap<Cuenta,CuentaResponseDto>();
            CreateMap<CuentaRequestDto,Cuenta>();

        }
    }
}