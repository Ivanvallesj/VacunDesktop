using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VacunDesktop.Migrations
{
    public partial class TutorContrasenia : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Pacientes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.AddColumn<string>(
                name: "Contraseña",
                table: "Tutores",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Vacunas",
                keyColumn: "Id",
                keyValue: 3,
                column: "Nombre",
                value: "Neumococo Conjugada Primer Dosis");

            migrationBuilder.InsertData(
                table: "Vacunas",
                columns: new[] { "Id", "Beneficios", "Eliminado", "FechaHoraEliminacion", "Nombre", "PeriodoAplicacion", "UsuarioId" },
                values: new object[,]
                {
                    { 33, "Fiebre Amarilla", false, null, "Fiebre Amarilla FA Refuerzo", 132, null },
                    { 32, "Fiebre Amarilla", false, null, "Fiebre Amarilla FA", 18, null },
                    { 31, "SR: (Doble Viral) Sarampión, Rubeóla", false, null, "Doble Viral SR o Triple Viral SRP Iniciar o completar esquema", 180, null },
                    { 30, "dT (Doble Bacteriana) Difteria, Tetanos", false, null, "Doble Bacteriana dT ADULTOS Refuerzo c/10 años", 120, null },
                    { 29, "Virus Papiloma Humano", false, null, "Virus Papiloma Humano VPH", 132, null },
                    { 28, "DTP: (Triple Bacteriana Celular) Difteria, Tétanos, Tos Convulsa", false, null, "Triple Bacteriana Acelular dTpa", 132, null },
                    { 27, "DTP: (Triple Bacteriana Celular) Difteria, Tétanos, Tos Convulsa", false, null, "Triple Bacteriana Celular DTP", 60, null },
                    { 26, "Difteria, Tetanos, Tos Convulsa, Hep B, Haemophilus Influenzae b", false, null, "Cuadruple o Quintuple pentavalente DTP-HB-Hib Refuerzo", 15, null },
                    { 25, "Varicela", false, null, "Varicela", 15, null },
                    { 24, "SRP: (Triple Viral) Sarampión, Rubeóla, Paperas", false, null, "Triple Viral SRP Iniciar o Completar Esquema", 132, null },
                    { 23, "SRP: (Triple Viral) Sarampión, Rubeóla, Paperas", false, null, "Triple Viral SRP Segunda Dosis", 60, null },
                    { 22, "SRP: (Triple Viral) Sarampión, Rubeóla, Paperas", false, null, "Triple Viral SRP Primer Dosis", 12, null },
                    { 21, "HA Hepatitis A", false, null, "Hepatitis A HA", 12, null },
                    { 20, "Antigripal", false, null, "Gripe", 24, null },
                    { 19, "Antigripal", false, null, "Gripe", 12, null },
                    { 18, "Meningococo", false, null, "Meningococo Unica dosis", 132, null },
                    { 17, "Meningococo", false, null, "Meningococo Refuerzo dosis", 15, null },
                    { 16, "Meningococo", false, null, "Meningococo Segunda dosis", 5, null },
                    { 15, "Meningococo", false, null, "Meningococo Primer dosis", 3, null },
                    { 14, "Rotavirus", false, null, "Rotavirus Segunda dosis", 4, null },
                    { 13, "Rotavirus", false, null, "Rotavirus Primer dosis", 2, null },
                    { 12, "Poliovirus inactiva", false, null, "Polio IPV Refuerzo", 60, null },
                    { 11, "Poliovirus inactiva", false, null, "Polio IPV Tercer dosis", 6, null },
                    { 10, "Poliovirus inactiva", false, null, "Polio IPV Segunda dosis", 4, null },
                    { 9, "Poliovirus inactiva", false, null, "Polio IPV Primer dosis", 2, null },
                    { 8, "Difteria, Tetanos, Tos Convulsa, Hep B, Haemophilus Influenzae b", false, null, "Quintuple pentavalente DTP-HB-Hib Tercer Dosis", 6, null },
                    { 7, "Difteria, Tetanos, Tos Convulsa, Hep B, Haemophilus Influenzae b", false, null, "Quintuple pentavalente DTP-HB-Hib Segunda Dosis", 4, null },
                    { 6, "Difteria, Tetanos, Tos Convulsa, Hep B, Haemophilus Influenzae b", false, null, "Quintuple pentavalente DTP-HB-Hib Primer Dosis", 2, null },
                    { 5, "Previene la Meningitis,Neumonia y Sepsis por Neumococo", false, null, "Neumococo Conjugada Refuerzo", 12, null },
                    { 34, "FHA: Fiebre Hemorragica Argentina", false, null, "Fiebre Hemorrágica Argentina FHA", 180, null },
                    { 4, "Previene la Meningitis,Neumonia y Sepsis por Neumococo", false, null, "Neumococo Conjugada Segunda Dosis", 4, null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Vacunas",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Vacunas",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Vacunas",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Vacunas",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Vacunas",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Vacunas",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Vacunas",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Vacunas",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Vacunas",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Vacunas",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Vacunas",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Vacunas",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Vacunas",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Vacunas",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Vacunas",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Vacunas",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Vacunas",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Vacunas",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Vacunas",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Vacunas",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Vacunas",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Vacunas",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Vacunas",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Vacunas",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Vacunas",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Vacunas",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Vacunas",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Vacunas",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Vacunas",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Vacunas",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Vacunas",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DropColumn(
                name: "Contraseña",
                table: "Tutores");

            migrationBuilder.InsertData(
                table: "Pacientes",
                columns: new[] { "Id", "Apellido", "CalendarioId", "Dni", "Domicilio", "Eliminado", "FechaHoraEliminacion", "FechaNacimiento", "Nombre", "Peso", "Prematuro", "Sexo", "TutorId", "UsuarioId" },
                values: new object[] { 1, "Colombo", null, 36196266, "Rafael Bonin 2874", false, null, new DateTime(2016, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Juan Pablo", 3.75, false, 1, 0, null });

            migrationBuilder.UpdateData(
                table: "Vacunas",
                keyColumn: "Id",
                keyValue: 3,
                column: "Nombre",
                value: "Neumococo Conjugada");
        }
    }
}
