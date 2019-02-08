using Microsoft.EntityFrameworkCore.Migrations;

namespace GigHubNext.Data.Migrations
{
    public partial class PopulateGenresTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData("Genres", new[] {"Id", "Name"}, new object[] {1, "Jazz"});
            migrationBuilder.InsertData("Genres", new[] { "Id", "Name" }, new object[] { 2, "Heavy Metal" });
            migrationBuilder.InsertData("Genres", new[] { "Id", "Name" }, new object[] { 3, "Synthwave" });
            migrationBuilder.InsertData("Genres", new[] { "Id", "Name" }, new object[] { 4, "Jodeling" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData("Genres", "Id", 1);
            migrationBuilder.DeleteData("Genres", "Id", 1);
            migrationBuilder.DeleteData("Genres", "Id", 1);
            migrationBuilder.DeleteData("Genres", "Id", 1);
        }
    }
}
