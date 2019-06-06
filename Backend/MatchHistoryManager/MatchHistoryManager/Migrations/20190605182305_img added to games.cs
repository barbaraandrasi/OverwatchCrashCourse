using Microsoft.EntityFrameworkCore.Migrations;

namespace MatchHistoryManager.Migrations
{
    public partial class imgaddedtogames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Games",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "GameModes",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "GameModes");
        }
    }
}
