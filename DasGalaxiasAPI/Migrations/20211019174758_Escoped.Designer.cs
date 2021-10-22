﻿// <auto-generated />
using DasGalaxiasAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DasGalaxiasAPI.Migrations
{
    [DbContext(typeof(CursoDbContext))]
    [Migration("20211019174758_Escoped")]
    partial class Escoped
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DasGalaxiasAPI.Models.CursoModel", b =>
                {
                    b.Property<int>("CursoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Capa")
                        .HasColumnType("nvarchar(80)");

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("DescricaoAula1")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("DescricaoAula2")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("LinkAula1")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("LinkAula2")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Professor")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Titulo")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("TituloAula1")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("TituloAula2")
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("CursoId");

                    b.ToTable("Curso");
                });
#pragma warning restore 612, 618
        }
    }
}
