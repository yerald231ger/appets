using Microsoft.EntityFrameworkCore.Migrations;

namespace ApPets.Migrations
{
    public partial class quitarcamppEstadoIdenBD : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tblVeterinaries_tblEstados_EstadoId",
                table: "tblVeterinaries");

            migrationBuilder.DropIndex(
                name: "IX_tblVeterinaries_EstadoId",
                table: "tblVeterinaries");

            migrationBuilder.DropColumn(
                name: "EstadoId",
                table: "tblVeterinaries");

            migrationBuilder.CreateIndex(
                name: "IX_tblVeterinaries_IdEstado",
                table: "tblVeterinaries",
                column: "IdEstado");

            migrationBuilder.AddForeignKey(
                name: "FK_tblVeterinaries_tblEstados_IdEstado",
                table: "tblVeterinaries",
                column: "IdEstado",
                principalTable: "tblEstados",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tblVeterinaries_tblEstados_IdEstado",
                table: "tblVeterinaries");

            migrationBuilder.DropIndex(
                name: "IX_tblVeterinaries_IdEstado",
                table: "tblVeterinaries");

            migrationBuilder.AddColumn<int>(
                name: "EstadoId",
                table: "tblVeterinaries",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_tblVeterinaries_EstadoId",
                table: "tblVeterinaries",
                column: "EstadoId");

            migrationBuilder.AddForeignKey(
                name: "FK_tblVeterinaries_tblEstados_EstadoId",
                table: "tblVeterinaries",
                column: "EstadoId",
                principalTable: "tblEstados",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
