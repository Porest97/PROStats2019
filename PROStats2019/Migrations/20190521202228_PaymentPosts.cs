using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PROStats2019.Migrations
{
    public partial class PaymentPosts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PaymentPost",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    GameId = table.Column<int>(nullable: true),
                    PersonId = table.Column<int>(nullable: true),
                    PersonId1 = table.Column<int>(nullable: true),
                    PersonId2 = table.Column<int>(nullable: true),
                    PersonId3 = table.Column<int>(nullable: true),
                    FeeHD1 = table.Column<double>(nullable: true),
                    AlowenceHD1 = table.Column<double>(nullable: true),
                    TravelDistanceHD1 = table.Column<double>(nullable: true),
                    TravelCostHD1 = table.Column<double>(nullable: true),
                    LateMatchStartHD1 = table.Column<double>(nullable: true),
                    TotalPaymentHD1 = table.Column<double>(nullable: true),
                    FeeHD2 = table.Column<double>(nullable: true),
                    AlowenceHD2 = table.Column<double>(nullable: true),
                    TravelDistanceHD2 = table.Column<double>(nullable: true),
                    TravelCostHD2 = table.Column<double>(nullable: true),
                    LateMatchStartHD2 = table.Column<double>(nullable: true),
                    TotalPaymentHD2 = table.Column<double>(nullable: true),
                    FeeLD1 = table.Column<double>(nullable: true),
                    AlowenceLD1 = table.Column<double>(nullable: true),
                    TravelDistanceLD1 = table.Column<double>(nullable: true),
                    TravelCostLD1 = table.Column<double>(nullable: true),
                    LateMatchStartLD1 = table.Column<double>(nullable: true),
                    TotalPaymentLD1 = table.Column<double>(nullable: true),
                    FeeLD2 = table.Column<double>(nullable: true),
                    AlowenceLD2 = table.Column<double>(nullable: true),
                    TravelDistanceLD2 = table.Column<double>(nullable: true),
                    TravelCostLD2 = table.Column<double>(nullable: true),
                    LateMatchStartLD2 = table.Column<double>(nullable: true),
                    TotalPaymentLD2 = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentPost", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PaymentPost_Game_GameId",
                        column: x => x.GameId,
                        principalTable: "Game",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PaymentPost_Person_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PaymentPost_Person_PersonId1",
                        column: x => x.PersonId1,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PaymentPost_Person_PersonId2",
                        column: x => x.PersonId2,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PaymentPost_Person_PersonId3",
                        column: x => x.PersonId3,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PaymentPost_GameId",
                table: "PaymentPost",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentPost_PersonId",
                table: "PaymentPost",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentPost_PersonId1",
                table: "PaymentPost",
                column: "PersonId1");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentPost_PersonId2",
                table: "PaymentPost",
                column: "PersonId2");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentPost_PersonId3",
                table: "PaymentPost",
                column: "PersonId3");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PaymentPost");
        }
    }
}
