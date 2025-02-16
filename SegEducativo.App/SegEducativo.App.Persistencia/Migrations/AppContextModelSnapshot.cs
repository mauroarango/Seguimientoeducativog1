﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SegEducativo.App.Persistencia;

namespace SegEducativo.App.Persistencia.Migrations
{
    [DbContext(typeof(AppContext))]
    partial class AppContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("SegEducativo.App.Dominio.Grupo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Grupo");
                });

            modelBuilder.Entity("SegEducativo.App.Dominio.Materia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Materias");
                });

            modelBuilder.Entity("SegEducativo.App.Dominio.Persona", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Apellidos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Celular")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ciudad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Correo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Genero")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Persona");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Persona");
                });

            modelBuilder.Entity("SegEducativo.App.Dominio.Acudiente", b =>
                {
                    b.HasBaseType("SegEducativo.App.Dominio.Persona");

                    b.Property<string>("Parentesco")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Acudiente");
                });

            modelBuilder.Entity("SegEducativo.App.Dominio.DirectorGrupo", b =>
                {
                    b.HasBaseType("SegEducativo.App.Dominio.Persona");

                    b.Property<string>("Especialidad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("GrupoId")
                        .HasColumnType("int")
                        .HasColumnName("DirectorGrupo_GrupoId");

                    b.HasIndex("GrupoId");

                    b.HasDiscriminator().HasValue("DirectorGrupo");
                });

            modelBuilder.Entity("SegEducativo.App.Dominio.Estudiante", b =>
                {
                    b.HasBaseType("SegEducativo.App.Dominio.Persona");

                    b.Property<int?>("AcudienteId")
                        .HasColumnType("int");

                    b.Property<int?>("DirectorGrupoId")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<int?>("GrupoId")
                        .HasColumnType("int");

                    b.Property<int?>("MateriaId")
                        .HasColumnType("int");

                    b.HasIndex("AcudienteId");

                    b.HasIndex("DirectorGrupoId");

                    b.HasIndex("GrupoId");

                    b.HasIndex("MateriaId");

                    b.HasDiscriminator().HasValue("Estudiante");
                });

            modelBuilder.Entity("SegEducativo.App.Dominio.Profesor", b =>
                {
                    b.HasBaseType("SegEducativo.App.Dominio.Persona");

                    b.Property<int?>("EstudianteId")
                        .HasColumnType("int");

                    b.Property<int?>("GrupoId")
                        .HasColumnType("int")
                        .HasColumnName("Profesor_GrupoId");

                    b.Property<int?>("MateriaId")
                        .HasColumnType("int")
                        .HasColumnName("Profesor_MateriaId");

                    b.HasIndex("EstudianteId");

                    b.HasIndex("GrupoId");

                    b.HasIndex("MateriaId");

                    b.HasDiscriminator().HasValue("Profesor");
                });

            modelBuilder.Entity("SegEducativo.App.Dominio.DirectorGrupo", b =>
                {
                    b.HasOne("SegEducativo.App.Dominio.Grupo", "Grupo")
                        .WithMany()
                        .HasForeignKey("GrupoId");

                    b.Navigation("Grupo");
                });

            modelBuilder.Entity("SegEducativo.App.Dominio.Estudiante", b =>
                {
                    b.HasOne("SegEducativo.App.Dominio.Acudiente", "Acudiente")
                        .WithMany()
                        .HasForeignKey("AcudienteId");

                    b.HasOne("SegEducativo.App.Dominio.DirectorGrupo", "DirectorGrupo")
                        .WithMany()
                        .HasForeignKey("DirectorGrupoId");

                    b.HasOne("SegEducativo.App.Dominio.Grupo", "Grupo")
                        .WithMany()
                        .HasForeignKey("GrupoId");

                    b.HasOne("SegEducativo.App.Dominio.Materia", "Materia")
                        .WithMany()
                        .HasForeignKey("MateriaId");

                    b.Navigation("Acudiente");

                    b.Navigation("DirectorGrupo");

                    b.Navigation("Grupo");

                    b.Navigation("Materia");
                });

            modelBuilder.Entity("SegEducativo.App.Dominio.Profesor", b =>
                {
                    b.HasOne("SegEducativo.App.Dominio.Estudiante", "Estudiante")
                        .WithMany()
                        .HasForeignKey("EstudianteId");

                    b.HasOne("SegEducativo.App.Dominio.Grupo", "Grupo")
                        .WithMany()
                        .HasForeignKey("GrupoId");

                    b.HasOne("SegEducativo.App.Dominio.Materia", "Materia")
                        .WithMany()
                        .HasForeignKey("MateriaId");

                    b.Navigation("Estudiante");

                    b.Navigation("Grupo");

                    b.Navigation("Materia");
                });
#pragma warning restore 612, 618
        }
    }
}
