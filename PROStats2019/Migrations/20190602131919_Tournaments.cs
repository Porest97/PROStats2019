using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PROStats2019.Migrations
{
    public partial class Tournaments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MatchLength",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MatchLengthName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MatchLength", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MatchReporting",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MatchReportingName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MatchReporting", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MatchTime",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MatchTimeName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MatchTime", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RefereeLevel",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RefereeLevelName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefereeLevel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TableSystem",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TableSystemName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TableSystem", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TeamNotification",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TeamNotificationName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeamNotification", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TeamOfficial",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TeamOfficialName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeamOfficial", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TeamRegister",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TeamRegisterName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeamRegister", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TournamentPhase",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TournamentPhaseName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TournamentPhase", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tournament",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RefereeDistrictId = table.Column<int>(nullable: true),
                    TournamentName = table.Column<string>(nullable: true),
                    TournamentPhaseId = table.Column<int>(nullable: true),
                    SeriesNumber = table.Column<int>(nullable: true),
                    SeriesId = table.Column<int>(nullable: true),
                    Serienamn = table.Column<int>(nullable: true),
                    MatchLengthId = table.Column<int>(nullable: true),
                    MatchReportingId = table.Column<int>(nullable: true),
                    TableSystemId = table.Column<int>(nullable: true),
                    RefereeLevelId = table.Column<int>(nullable: true),
                    TeamNotificationId = table.Column<int>(nullable: true),
                    TeamRegistrationId = table.Column<int>(nullable: true),
                    TeamOfficialId = table.Column<int>(nullable: true),
                    MatchTimeId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tournament", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tournament_MatchLength_MatchLengthId",
                        column: x => x.MatchLengthId,
                        principalTable: "MatchLength",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tournament_MatchReporting_MatchReportingId",
                        column: x => x.MatchReportingId,
                        principalTable: "MatchReporting",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tournament_MatchTime_MatchTimeId",
                        column: x => x.MatchTimeId,
                        principalTable: "MatchTime",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tournament_RefereeDistrict_RefereeDistrictId",
                        column: x => x.RefereeDistrictId,
                        principalTable: "RefereeDistrict",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tournament_RefereeLevel_RefereeLevelId",
                        column: x => x.RefereeLevelId,
                        principalTable: "RefereeLevel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tournament_Series_Serienamn",
                        column: x => x.Serienamn,
                        principalTable: "Series",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tournament_TableSystem_TableSystemId",
                        column: x => x.TableSystemId,
                        principalTable: "TableSystem",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tournament_TeamNotification_TeamNotificationId",
                        column: x => x.TeamNotificationId,
                        principalTable: "TeamNotification",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tournament_TeamOfficial_TeamOfficialId",
                        column: x => x.TeamOfficialId,
                        principalTable: "TeamOfficial",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tournament_RefereeLevel_TeamRegistrationId",
                        column: x => x.TeamRegistrationId,
                        principalTable: "RefereeLevel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tournament_TournamentPhase_TournamentPhaseId",
                        column: x => x.TournamentPhaseId,
                        principalTable: "TournamentPhase",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tournament_MatchLengthId",
                table: "Tournament",
                column: "MatchLengthId");

            migrationBuilder.CreateIndex(
                name: "IX_Tournament_MatchReportingId",
                table: "Tournament",
                column: "MatchReportingId");

            migrationBuilder.CreateIndex(
                name: "IX_Tournament_MatchTimeId",
                table: "Tournament",
                column: "MatchTimeId");

            migrationBuilder.CreateIndex(
                name: "IX_Tournament_RefereeDistrictId",
                table: "Tournament",
                column: "RefereeDistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_Tournament_RefereeLevelId",
                table: "Tournament",
                column: "RefereeLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_Tournament_Serienamn",
                table: "Tournament",
                column: "Serienamn");

            migrationBuilder.CreateIndex(
                name: "IX_Tournament_TableSystemId",
                table: "Tournament",
                column: "TableSystemId");

            migrationBuilder.CreateIndex(
                name: "IX_Tournament_TeamNotificationId",
                table: "Tournament",
                column: "TeamNotificationId");

            migrationBuilder.CreateIndex(
                name: "IX_Tournament_TeamOfficialId",
                table: "Tournament",
                column: "TeamOfficialId");

            migrationBuilder.CreateIndex(
                name: "IX_Tournament_TeamRegistrationId",
                table: "Tournament",
                column: "TeamRegistrationId");

            migrationBuilder.CreateIndex(
                name: "IX_Tournament_TournamentPhaseId",
                table: "Tournament",
                column: "TournamentPhaseId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TeamRegister");

            migrationBuilder.DropTable(
                name: "Tournament");

            migrationBuilder.DropTable(
                name: "MatchLength");

            migrationBuilder.DropTable(
                name: "MatchReporting");

            migrationBuilder.DropTable(
                name: "MatchTime");

            migrationBuilder.DropTable(
                name: "RefereeLevel");

            migrationBuilder.DropTable(
                name: "TableSystem");

            migrationBuilder.DropTable(
                name: "TeamNotification");

            migrationBuilder.DropTable(
                name: "TeamOfficial");

            migrationBuilder.DropTable(
                name: "TournamentPhase");
        }
    }
}
