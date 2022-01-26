using Microsoft.EntityFrameworkCore.Migrations;

namespace MovieSite.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Films",
                columns: table => new
                {
                    FilmID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Category = table.Column<string>(nullable: false),
                    Title = table.Column<string>(nullable: false),
                    Year = table.Column<int>(nullable: false),
                    Director = table.Column<string>(nullable: false),
                    Rating = table.Column<string>(nullable: false),
                    Edited = table.Column<bool>(nullable: false),
                    LentTo = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Films", x => x.FilmID);
                });

            migrationBuilder.InsertData(
                table: "Films",
                columns: new[] { "FilmID", "Category", "Director", "Edited", "LentTo", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 1, "Family/Adventure", "George Miller", false, null, "Great Movie", "PG", "Happy Feet", 2006 });

            migrationBuilder.InsertData(
                table: "Films",
                columns: new[] { "FilmID", "Category", "Director", "Edited", "LentTo", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 2, "Action/Sci-fi", "Christopher Nolan", false, null, "Crazy Movie", "PG-13", "Inception", 2010 });

            migrationBuilder.InsertData(
                table: "Films",
                columns: new[] { "FilmID", "Category", "Director", "Edited", "LentTo", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 3, "Romance/Drama", "Marc Webb", false, null, "Funny and Sad Movie", "PG-13", "500 Days of Summer", 2009 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Films");
        }
    }
}
