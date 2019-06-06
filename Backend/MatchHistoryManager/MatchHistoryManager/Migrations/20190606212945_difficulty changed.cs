using Microsoft.EntityFrameworkCore.Migrations;

namespace MatchHistoryManager.Migrations
{
    public partial class difficultychanged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Difficulty",
                table: "Heroes",
                nullable: true,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Difficulty",
                table: "Heroes",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
