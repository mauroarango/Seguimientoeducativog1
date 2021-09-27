using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SegEducativo.App.Persistencia.Migrations
{
    public partial class Entidades : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Grupo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grupo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Materias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Materias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Persona",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Apellidos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ciudad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Correo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Celular = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Genero = table.Column<int>(type: "int", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Parentesco = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Especialidad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DirectorGrupo_GrupoId = table.Column<int>(type: "int", nullable: true),
                    GrupoId = table.Column<int>(type: "int", nullable: true),
                    MateriaId = table.Column<int>(type: "int", nullable: true),
                    FechaNacimiento = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AcudienteId = table.Column<int>(type: "int", nullable: true),
                    DirectorGrupoId = table.Column<int>(type: "int", nullable: true),
                    Profesor_GrupoId = table.Column<int>(type: "int", nullable: true),
                    Profesor_MateriaId = table.Column<int>(type: "int", nullable: true),
                    EstudianteId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persona", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Persona_Grupo_DirectorGrupo_GrupoId",
                        column: x => x.DirectorGrupo_GrupoId,
                        principalTable: "Grupo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Persona_Grupo_GrupoId",
                        column: x => x.GrupoId,
                        principalTable: "Grupo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Persona_Grupo_Profesor_GrupoId",
                        column: x => x.Profesor_GrupoId,
                        principalTable: "Grupo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Persona_Materias_MateriaId",
                        column: x => x.MateriaId,
                        principalTable: "Materias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Persona_Materias_Profesor_MateriaId",
                        column: x => x.Profesor_MateriaId,
                        principalTable: "Materias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Persona_Persona_AcudienteId",
                        column: x => x.AcudienteId,
                        principalTable: "Persona",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Persona_Persona_DirectorGrupoId",
                        column: x => x.DirectorGrupoId,
                        principalTable: "Persona",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Persona_Persona_EstudianteId",
                        column: x => x.EstudianteId,
                        principalTable: "Persona",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Persona_AcudienteId",
                table: "Persona",
                column: "AcudienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Persona_DirectorGrupo_GrupoId",
                table: "Persona",
                column: "DirectorGrupo_GrupoId");

            migrationBuilder.CreateIndex(
                name: "IX_Persona_DirectorGrupoId",
                table: "Persona",
                column: "DirectorGrupoId");

            migrationBuilder.CreateIndex(
                name: "IX_Persona_EstudianteId",
                table: "Persona",
                column: "EstudianteId");

            migrationBuilder.CreateIndex(
                name: "IX_Persona_GrupoId",
                table: "Persona",
                column: "GrupoId");

            migrationBuilder.CreateIndex(
                name: "IX_Persona_MateriaId",
                table: "Persona",
                column: "MateriaId");

            migrationBuilder.CreateIndex(
                name: "IX_Persona_Profesor_GrupoId",
                table: "Persona",
                column: "Profesor_GrupoId");

            migrationBuilder.CreateIndex(
                name: "IX_Persona_Profesor_MateriaId",
                table: "Persona",
                column: "Profesor_MateriaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Persona");

            migrationBuilder.DropTable(
                name: "Grupo");

            migrationBuilder.DropTable(
                name: "Materias");
        }
    }
}
