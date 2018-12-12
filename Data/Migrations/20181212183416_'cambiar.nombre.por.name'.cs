using Microsoft.EntityFrameworkCore.Migrations;

namespace ApPets.Migrations
{
    public partial class cambiarnombreporname : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Nombre",
                table: "tblVetServices",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "Nombre",
                table: "tblVeterinaries",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "Nombre",
                table: "tblPetTypes",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "Nombre",
                table: "tblPets",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "Nombre",
                table: "tblPaises",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "Nombre",
                table: "tblEstados",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "Nombre",
                table: "tblCiudades",
                newName: "Name");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "tblVetServices",
                newName: "Nombre");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "tblVeterinaries",
                newName: "Nombre");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "tblPetTypes",
                newName: "Nombre");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "tblPets",
                newName: "Nombre");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "tblPaises",
                newName: "Nombre");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "tblEstados",
                newName: "Nombre");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "tblCiudades",
                newName: "Nombre");
        }
    }
}
