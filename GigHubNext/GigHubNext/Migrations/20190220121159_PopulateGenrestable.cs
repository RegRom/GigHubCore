using Microsoft.EntityFrameworkCore.Migrations;

namespace GigHubNext.Migrations
{
    public partial class PopulateGenrestable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData("Genres", new[] { "Id", "Name" }, new object[] { "1", "Heavy Metal" });
            migrationBuilder.InsertData("Genres", new[] { "Id", "Name" }, new object[] { "2", "Jazz" });
            migrationBuilder.InsertData("Genres", new[] { "Id", "Name" }, new object[] { "3", "Synthwave" });
            migrationBuilder.InsertData("Genres", new[] { "Id", "Name" }, new object[] { "4", "Darksynth" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM [Genres]", true);
        }
    }
}
