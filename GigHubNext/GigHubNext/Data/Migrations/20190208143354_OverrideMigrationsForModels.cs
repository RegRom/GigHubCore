using Microsoft.EntityFrameworkCore.Migrations;

namespace GigHubNext.Data.Migrations
{
    public partial class OverrideMigrationsForModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Gigs_GigUser_ArtistId",
                table: "Gigs");

            migrationBuilder.DropForeignKey(
                name: "FK_Gigs_Genres_GenreId",
                table: "Gigs");

            migrationBuilder.AlterColumn<string>(
                name: "Username",
                table: "GigUser",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Venue",
                table: "Gigs",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<byte>(
                name: "GenreId",
                table: "Gigs",
                nullable: false,
                oldClrType: typeof(byte),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ArtistId",
                table: "Gigs",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Genres",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Gigs_GigUser_ArtistId",
                table: "Gigs",
                column: "ArtistId",
                principalTable: "GigUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Gigs_Genres_GenreId",
                table: "Gigs",
                column: "GenreId",
                principalTable: "Genres",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Gigs_GigUser_ArtistId",
                table: "Gigs");

            migrationBuilder.DropForeignKey(
                name: "FK_Gigs_Genres_GenreId",
                table: "Gigs");

            migrationBuilder.AlterColumn<string>(
                name: "Username",
                table: "GigUser",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Venue",
                table: "Gigs",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<byte>(
                name: "GenreId",
                table: "Gigs",
                nullable: true,
                oldClrType: typeof(byte));

            migrationBuilder.AlterColumn<int>(
                name: "ArtistId",
                table: "Gigs",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Genres",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 255);

            migrationBuilder.AddForeignKey(
                name: "FK_Gigs_GigUser_ArtistId",
                table: "Gigs",
                column: "ArtistId",
                principalTable: "GigUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Gigs_Genres_GenreId",
                table: "Gigs",
                column: "GenreId",
                principalTable: "Genres",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
