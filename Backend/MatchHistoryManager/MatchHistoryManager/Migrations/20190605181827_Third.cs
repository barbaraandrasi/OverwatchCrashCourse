using Microsoft.EntityFrameworkCore.Migrations;

namespace MatchHistoryManager.Migrations
{
    public partial class Third : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Heroes_asdId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Heroes_Role_RoleId",
                table: "Heroes");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_asdId",
                table: "AspNetUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Role",
                table: "Role");

            migrationBuilder.DropColumn(
                name: "asdId",
                table: "AspNetUsers");

            migrationBuilder.RenameTable(
                name: "Role",
                newName: "Rolez");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Rolez",
                table: "Rolez",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GameModes",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    GameId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GameModes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GameModes_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GameModes_GameId",
                table: "GameModes",
                column: "GameId");

            migrationBuilder.AddForeignKey(
                name: "FK_Heroes_Rolez_RoleId",
                table: "Heroes",
                column: "RoleId",
                principalTable: "Rolez",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Heroes_Rolez_RoleId",
                table: "Heroes");

            migrationBuilder.DropTable(
                name: "GameModes");

            migrationBuilder.DropTable(
                name: "Games");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Rolez",
                table: "Rolez");

            migrationBuilder.RenameTable(
                name: "Rolez",
                newName: "Role");

            migrationBuilder.AddColumn<int>(
                name: "asdId",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Role",
                table: "Role",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_asdId",
                table: "AspNetUsers",
                column: "asdId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Heroes_asdId",
                table: "AspNetUsers",
                column: "asdId",
                principalTable: "Heroes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Heroes_Role_RoleId",
                table: "Heroes",
                column: "RoleId",
                principalTable: "Role",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
