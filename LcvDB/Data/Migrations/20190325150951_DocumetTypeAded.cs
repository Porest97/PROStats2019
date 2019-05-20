using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LcvDB.Data.Migrations
{
    public partial class DocumetTypeAded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DocumentTypeId",
                table: "Document",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "DocumentType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DocumentTypeName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocumentType", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Document_DocumentTypeId",
                table: "Document",
                column: "DocumentTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Document_DocumentType_DocumentTypeId",
                table: "Document",
                column: "DocumentTypeId",
                principalTable: "DocumentType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Document_DocumentType_DocumentTypeId",
                table: "Document");

            migrationBuilder.DropTable(
                name: "DocumentType");

            migrationBuilder.DropIndex(
                name: "IX_Document_DocumentTypeId",
                table: "Document");

            migrationBuilder.DropColumn(
                name: "DocumentTypeId",
                table: "Document");
        }
    }
}
