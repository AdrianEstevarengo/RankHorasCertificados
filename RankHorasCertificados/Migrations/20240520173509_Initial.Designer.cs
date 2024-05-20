﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RankHorasCertificados.Data;

#nullable disable

namespace RankHorasCertificados.Migrations
{
    [DbContext(typeof(RankHorasCertificadosContext))]
    [Migration("20240520173509_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.29")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("RankHorasCertificados.Models.Curso", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Duracao")
                        .HasColumnType("int");

                    b.Property<bool>("Externo")
                        .HasColumnType("bit");

                    b.Property<bool>("Interno")
                        .HasColumnType("bit");

                    b.HasKey("Name");

                    b.ToTable("Curso");
                });

            modelBuilder.Entity("RankHorasCertificados.Models.UsuarioModel", b =>
                {
                    b.Property<int>("Matricula")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Matricula"), 1L, 1);

                    b.Property<string>("Curso")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("Setor")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.HasKey("Matricula");

                    b.ToTable("Usuario");
                });
#pragma warning restore 612, 618
        }
    }
}
