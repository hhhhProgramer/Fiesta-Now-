using AutoMapper;
using Domain.DTOs;
using Entity;

namespace Infrestructure.Mappings
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Academia, AcademiaRequestDto>();
            CreateMap<Academia, AcademiaResponseDto>();
            CreateMap<AcademiaRequestDto, Academia>()
            .AfterMap((source, destination) =>
            {
                destination.cuenta = new Cuenta()
                {
                    Rol = source.Rol,
                    Correo = source.Correo,
                    Password = source.Password,
                    Estatus = true
                };
            });

            CreateMap<Cuenta, CuentaRequestDto>();
            CreateMap<Cuenta, CuentaResponseDto>();
            CreateMap<CuentaRequestDto, Cuenta>();

            CreateMap<Horario,HorarioRequestDto>();
            CreateMap<Horario,HorarioResponseDto>()
            .AfterMap((source,destination) => {
                destination.Apertura = 
                source.Apertura.Hour.ToString() +":"+
                source.Apertura.Minute.ToString();

                destination.Cierre =
                source.Cierre.Hour.ToString() +":"+
                source.Cierre.Minute.ToString();
            });

            CreateMap<HorarioRequestDto,Horario>();

            CreateMap<Clase,ClaseRequestDto>();
            CreateMap<ClaseRequestDto,Clase>();
            CreateMap<Clase,ClaseResponseDto>()
            .AfterMap((source,destination) => {
                destination.Horarios = $"https://localhost:5001/api/horario/{source.Id}";
            });
            
        }
    }
}