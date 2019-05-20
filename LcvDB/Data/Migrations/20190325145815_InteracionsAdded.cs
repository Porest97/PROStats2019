using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LcvDB.Data.Migrations
{
    public partial class InteracionsAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "InteractionType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    InteractionTypeName = table.Column<string>(nullable: true),
                    IsAdmin = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InteractionType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Interaction",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    InteractionName = table.Column<string>(nullable: true),
                    InteractionTypeId = table.Column<int>(nullable: true),
                    IsAdmin = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Interaction", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Interaction_InteractionType_InteractionTypeId",
                        column: x => x.InteractionTypeId,
                        principalTable: "InteractionType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Interaction_InteractionTypeId",
                table: "Interaction",
                column: "InteractionTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Interaction");

            migrationBuilder.DropTable(
                name: "InteractionType");
        }
    }
}
