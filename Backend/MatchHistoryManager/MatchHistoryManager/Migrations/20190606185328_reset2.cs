using Microsoft.EntityFrameworkCore.Migrations;

namespace MatchHistoryManager.Migrations
{
    public partial class reset2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Heroes_Rolez_RoleId",
                table: "Heroes");

            migrationBuilder.DropIndex(
                name: "IX_Heroes_RoleId",
                table: "Heroes");

            migrationBuilder.RenameColumn(
                name: "RoleId",
                table: "Heroes",
                newName: "Role");

            migrationBuilder.AlterColumn<string>(
                name: "Role",
                table: "Heroes",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Role",
                table: "Heroes",
                newName: "RoleId");

            migrationBuilder.AlterColumn<string>(
                name: "RoleId",
                table: "Heroes",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Heroes_RoleId",
                table: "Heroes",
                column: "RoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Heroes_Rolez_RoleId",
                table: "Heroes",
                column: "RoleId",
                principalTable: "Rolez",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
