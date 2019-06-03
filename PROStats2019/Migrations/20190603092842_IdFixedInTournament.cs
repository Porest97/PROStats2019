using Microsoft.EntityFrameworkCore.Migrations;

namespace PROStats2019.Migrations
{
    public partial class IdFixedInTournament : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tournament_Series_Serienamn",
                table: "Tournament");

            migrationBuilder.DropIndex(
                name: "IX_Tournament_Serienamn",
                table: "Tournament");

            migrationBuilder.DropColumn(
                name: "Serienamn",
                table: "Tournament");

            migrationBuilder.CreateIndex(
                name: "IX_Tournament_SeriesId",
                table: "Tournament",
                column: "SeriesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tournament_Series_SeriesId",
                table: "Tournament",
                column: "SeriesId",
                principalTable: "Series",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tournament_Series_SeriesId",
                table: "Tournament");

            migrationBuilder.DropIndex(
                name: "IX_Tournament_SeriesId",
                table: "Tournament");

            migrationBuilder.AddColumn<int>(
                name: "Serienamn",
                table: "Tournament",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tournament_Serienamn",
                table: "Tournament",
                column: "Serienamn");

            migrationBuilder.AddForeignKey(
                name: "FK_Tournament_Series_Serienamn",
                table: "Tournament",
                column: "Serienamn",
                principalTable: "Series",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
