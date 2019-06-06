using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MatchHistoryManager.Migrations
{
    public partial class Second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Heroes_Teams_TeamId",
                table: "Heroes");

            migrationBuilder.DropTable(
                name: "Rewards");

            migrationBuilder.DropTable(
                name: "Matches");

            migrationBuilder.DropTable(
                name: "Teams");

            migrationBuilder.DropIndex(
                name: "IX_Heroes_TeamId",
                table: "Heroes");

            migrationBuilder.DropColumn(
                name: "Me",
                table: "Heroes");

            migrationBuilder.DropColumn(
                name: "Role",
                table: "Heroes");

            migrationBuilder.DropColumn(
                name: "TeamId",
                table: "Heroes");

            migrationBuilder.AddColumn<string>(
                name: "RoleId",
                table: "Heroes",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "asdId",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Heroes_RoleId",
                table: "Heroes",
                column: "RoleId");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Heroes_asdId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Heroes_Role_RoleId",
                table: "Heroes");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropIndex(
                name: "IX_Heroes_RoleId",
                table: "Heroes");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_asdId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "RoleId",
                table: "Heroes");

            migrationBuilder.DropColumn(
                name: "asdId",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<bool>(
                name: "Me",
                table: "Heroes",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "Role",
                table: "Heroes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TeamId",
                table: "Heroes",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Matches",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ApplicationUserId = table.Column<string>(nullable: true),
                    EnemyTeamId = table.Column<int>(nullable: true),
                    MatchDateTime = table.Column<DateTime>(nullable: false),
                    MyTeamId = table.Column<int>(nullable: true),
                    Result = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Matches", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Matches_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Matches_Teams_EnemyTeamId",
                        column: x => x.EnemyTeamId,
                        principalTable: "Teams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Matches_Teams_MyTeamId",
                        column: x => x.MyTeamId,
                        principalTable: "Teams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Rewards",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Category = table.Column<int>(nullable: false),
                    MatchId = table.Column<int>(nullable: true),
                    Medal = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rewards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rewards_Matches_MatchId",
                        column: x => x.MatchId,
                        principalTable: "Matches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Heroes_TeamId",
                table: "Heroes",
                column: "TeamId");

            migrationBuilder.CreateIndex(
                name: "IX_Matches_ApplicationUserId",
                table: "Matches",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Matches_EnemyTeamId",
                table: "Matches",
                column: "EnemyTeamId");

            migrationBuilder.CreateIndex(
                name: "IX_Matches_MyTeamId",
                table: "Matches",
                column: "MyTeamId");

            migrationBuilder.CreateIndex(
                name: "IX_Rewards_MatchId",
                table: "Rewards",
                column: "MatchId");

            migrationBuilder.AddForeignKey(
                name: "FK_Heroes_Teams_TeamId",
                table: "Heroes",
                column: "TeamId",
                principalTable: "Teams",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
