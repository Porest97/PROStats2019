using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PROStats2019.Migrations
{
    public partial class RefFeesImplemented : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RefereeFee",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SeriesId = table.Column<int>(nullable: true),
                    MatchLengthId = table.Column<int>(nullable: true),
                    FeeValue = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefereeFee", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RefereeFee_MatchLength_MatchLengthId",
                        column: x => x.MatchLengthId,
                        principalTable: "MatchLength",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RefereeFee_Series_SeriesId",
                        column: x => x.SeriesId,
                        principalTable: "Series",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RefereeFee_MatchLengthId",
                table: "RefereeFee",
                column: "MatchLengthId");

            migrationBuilder.CreateIndex(
                name: "IX_RefereeFee_SeriesId",
                table: "RefereeFee",
                column: "SeriesId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RefereeFee");
        }
    }
}
