using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PROStats2019.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Arena",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ArenaName = table.Column<string>(nullable: true),
                    ArenaStreetAddress = table.Column<string>(nullable: true),
                    ArenaZipCode = table.Column<string>(nullable: true),
                    ArenaCounty = table.Column<string>(nullable: true),
                    ArenaCountry = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Arena", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Club",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ClubName = table.Column<string>(nullable: true),
                    StreetAddress = table.Column<string>(nullable: true),
                    ZipCode = table.Column<string>(nullable: true),
                    County = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Club", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Coach",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Status = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coach", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Player",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Status = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Player", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Referee",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Status = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Referee", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RefereeCategory",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RefereeCategoryName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefereeCategory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RefereeCategoryType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RefereeCategoryTypeName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefereeCategoryType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RefereeDistrict",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RefereeDistrictName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefereeDistrict", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RefereeType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RefereeTypeName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefereeType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Series",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SeriesName = table.Column<string>(nullable: true),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Series", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Staff",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Status = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staff", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Person",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    StreetAddress = table.Column<string>(nullable: true),
                    ZipCode = table.Column<string>(nullable: true),
                    County = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    Ssn = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    ClubId = table.Column<int>(nullable: true),
                    RefereeNumber = table.Column<int>(nullable: true),
                    RefereeTypeId = table.Column<int>(nullable: true),
                    RefereeCategoryId = table.Column<int>(nullable: true),
                    RefereeCategoryTypeId = table.Column<int>(nullable: true),
                    RefereeDistrictId = table.Column<int>(nullable: true),
                    RefereeId = table.Column<int>(nullable: true),
                    CoachId = table.Column<int>(nullable: true),
                    PlayerId = table.Column<int>(nullable: true),
                    StaffId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Person_Club_ClubId",
                        column: x => x.ClubId,
                        principalTable: "Club",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Person_Coach_CoachId",
                        column: x => x.CoachId,
                        principalTable: "Coach",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Person_Player_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Player",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Person_RefereeCategory_RefereeCategoryId",
                        column: x => x.RefereeCategoryId,
                        principalTable: "RefereeCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Person_RefereeCategoryType_RefereeCategoryTypeId",
                        column: x => x.RefereeCategoryTypeId,
                        principalTable: "RefereeCategoryType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Person_RefereeDistrict_RefereeDistrictId",
                        column: x => x.RefereeDistrictId,
                        principalTable: "RefereeDistrict",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Person_Referee_RefereeId",
                        column: x => x.RefereeId,
                        principalTable: "Referee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Person_RefereeType_RefereeTypeId",
                        column: x => x.RefereeTypeId,
                        principalTable: "RefereeType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Person_Staff_StaffId",
                        column: x => x.StaffId,
                        principalTable: "Staff",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ShowCase",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false),
                    ShowCaseName = table.Column<string>(nullable: true),
                    ArenaId = table.Column<int>(nullable: true),
                    SeriesId = table.Column<int>(nullable: true),
                    ArenaId1 = table.Column<int>(nullable: true),
                    PersonId = table.Column<int>(nullable: true),
                    PersonId1 = table.Column<int>(nullable: true),
                    PersonId2 = table.Column<int>(nullable: true),
                    PersonId3 = table.Column<int>(nullable: true),
                    PersonId4 = table.Column<int>(nullable: true),
                    PersonId5 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShowCase", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShowCase_Arena_ArenaId",
                        column: x => x.ArenaId,
                        principalTable: "Arena",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ShowCase_Arena_ArenaId1",
                        column: x => x.ArenaId1,
                        principalTable: "Arena",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ShowCase_Person_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ShowCase_Person_PersonId1",
                        column: x => x.PersonId1,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ShowCase_Person_PersonId2",
                        column: x => x.PersonId2,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ShowCase_Person_PersonId3",
                        column: x => x.PersonId3,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ShowCase_Person_PersonId4",
                        column: x => x.PersonId4,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ShowCase_Person_PersonId5",
                        column: x => x.PersonId5,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ShowCase_Series_SeriesId",
                        column: x => x.SeriesId,
                        principalTable: "Series",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Team",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TeamName = table.Column<string>(nullable: true),
                    PersonId = table.Column<int>(nullable: true),
                    PersonId1 = table.Column<int>(nullable: true),
                    PersonId2 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Team", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Team_Person_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Team_Person_PersonId1",
                        column: x => x.PersonId1,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Team_Person_PersonId2",
                        column: x => x.PersonId2,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Game",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MatchNumber = table.Column<int>(nullable: true),
                    MatchDateTime = table.Column<DateTime>(nullable: false),
                    ArenaId = table.Column<int>(nullable: true),
                    TeamId = table.Column<int>(nullable: true),
                    TeamId1 = table.Column<int>(nullable: true),
                    HomeTeamScore = table.Column<int>(nullable: true),
                    AwayTeamScore = table.Column<int>(nullable: true),
                    PersonId = table.Column<int>(nullable: true),
                    PersonId1 = table.Column<int>(nullable: true),
                    PersonId2 = table.Column<int>(nullable: true),
                    PersonId3 = table.Column<int>(nullable: true),
                    PersonId4 = table.Column<int>(nullable: true),
                    SeriesId = table.Column<int>(nullable: true),
                    TSMNumber = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Game", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Game_Arena_ArenaId",
                        column: x => x.ArenaId,
                        principalTable: "Arena",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Game_Person_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Game_Person_PersonId1",
                        column: x => x.PersonId1,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Game_Person_PersonId2",
                        column: x => x.PersonId2,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Game_Person_PersonId3",
                        column: x => x.PersonId3,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Game_Person_PersonId4",
                        column: x => x.PersonId4,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Game_Series_SeriesId",
                        column: x => x.SeriesId,
                        principalTable: "Series",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Game_Team_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Team",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Game_Team_TeamId1",
                        column: x => x.TeamId1,
                        principalTable: "Team",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Game_ArenaId",
                table: "Game",
                column: "ArenaId");

            migrationBuilder.CreateIndex(
                name: "IX_Game_PersonId",
                table: "Game",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Game_PersonId1",
                table: "Game",
                column: "PersonId1");

            migrationBuilder.CreateIndex(
                name: "IX_Game_PersonId2",
                table: "Game",
                column: "PersonId2");

            migrationBuilder.CreateIndex(
                name: "IX_Game_PersonId3",
                table: "Game",
                column: "PersonId3");

            migrationBuilder.CreateIndex(
                name: "IX_Game_PersonId4",
                table: "Game",
                column: "PersonId4");

            migrationBuilder.CreateIndex(
                name: "IX_Game_SeriesId",
                table: "Game",
                column: "SeriesId");

            migrationBuilder.CreateIndex(
                name: "IX_Game_TeamId",
                table: "Game",
                column: "TeamId");

            migrationBuilder.CreateIndex(
                name: "IX_Game_TeamId1",
                table: "Game",
                column: "TeamId1");

            migrationBuilder.CreateIndex(
                name: "IX_Person_ClubId",
                table: "Person",
                column: "ClubId");

            migrationBuilder.CreateIndex(
                name: "IX_Person_CoachId",
                table: "Person",
                column: "CoachId");

            migrationBuilder.CreateIndex(
                name: "IX_Person_PlayerId",
                table: "Person",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_Person_RefereeCategoryId",
                table: "Person",
                column: "RefereeCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Person_RefereeCategoryTypeId",
                table: "Person",
                column: "RefereeCategoryTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Person_RefereeDistrictId",
                table: "Person",
                column: "RefereeDistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_Person_RefereeId",
                table: "Person",
                column: "RefereeId");

            migrationBuilder.CreateIndex(
                name: "IX_Person_RefereeTypeId",
                table: "Person",
                column: "RefereeTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Person_StaffId",
                table: "Person",
                column: "StaffId");

            migrationBuilder.CreateIndex(
                name: "IX_ShowCase_ArenaId",
                table: "ShowCase",
                column: "ArenaId");

            migrationBuilder.CreateIndex(
                name: "IX_ShowCase_ArenaId1",
                table: "ShowCase",
                column: "ArenaId1");

            migrationBuilder.CreateIndex(
                name: "IX_ShowCase_PersonId",
                table: "ShowCase",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_ShowCase_PersonId1",
                table: "ShowCase",
                column: "PersonId1");

            migrationBuilder.CreateIndex(
                name: "IX_ShowCase_PersonId2",
                table: "ShowCase",
                column: "PersonId2");

            migrationBuilder.CreateIndex(
                name: "IX_ShowCase_PersonId3",
                table: "ShowCase",
                column: "PersonId3");

            migrationBuilder.CreateIndex(
                name: "IX_ShowCase_PersonId4",
                table: "ShowCase",
                column: "PersonId4");

            migrationBuilder.CreateIndex(
                name: "IX_ShowCase_PersonId5",
                table: "ShowCase",
                column: "PersonId5");

            migrationBuilder.CreateIndex(
                name: "IX_ShowCase_SeriesId",
                table: "ShowCase",
                column: "SeriesId");

            migrationBuilder.CreateIndex(
                name: "IX_Team_PersonId",
                table: "Team",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Team_PersonId1",
                table: "Team",
                column: "PersonId1");

            migrationBuilder.CreateIndex(
                name: "IX_Team_PersonId2",
                table: "Team",
                column: "PersonId2");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Game");

            migrationBuilder.DropTable(
                name: "ShowCase");

            migrationBuilder.DropTable(
                name: "Team");

            migrationBuilder.DropTable(
                name: "Arena");

            migrationBuilder.DropTable(
                name: "Series");

            migrationBuilder.DropTable(
                name: "Person");

            migrationBuilder.DropTable(
                name: "Club");

            migrationBuilder.DropTable(
                name: "Coach");

            migrationBuilder.DropTable(
                name: "Player");

            migrationBuilder.DropTable(
                name: "RefereeCategory");

            migrationBuilder.DropTable(
                name: "RefereeCategoryType");

            migrationBuilder.DropTable(
                name: "RefereeDistrict");

            migrationBuilder.DropTable(
                name: "Referee");

            migrationBuilder.DropTable(
                name: "RefereeType");

            migrationBuilder.DropTable(
                name: "Staff");
        }
    }
}
