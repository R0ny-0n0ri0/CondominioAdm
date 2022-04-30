using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CondominioAdm.Migrations
{
    public partial class PopularCondominio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.Sql("INSERT INTO Condominios(Name, Bairro)" +
                "VALUES('Serra Negra','Vila Nova')");

            migrationBuilder.Sql("INSERT INTO Condominios(Name, Bairro)" +
                "VALUES('Casa Branca','Moema')");

            migrationBuilder.Sql("INSERT INTO Condominios(Name, Bairro)" +
               "VALUES('Bom Recanto','Vila Guarani')");

            migrationBuilder.Sql("INSERT INTO Condominios(Name, Bairro)" +
               "VALUES('Imaré','Capuava')");

            migrationBuilder.Sql("INSERT INTO Condominios(Name, Bairro)" +
               "VALUES('Andorinha','Jardim América')");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Condominios");
        }
    }
}
