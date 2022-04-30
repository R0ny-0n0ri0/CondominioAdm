using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CondominioAdm.Migrations
{
    public partial class AreaIptuMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "AreaApto",
                table: "Familias",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "IPTUApto",
                table: "Familias",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "AreaTotal",
                table: "Condominios",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "IPTU",
                table: "Condominios",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AreaApto",
                table: "Familias");

            migrationBuilder.DropColumn(
                name: "IPTUApto",
                table: "Familias");

            migrationBuilder.DropColumn(
                name: "AreaTotal",
                table: "Condominios");

            migrationBuilder.DropColumn(
                name: "IPTU",
                table: "Condominios");
        }
    }
}
