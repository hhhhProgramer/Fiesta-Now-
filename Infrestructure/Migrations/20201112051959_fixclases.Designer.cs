﻿// <auto-generated />
using System;
using Infrestructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Infrestructure.Migrations
{
    [DbContext(typeof(GetDanceNowContext))]
    [Migration("20201112051959_fixclases")]
    partial class fixclases
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Entity.Academia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CuentaID")
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direction")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Latitud")
                        .HasColumnType("float");

                    b.Property<string>("Logo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Longitud")
                        .HasColumnType("float");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Numero")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CuentaID");

                    b.ToTable("Academias");
                });

            modelBuilder.Entity("Entity.Clase", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AcademiaId")
                        .HasColumnType("int");

                    b.Property<int>("AlumnosMax")
                        .HasColumnType("int");

                    b.Property<int>("ClaseID")
                        .HasColumnType("int");

                    b.Property<int>("CodigoBaileID")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AcademiaId");

                    b.HasIndex("CodigoBaileID");

                    b.ToTable("Clases");
                });

            modelBuilder.Entity("Entity.Clase_Suscripciones", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClaseID")
                        .HasColumnType("int");

                    b.Property<int>("SuscripcionID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ClaseID");

                    b.HasIndex("SuscripcionID");

                    b.ToTable("Clases_Suscripciones");
                });

            modelBuilder.Entity("Entity.CodigoBaile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AcademiaId")
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tipo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AcademiaId");

                    b.ToTable("CodigoBailes");
                });

            modelBuilder.Entity("Entity.Cuenta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Correo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Estatus")
                        .HasColumnType("bit");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Rol")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Cuentas");
                });

            modelBuilder.Entity("Entity.Estudiante", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CuentaID")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CuentaID");

                    b.ToTable("Estudiantes");
                });

            modelBuilder.Entity("Entity.Horario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Apertura")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Cierre")
                        .HasColumnType("datetime2");

                    b.Property<int>("ClaseId")
                        .HasColumnType("int");

                    b.Property<string>("Dia")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ClaseId");

                    b.ToTable("Horarios");
                });

            modelBuilder.Entity("Entity.Suscripcion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CuentaId")
                        .HasColumnType("int");

                    b.Property<string>("Detalles")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Inicio")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Vencimiento")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CuentaId");

                    b.ToTable("Suscripcions");
                });

            modelBuilder.Entity("Entity.Academia", b =>
                {
                    b.HasOne("Entity.Cuenta", "cuenta")
                        .WithMany()
                        .HasForeignKey("CuentaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Entity.Clase", b =>
                {
                    b.HasOne("Entity.Academia", "Academia")
                        .WithMany("Clases")
                        .HasForeignKey("AcademiaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entity.CodigoBaile", "CodigoBaile")
                        .WithMany()
                        .HasForeignKey("CodigoBaileID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Entity.Clase_Suscripciones", b =>
                {
                    b.HasOne("Entity.Clase", "Clase")
                        .WithMany()
                        .HasForeignKey("ClaseID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entity.Suscripcion", "Suscripcion")
                        .WithMany()
                        .HasForeignKey("SuscripcionID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Entity.CodigoBaile", b =>
                {
                    b.HasOne("Entity.Academia", null)
                        .WithMany("CodigoBailes")
                        .HasForeignKey("AcademiaId");
                });

            modelBuilder.Entity("Entity.Estudiante", b =>
                {
                    b.HasOne("Entity.Cuenta", "cuenta")
                        .WithMany()
                        .HasForeignKey("CuentaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Entity.Horario", b =>
                {
                    b.HasOne("Entity.Clase", "Clase")
                        .WithMany("Horarios")
                        .HasForeignKey("ClaseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Entity.Suscripcion", b =>
                {
                    b.HasOne("Entity.Cuenta", null)
                        .WithMany("Suscripciones")
                        .HasForeignKey("CuentaId");
                });
#pragma warning restore 612, 618
        }
    }
}
