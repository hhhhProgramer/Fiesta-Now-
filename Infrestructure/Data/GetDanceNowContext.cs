using System;
using Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Infrestructure.Infrestructure
{
    public partial class GetDanceNowContext : DbContext
    {
        public GetDanceNowContext()
        {
        }

        public GetDanceNowContext(DbContextOptions<GetDanceNowContext> options)
            : base(options)
        {
        }

        DbSet<Academia> Academias {get;}
        DbSet<Clase_Suscripciones> Clases_Suscripciones {get;}
        DbSet<Clase> Clases {get;}
        DbSet<CodigoBaile> CodigoBailes {get;}
        DbSet<Cuenta> Cuentas {get;}
        DbSet<Estudiante> Estudiantes {get;}
        DbSet<Horario> Horarios {get;}
        DbSet<Suscripcion> Suscripcions {get;}
       
    }
}
