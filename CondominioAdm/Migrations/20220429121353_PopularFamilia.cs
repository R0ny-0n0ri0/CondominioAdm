using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CondominioAdm.Migrations
{
    public partial class PopularFamilia : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Familias(CondominioId, Name, Apto)" +
                "VALUES(2,'Silva',10)");

            migrationBuilder.Sql("INSERT INTO Familias(CondominioId, Name, Apto)" +
              "VALUES(2,'Novaes',45)");

            migrationBuilder.Sql("INSERT INTO Familias(CondominioId, Name, Apto)" +
              "VALUES(4, 'Nobrega',110)");

            migrationBuilder.Sql("INSERT INTO Familias(CondominioId, Name, Apto)" +
              "VALUES(1, 'Campineli',712)");

            migrationBuilder.Sql("INSERT INTO Familias(CondominioId, Name, Apto)" +
              "VALUES(1, 'Souza',715)");

            migrationBuilder.Sql("INSERT INTO Familias(CondominioId, Name, Apto)" +
              "VALUES(3, 'Gonçalvez',640)");

            migrationBuilder.Sql("INSERT INTO Familias(CondominioId, Name, Apto)" +
              "VALUES(3,'Camargo',301)");

            migrationBuilder.Sql("INSERT INTO Familias(CondominioId, Name, Apto)" +
              "VALUES(5, 'Brito',507)");

            migrationBuilder.Sql("INSERT INTO Familias(CondominioId, Name, Apto)" +
              "VALUES(3, 'Oliveira',530)");

            migrationBuilder.Sql("INSERT INTO Familias(CondominioId, Name, Apto)" +
              "VALUES(4, 'Jovaneli',507)");

            migrationBuilder.Sql("INSERT INTO Familias(CondominioId, Name, Apto)" +
              "VALUES(5, 'Vieira',310)");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Familias");
        }
    }
}
