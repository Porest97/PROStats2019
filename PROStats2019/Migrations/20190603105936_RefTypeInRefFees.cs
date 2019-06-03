using Microsoft.EntityFrameworkCore.Migrations;

namespace PROStats2019.Migrations
{
    public partial class RefTypeInRefFees : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RefereeTypeId",
                table: "RefereeFee",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_RefereeFee_RefereeTypeId",
                table: "RefereeFee",
                column: "RefereeTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_RefereeFee_RefereeType_RefereeTypeId",
                table: "RefereeFee",
                column: "RefereeTypeId",
                principalTable: "RefereeType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RefereeFee_RefereeType_RefereeTypeId",
                table: "RefereeFee");

            migrationBuilder.DropIndex(
                name: "IX_RefereeFee_RefereeTypeId",
                table: "RefereeFee");

            migrationBuilder.DropColumn(
                name: "RefereeTypeId",
                table: "RefereeFee");
        }
    }
}
