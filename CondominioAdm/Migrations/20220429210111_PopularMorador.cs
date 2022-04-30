using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CondominioAdm.Migrations
{
    public partial class PopularMorador : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.Sql("INSERT INTO Moradores(FamiliaId, Name, Idade)" +
              "VALUES(1, 'Valmir',65)");

            migrationBuilder.Sql("INSERT INTO Moradores(FamiliaId, Name, Idade)" +
             "VALUES(3, 'Lúcia',27)");

            migrationBuilder.Sql("INSERT INTO Moradores(FamiliaId, Name, Idade)" +
             "VALUES(2, 'Marcelo',35)");

            migrationBuilder.Sql("INSERT INTO Moradores(FamiliaId, Name, Idade)" +
             "VALUES(2, 'Irene',78)");

            migrationBuilder.Sql("INSERT INTO Moradores(FamiliaId, Name, Idade)" +
             "VALUES(5, 'Marta',31)");

            migrationBuilder.Sql("INSERT INTO Moradores(FamiliaId, Name, Idade)" +
             "VALUES(11, 'Alberto',56)");

            migrationBuilder.Sql("INSERT INTO Moradores(FamiliaId, Name, Idade)" +
             "VALUES(8, 'Lucas',10)");

            migrationBuilder.Sql("INSERT INTO Moradores(FamiliaId, Name, Idade)" +
             "VALUES(4, 'Maria',25)");

            migrationBuilder.Sql("INSERT INTO Moradores(FamiliaId, Name, Idade)" +
             "VALUES(9, 'Mateus',5)");

            migrationBuilder.Sql("INSERT INTO Moradores(FamiliaId, Name, Idade)" +
             "VALUES(10, 'Julia',9)");

            migrationBuilder.Sql("INSERT INTO Moradores(FamiliaId, Name, Idade)" +
             "VALUES(5, 'Bernardo',2)");

            migrationBuilder.Sql("INSERT INTO Moradores(FamiliaId, Name, Idade)" +
             "VALUES(7, 'Rosa',18)");

            migrationBuilder.Sql("INSERT INTO Moradores(FamiliaId, Name, Idade)" +
             "VALUES(3, 'Helena',23)");

            migrationBuilder.Sql("INSERT INTO Moradores(FamiliaId, Name, Idade)" +
             "VALUES(1, 'Willian',15)");

            migrationBuilder.Sql("INSERT INTO Moradores(FamiliaId, Name, Idade)" +
             "VALUES(1, 'José',42)");

            migrationBuilder.Sql("INSERT INTO Moradores(FamiliaId, Name, Idade)" +
             "VALUES(3, 'Priscila',13)");

            migrationBuilder.Sql("INSERT INTO Moradores(FamiliaId, Name, Idade)" +
             "VALUES(7, 'Amanda',29)");

            migrationBuilder.Sql("INSERT INTO Moradores(FamiliaId, Name, Idade)" +
             "VALUES(5, 'Guilherme',22)");

            migrationBuilder.Sql("INSERT INTO Moradores(FamiliaId, Name, Idade)" +
             "VALUES(4, 'Roberta',30)");

            migrationBuilder.Sql("INSERT INTO Moradores(FamiliaId, Name, Idade)" +
             "VALUES(4, 'Ricardo',30)");

            migrationBuilder.Sql("INSERT INTO Moradores(FamiliaId, Name, Idade)" +
             "VALUES(6, 'Giovane',81)");

            migrationBuilder.Sql("INSERT INTO Moradores(FamiliaId, Name, Idade)" +
             "VALUES(6, 'Flavia',11)");

            migrationBuilder.Sql("INSERT INTO Moradores(FamiliaId, Name, Idade)" +
             "VALUES(11, 'Fabiana',43)");

            migrationBuilder.Sql("INSERT INTO Moradores(FamiliaId, Name, Idade)" +
             "VALUES(8, 'Marcio',20)");

            migrationBuilder.Sql("INSERT INTO Moradores(FamiliaId, Name, Idade)" +
             "VALUES(7, 'Roberto',1)");

            migrationBuilder.Sql("INSERT INTO Moradores(FamiliaId, Name, Idade)" +
             "VALUES(9, 'Marcos',4)");

            migrationBuilder.Sql("INSERT INTO Moradores(FamiliaId, Name, Idade)" +
             "VALUES(4, 'Rafael',3)");

            migrationBuilder.Sql("INSERT INTO Moradores(FamiliaId, Name, Idade)" +
             "VALUES(10, 'Bruna',1)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Moradores");
        }
    }
}
