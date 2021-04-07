using Microsoft.EntityFrameworkCore.Migrations;

namespace WebsiteAssignmentMain.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Movie_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Movie_Name = table.Column<string>(type: "varchar(100)", nullable: false),
                    Movie_Genre = table.Column<string>(type: "varchar(100)", nullable: false),
                    Movie_Year = table.Column<int>(type: "int", nullable: false),
                    Movie_Time = table.Column<int>(type: "int", nullable: false),
                    Movie_Imdb = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Movie_MetaScore = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Movie_Votes = table.Column<int>(type: "int", nullable: false),
                    Movie_Gross = table.Column<decimal>(type: "decimal(25,3)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Movie_Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movies");
        }
    }
}
