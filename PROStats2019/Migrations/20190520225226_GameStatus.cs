using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PROStats2019.Migrations
{
    public partial class GameStatus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GameStatusId",
                table: "ProGame",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "GameStatus",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    GameStatusName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GameStatus", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProGame_GameStatusId",
                table: "ProGame",
                column: "GameStatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProGame_GameStatus_GameStatusId",
                table: "ProGame",
                column: "GameStatusId",
                principalTable: "GameStatus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProGame_GameStatus_GameStatusId",
                table: "ProGame");

            migrationBuilder.DropTable(
                name: "GameStatus");

            migrationBuilder.DropIndex(
                name: "IX_ProGame_GameStatusId",
                table: "ProGame");

            migrationBuilder.DropColumn(
                name: "GameStatusId",
                table: "ProGame");
        }
    }
}
