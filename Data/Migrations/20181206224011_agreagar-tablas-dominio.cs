using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ApPets.Migrations
{
    public partial class agreagartablasdominio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdEstado",
                table: "tblUser",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "tblPaises",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(nullable: true),
                    UpDate = table.Column<DateTime>(nullable: false),
                    ModDate = table.Column<DateTime>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    PaisISO = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblPaises", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tblPetTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(nullable: true),
                    UpDate = table.Column<DateTime>(nullable: false),
                    ModDate = table.Column<DateTime>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblPetTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tblEstados",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(nullable: true),
                    UpDate = table.Column<DateTime>(nullable: false),
                    ModDate = table.Column<DateTime>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    IdPais = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblEstados", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tblEstados_tblPaises_IdPais",
                        column: x => x.IdPais,
                        principalTable: "tblPaises",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblPets",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(nullable: true),
                    UpDate = table.Column<DateTime>(nullable: false),
                    ModDate = table.Column<DateTime>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    Race = table.Column<string>(nullable: true),
                    Wight = table.Column<int>(nullable: false),
                    Birthdate = table.Column<DateTime>(nullable: false),
                    ImageProfileId = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: true),
                    PetTypeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblPets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tblPets_tblPetTypes_PetTypeId",
                        column: x => x.PetTypeId,
                        principalTable: "tblPetTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblPets_tblUser_UserId",
                        column: x => x.UserId,
                        principalTable: "tblUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tblCiudades",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(nullable: true),
                    UpDate = table.Column<DateTime>(nullable: false),
                    ModDate = table.Column<DateTime>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    IdEstado = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblCiudades", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tblCiudades_tblEstados_IdEstado",
                        column: x => x.IdEstado,
                        principalTable: "tblEstados",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblVeterinaries",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(nullable: true),
                    UpDate = table.Column<DateTime>(nullable: false),
                    ModDate = table.Column<DateTime>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    CP = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Latitud = table.Column<float>(nullable: false),
                    Longitud = table.Column<float>(nullable: false),
                    ImageProfileId = table.Column<string>(nullable: true),
                    IdEstado = table.Column<int>(nullable: false),
                    EstadoId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblVeterinaries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tblVeterinaries_tblEstados_EstadoId",
                        column: x => x.EstadoId,
                        principalTable: "tblEstados",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tblVetServices",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(nullable: true),
                    UpDate = table.Column<DateTime>(nullable: false),
                    ModDate = table.Column<DateTime>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Price = table.Column<float>(nullable: false),
                    ShowPrice = table.Column<bool>(nullable: false),
                    IdVeterinary = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblVetServices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tblVetServices_tblVeterinaries_IdVeterinary",
                        column: x => x.IdVeterinary,
                        principalTable: "tblVeterinaries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tblUser_IdEstado",
                table: "tblUser",
                column: "IdEstado");

            migrationBuilder.CreateIndex(
                name: "IX_tblCiudades_IdEstado",
                table: "tblCiudades",
                column: "IdEstado");

            migrationBuilder.CreateIndex(
                name: "IX_tblEstados_IdPais",
                table: "tblEstados",
                column: "IdPais");

            migrationBuilder.CreateIndex(
                name: "IX_tblPets_PetTypeId",
                table: "tblPets",
                column: "PetTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_tblPets_UserId",
                table: "tblPets",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_tblVeterinaries_EstadoId",
                table: "tblVeterinaries",
                column: "EstadoId");

            migrationBuilder.CreateIndex(
                name: "IX_tblVetServices_IdVeterinary",
                table: "tblVetServices",
                column: "IdVeterinary");

            migrationBuilder.AddForeignKey(
                name: "FK_tblUser_tblEstados_IdEstado",
                table: "tblUser",
                column: "IdEstado",
                principalTable: "tblEstados",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tblUser_tblEstados_IdEstado",
                table: "tblUser");

            migrationBuilder.DropTable(
                name: "tblCiudades");

            migrationBuilder.DropTable(
                name: "tblPets");

            migrationBuilder.DropTable(
                name: "tblVetServices");

            migrationBuilder.DropTable(
                name: "tblPetTypes");

            migrationBuilder.DropTable(
                name: "tblVeterinaries");

            migrationBuilder.DropTable(
                name: "tblEstados");

            migrationBuilder.DropTable(
                name: "tblPaises");

            migrationBuilder.DropIndex(
                name: "IX_tblUser_IdEstado",
                table: "tblUser");

            migrationBuilder.DropColumn(
                name: "IdEstado",
                table: "tblUser");
        }
    }
}
