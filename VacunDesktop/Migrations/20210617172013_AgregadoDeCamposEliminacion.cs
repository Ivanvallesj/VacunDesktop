using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VacunDesktop.Migrations
{
    public partial class AgregadoDeCamposEliminacion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(nullable: false),
                    UsuarioId = table.Column<int>(nullable: true),
                    UsuarioId1 = table.Column<int>(nullable: true),
                    FechaHoraEliminacion = table.Column<DateTime>(nullable: true),
                    Eliminado = table.Column<bool>(nullable: false),
                    User = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    TipoUsuario = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Usuarios_Usuarios_UsuarioId1",
                        column: x => x.UsuarioId1,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Calendarios",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(nullable: false),
                    UsuarioId = table.Column<int>(nullable: true),
                    FechaHoraEliminacion = table.Column<DateTime>(nullable: true),
                    Eliminado = table.Column<bool>(nullable: false),
                    SexoPaciente = table.Column<int>(nullable: false),
                    PrematuroPaciente = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Calendarios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Calendarios_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tutores",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(nullable: false),
                    UsuarioId = table.Column<int>(nullable: true),
                    FechaHoraEliminacion = table.Column<DateTime>(nullable: true),
                    Eliminado = table.Column<bool>(nullable: false),
                    Apellido = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tutores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tutores_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Vacunas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(nullable: false),
                    UsuarioId = table.Column<int>(nullable: true),
                    FechaHoraEliminacion = table.Column<DateTime>(nullable: true),
                    Eliminado = table.Column<bool>(nullable: false),
                    PeriodoAplicacion = table.Column<int>(nullable: false),
                    Beneficios = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vacunas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vacunas_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Pacientes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(nullable: false),
                    UsuarioId = table.Column<int>(nullable: true),
                    FechaHoraEliminacion = table.Column<DateTime>(nullable: true),
                    Eliminado = table.Column<bool>(nullable: false),
                    Apellido = table.Column<string>(nullable: false),
                    Dni = table.Column<int>(nullable: false),
                    FechaNacimiento = table.Column<DateTime>(nullable: false),
                    Sexo = table.Column<int>(nullable: false),
                    Prematuro = table.Column<bool>(nullable: false),
                    Peso = table.Column<double>(nullable: false),
                    Domicilio = table.Column<string>(nullable: false),
                    TutorId = table.Column<int>(nullable: false),
                    CalendarioId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pacientes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pacientes_Calendarios_CalendarioId",
                        column: x => x.CalendarioId,
                        principalTable: "Calendarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pacientes_Tutores_TutorId",
                        column: x => x.TutorId,
                        principalTable: "Tutores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pacientes_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DetalleCalendarios",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CalendarioId = table.Column<int>(nullable: false),
                    VacunaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetalleCalendarios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DetalleCalendarios_Calendarios_CalendarioId",
                        column: x => x.CalendarioId,
                        principalTable: "Calendarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DetalleCalendarios_Vacunas_VacunaId",
                        column: x => x.VacunaId,
                        principalTable: "Vacunas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VacunasColocadas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VacunaId = table.Column<int>(nullable: false),
                    PacienteId = table.Column<int>(nullable: false),
                    Fecha = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VacunasColocadas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VacunasColocadas_Pacientes_PacienteId",
                        column: x => x.PacienteId,
                        principalTable: "Pacientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VacunasColocadas_Vacunas_VacunaId",
                        column: x => x.VacunaId,
                        principalTable: "Vacunas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Calendarios_UsuarioId",
                table: "Calendarios",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleCalendarios_CalendarioId",
                table: "DetalleCalendarios",
                column: "CalendarioId");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleCalendarios_VacunaId",
                table: "DetalleCalendarios",
                column: "VacunaId");

            migrationBuilder.CreateIndex(
                name: "IX_Pacientes_CalendarioId",
                table: "Pacientes",
                column: "CalendarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Pacientes_TutorId",
                table: "Pacientes",
                column: "TutorId");

            migrationBuilder.CreateIndex(
                name: "IX_Pacientes_UsuarioId",
                table: "Pacientes",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Tutores_UsuarioId",
                table: "Tutores",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_UsuarioId1",
                table: "Usuarios",
                column: "UsuarioId1");

            migrationBuilder.CreateIndex(
                name: "IX_Vacunas_UsuarioId",
                table: "Vacunas",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_VacunasColocadas_PacienteId",
                table: "VacunasColocadas",
                column: "PacienteId");

            migrationBuilder.CreateIndex(
                name: "IX_VacunasColocadas_VacunaId",
                table: "VacunasColocadas",
                column: "VacunaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DetalleCalendarios");

            migrationBuilder.DropTable(
                name: "VacunasColocadas");

            migrationBuilder.DropTable(
                name: "Pacientes");

            migrationBuilder.DropTable(
                name: "Vacunas");

            migrationBuilder.DropTable(
                name: "Calendarios");

            migrationBuilder.DropTable(
                name: "Tutores");

            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
