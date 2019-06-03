using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PROStats2019.Migrations
{
    public partial class TeamRegistrationImplemented : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tournament_RefereeLevel_TeamRegistrationId",
                table: "Tournament");

            migrationBuilder.CreateTable(
                name: "TeamRegistration",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TeamRegistrationName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeamRegistration", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Tournament_TeamRegistration_TeamRegistrationId",
                table: "Tournament",
                column: "TeamRegistrationId",
                principalTable: "TeamRegistration",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tournament_TeamRegistration_TeamRegistrationId",
                table: "Tournament");

            migrationBuilder.DropTable(
                name: "TeamRegistration");

            migrationBuilder.AddForeignKey(
                name: "FK_Tournament_RefereeLevel_TeamRegistrationId",
                table: "Tournament",
                column: "TeamRegistrationId",
                principalTable: "RefereeLevel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
