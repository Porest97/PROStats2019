using Microsoft.EntityFrameworkCore.Migrations;

namespace LcvDB.Data.Migrations
{
    public partial class DocumentToIdetityUserId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PersonId",
                table: "Document");

            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "Document",
                newName: "IdentityUserId");

            migrationBuilder.AlterColumn<string>(
                name: "IdentityUserId",
                table: "Document",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Document_IdentityUserId",
                table: "Document",
                column: "IdentityUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Document_AspNetUsers_IdentityUserId",
                table: "Document",
                column: "IdentityUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Document_AspNetUsers_IdentityUserId",
                table: "Document");

            migrationBuilder.DropIndex(
                name: "IX_Document_IdentityUserId",
                table: "Document");

            migrationBuilder.RenameColumn(
                name: "IdentityUserId",
                table: "Document",
                newName: "UserName");

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "Document",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PersonId",
                table: "Document",
                nullable: true);
        }
    }
}
