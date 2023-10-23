using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AppCC2023.Migrations
{
    public partial class M01AddTableCliente : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeUsuario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Senha = table.Column<int>(type: "int", nullable: false),
                    Pin = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NomeDispositivo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Processador = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GHz = table.Column<int>(type: "int", nullable: false),
                    Memoria = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HardDisk = table.Column<int>(type: "int", nullable: false),
                    SistemaOpoeracional = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Office = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MarcaModelo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumeroSerie = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clientes");
        }
    }
}
