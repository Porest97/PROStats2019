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
                name: "ArenaCategory",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ArenaCategoryName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArenaCategory", x => x.Id);
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
                name: "GameStatus",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    GameStatusName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GameStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Location",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    LocationName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Location", x => x.Id);
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
                name: "Sport",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SportName = table.Column<string>(nullable: true),
                    KcalPerHour = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sport", x => x.Id);
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
                name: "Arena",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ArenaName = table.Column<string>(nullable: true),
                    ArenaStreetAddress = table.Column<string>(nullable: true),
                    ArenaZipCode = table.Column<string>(nullable: true),
                    ArenaCounty = table.Column<string>(nullable: true),
                    ArenaCountry = table.Column<string>(nullable: true),
                    RefereeDistrictId = table.Column<int>(nullable: true),
                    ArenaCategoryId = table.Column<int>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumber1 = table.Column<string>(nullable: true),
                    AudienceCapacity = table.Column<string>(nullable: true),
                    Standing = table.Column<string>(nullable: true),
                    Bench = table.Column<string>(nullable: true),
                    Chair = table.Column<string>(nullable: true),
                    SoftChair = table.Column<string>(nullable: true),
                    DisabledSeats = table.Column<string>(nullable: true),
                    BuildingYear = table.Column<string>(nullable: true),
                    RebuildingYear = table.Column<string>(nullable: true),
                    LatestInspection = table.Column<string>(nullable: true),
                    LatestChecked = table.Column<string>(nullable: true),
                    ArenaNumberTSM = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Arena", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Arena_ArenaCategory_ArenaCategoryId",
                        column: x => x.ArenaCategoryId,
                        principalTable: "ArenaCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Arena_RefereeDistrict_RefereeDistrictId",
                        column: x => x.RefereeDistrictId,
                        principalTable: "RefereeDistrict",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Workout",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SportId = table.Column<int>(nullable: true),
                    LocationId = table.Column<int>(nullable: true),
                    Distance = table.Column<double>(nullable: true),
                    StartDateTime = table.Column<DateTime>(nullable: false),
                    EndDateTime = table.Column<DateTime>(nullable: false),
                    Duration = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Workout", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Workout_Location_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Location",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Workout_Sport_SportId",
                        column: x => x.SportId,
                        principalTable: "Sport",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                    StaffId = table.Column<int>(nullable: true),
                    PhoneNumber1 = table.Column<string>(nullable: true)
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

            migrationBuilder.CreateTable(
                name: "ProGame",
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
                    TSMNumber = table.Column<int>(nullable: true),
                    Payment = table.Column<int>(nullable: true),
                    Payed = table.Column<bool>(nullable: false),
                    GameStatusId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProGame", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProGame_Arena_ArenaId",
                        column: x => x.ArenaId,
                        principalTable: "Arena",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProGame_GameStatus_GameStatusId",
                        column: x => x.GameStatusId,
                        principalTable: "GameStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProGame_Person_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProGame_Person_PersonId1",
                        column: x => x.PersonId1,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProGame_Person_PersonId2",
                        column: x => x.PersonId2,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProGame_Person_PersonId3",
                        column: x => x.PersonId3,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProGame_Person_PersonId4",
                        column: x => x.PersonId4,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProGame_Series_SeriesId",
                        column: x => x.SeriesId,
                        principalTable: "Series",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProGame_Team_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Team",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProGame_Team_TeamId1",
                        column: x => x.TeamId1,
                        principalTable: "Team",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PROGames2012",
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
                    TSMNumber = table.Column<int>(nullable: true),
                    Payment = table.Column<int>(nullable: true),
                    Payed = table.Column<bool>(nullable: false),
                    GameStatusId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PROGames2012", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PROGames2012_Arena_ArenaId",
                        column: x => x.ArenaId,
                        principalTable: "Arena",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PROGames2012_GameStatus_GameStatusId",
                        column: x => x.GameStatusId,
                        principalTable: "GameStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PROGames2012_Person_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PROGames2012_Person_PersonId1",
                        column: x => x.PersonId1,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PROGames2012_Person_PersonId2",
                        column: x => x.PersonId2,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PROGames2012_Person_PersonId3",
                        column: x => x.PersonId3,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PROGames2012_Person_PersonId4",
                        column: x => x.PersonId4,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PROGames2012_Series_SeriesId",
                        column: x => x.SeriesId,
                        principalTable: "Series",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PROGames2012_Team_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Team",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PROGames2012_Team_TeamId1",
                        column: x => x.TeamId1,
                        principalTable: "Team",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PROGames2013",
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
                    TSMNumber = table.Column<int>(nullable: true),
                    Payment = table.Column<int>(nullable: true),
                    Payed = table.Column<bool>(nullable: false),
                    GameStatusId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PROGames2013", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PROGames2013_Arena_ArenaId",
                        column: x => x.ArenaId,
                        principalTable: "Arena",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PROGames2013_GameStatus_GameStatusId",
                        column: x => x.GameStatusId,
                        principalTable: "GameStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PROGames2013_Person_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PROGames2013_Person_PersonId1",
                        column: x => x.PersonId1,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PROGames2013_Person_PersonId2",
                        column: x => x.PersonId2,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PROGames2013_Person_PersonId3",
                        column: x => x.PersonId3,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PROGames2013_Person_PersonId4",
                        column: x => x.PersonId4,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PROGames2013_Series_SeriesId",
                        column: x => x.SeriesId,
                        principalTable: "Series",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PROGames2013_Team_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Team",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PROGames2013_Team_TeamId1",
                        column: x => x.TeamId1,
                        principalTable: "Team",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PROGames2014",
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
                    TSMNumber = table.Column<int>(nullable: true),
                    Payment = table.Column<int>(nullable: true),
                    Payed = table.Column<bool>(nullable: false),
                    GameStatusId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PROGames2014", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PROGames2014_Arena_ArenaId",
                        column: x => x.ArenaId,
                        principalTable: "Arena",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PROGames2014_GameStatus_GameStatusId",
                        column: x => x.GameStatusId,
                        principalTable: "GameStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PROGames2014_Person_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PROGames2014_Person_PersonId1",
                        column: x => x.PersonId1,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PROGames2014_Person_PersonId2",
                        column: x => x.PersonId2,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PROGames2014_Person_PersonId3",
                        column: x => x.PersonId3,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PROGames2014_Person_PersonId4",
                        column: x => x.PersonId4,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PROGames2014_Series_SeriesId",
                        column: x => x.SeriesId,
                        principalTable: "Series",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PROGames2014_Team_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Team",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PROGames2014_Team_TeamId1",
                        column: x => x.TeamId1,
                        principalTable: "Team",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PROGames2015",
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
                    TSMNumber = table.Column<int>(nullable: true),
                    Payment = table.Column<int>(nullable: true),
                    Payed = table.Column<bool>(nullable: false),
                    GameStatusId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PROGames2015", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PROGames2015_Arena_ArenaId",
                        column: x => x.ArenaId,
                        principalTable: "Arena",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PROGames2015_GameStatus_GameStatusId",
                        column: x => x.GameStatusId,
                        principalTable: "GameStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PROGames2015_Person_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PROGames2015_Person_PersonId1",
                        column: x => x.PersonId1,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PROGames2015_Person_PersonId2",
                        column: x => x.PersonId2,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PROGames2015_Person_PersonId3",
                        column: x => x.PersonId3,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PROGames2015_Person_PersonId4",
                        column: x => x.PersonId4,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PROGames2015_Series_SeriesId",
                        column: x => x.SeriesId,
                        principalTable: "Series",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PROGames2015_Team_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Team",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PROGames2015_Team_TeamId1",
                        column: x => x.TeamId1,
                        principalTable: "Team",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PROGames2016",
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
                    TSMNumber = table.Column<int>(nullable: true),
                    Payment = table.Column<int>(nullable: true),
                    Payed = table.Column<bool>(nullable: false),
                    GameStatusId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PROGames2016", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PROGames2016_Arena_ArenaId",
                        column: x => x.ArenaId,
                        principalTable: "Arena",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PROGames2016_GameStatus_GameStatusId",
                        column: x => x.GameStatusId,
                        principalTable: "GameStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PROGames2016_Person_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PROGames2016_Person_PersonId1",
                        column: x => x.PersonId1,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PROGames2016_Person_PersonId2",
                        column: x => x.PersonId2,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PROGames2016_Person_PersonId3",
                        column: x => x.PersonId3,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PROGames2016_Person_PersonId4",
                        column: x => x.PersonId4,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PROGames2016_Series_SeriesId",
                        column: x => x.SeriesId,
                        principalTable: "Series",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PROGames2016_Team_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Team",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PROGames2016_Team_TeamId1",
                        column: x => x.TeamId1,
                        principalTable: "Team",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PROGames2017",
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
                    TSMNumber = table.Column<int>(nullable: true),
                    Payment = table.Column<int>(nullable: true),
                    Payed = table.Column<bool>(nullable: false),
                    GameStatusId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PROGames2017", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PROGames2017_Arena_ArenaId",
                        column: x => x.ArenaId,
                        principalTable: "Arena",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PROGames2017_GameStatus_GameStatusId",
                        column: x => x.GameStatusId,
                        principalTable: "GameStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PROGames2017_Person_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PROGames2017_Person_PersonId1",
                        column: x => x.PersonId1,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PROGames2017_Person_PersonId2",
                        column: x => x.PersonId2,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PROGames2017_Person_PersonId3",
                        column: x => x.PersonId3,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PROGames2017_Person_PersonId4",
                        column: x => x.PersonId4,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PROGames2017_Series_SeriesId",
                        column: x => x.SeriesId,
                        principalTable: "Series",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PROGames2017_Team_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Team",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PROGames2017_Team_TeamId1",
                        column: x => x.TeamId1,
                        principalTable: "Team",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PROGames2018",
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
                    TSMNumber = table.Column<int>(nullable: true),
                    Payment = table.Column<int>(nullable: true),
                    Payed = table.Column<bool>(nullable: false),
                    GameStatusId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PROGames2018", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PROGames2018_Arena_ArenaId",
                        column: x => x.ArenaId,
                        principalTable: "Arena",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PROGames2018_GameStatus_GameStatusId",
                        column: x => x.GameStatusId,
                        principalTable: "GameStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PROGames2018_Person_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PROGames2018_Person_PersonId1",
                        column: x => x.PersonId1,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PROGames2018_Person_PersonId2",
                        column: x => x.PersonId2,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PROGames2018_Person_PersonId3",
                        column: x => x.PersonId3,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PROGames2018_Person_PersonId4",
                        column: x => x.PersonId4,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PROGames2018_Series_SeriesId",
                        column: x => x.SeriesId,
                        principalTable: "Series",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PROGames2018_Team_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Team",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PROGames2018_Team_TeamId1",
                        column: x => x.TeamId1,
                        principalTable: "Team",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PROGames2019",
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
                    TSMNumber = table.Column<int>(nullable: true),
                    Payment = table.Column<int>(nullable: true),
                    Payed = table.Column<bool>(nullable: false),
                    GameStatusId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PROGames2019", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PROGames2019_Arena_ArenaId",
                        column: x => x.ArenaId,
                        principalTable: "Arena",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PROGames2019_GameStatus_GameStatusId",
                        column: x => x.GameStatusId,
                        principalTable: "GameStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PROGames2019_Person_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PROGames2019_Person_PersonId1",
                        column: x => x.PersonId1,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PROGames2019_Person_PersonId2",
                        column: x => x.PersonId2,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PROGames2019_Person_PersonId3",
                        column: x => x.PersonId3,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PROGames2019_Person_PersonId4",
                        column: x => x.PersonId4,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PROGames2019_Series_SeriesId",
                        column: x => x.SeriesId,
                        principalTable: "Series",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PROGames2019_Team_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Team",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PROGames2019_Team_TeamId1",
                        column: x => x.TeamId1,
                        principalTable: "Team",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

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
                name: "IX_Arena_ArenaCategoryId",
                table: "Arena",
                column: "ArenaCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Arena_RefereeDistrictId",
                table: "Arena",
                column: "RefereeDistrictId");

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
                name: "IX_ProGame_ArenaId",
                table: "ProGame",
                column: "ArenaId");

            migrationBuilder.CreateIndex(
                name: "IX_ProGame_GameStatusId",
                table: "ProGame",
                column: "GameStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_ProGame_PersonId",
                table: "ProGame",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_ProGame_PersonId1",
                table: "ProGame",
                column: "PersonId1");

            migrationBuilder.CreateIndex(
                name: "IX_ProGame_PersonId2",
                table: "ProGame",
                column: "PersonId2");

            migrationBuilder.CreateIndex(
                name: "IX_ProGame_PersonId3",
                table: "ProGame",
                column: "PersonId3");

            migrationBuilder.CreateIndex(
                name: "IX_ProGame_PersonId4",
                table: "ProGame",
                column: "PersonId4");

            migrationBuilder.CreateIndex(
                name: "IX_ProGame_SeriesId",
                table: "ProGame",
                column: "SeriesId");

            migrationBuilder.CreateIndex(
                name: "IX_ProGame_TeamId",
                table: "ProGame",
                column: "TeamId");

            migrationBuilder.CreateIndex(
                name: "IX_ProGame_TeamId1",
                table: "ProGame",
                column: "TeamId1");

            migrationBuilder.CreateIndex(
                name: "IX_PROGames2012_ArenaId",
                table: "PROGames2012",
                column: "ArenaId");

            migrationBuilder.CreateIndex(
                name: "IX_PROGames2012_GameStatusId",
                table: "PROGames2012",
                column: "GameStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_PROGames2012_PersonId",
                table: "PROGames2012",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_PROGames2012_PersonId1",
                table: "PROGames2012",
                column: "PersonId1");

            migrationBuilder.CreateIndex(
                name: "IX_PROGames2012_PersonId2",
                table: "PROGames2012",
                column: "PersonId2");

            migrationBuilder.CreateIndex(
                name: "IX_PROGames2012_PersonId3",
                table: "PROGames2012",
                column: "PersonId3");

            migrationBuilder.CreateIndex(
                name: "IX_PROGames2012_PersonId4",
                table: "PROGames2012",
                column: "PersonId4");

            migrationBuilder.CreateIndex(
                name: "IX_PROGames2012_SeriesId",
                table: "PROGames2012",
                column: "SeriesId");

            migrationBuilder.CreateIndex(
                name: "IX_PROGames2012_TeamId",
                table: "PROGames2012",
                column: "TeamId");

            migrationBuilder.CreateIndex(
                name: "IX_PROGames2012_TeamId1",
                table: "PROGames2012",
                column: "TeamId1");

            migrationBuilder.CreateIndex(
                name: "IX_PROGames2013_ArenaId",
                table: "PROGames2013",
                column: "ArenaId");

            migrationBuilder.CreateIndex(
                name: "IX_PROGames2013_GameStatusId",
                table: "PROGames2013",
                column: "GameStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_PROGames2013_PersonId",
                table: "PROGames2013",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_PROGames2013_PersonId1",
                table: "PROGames2013",
                column: "PersonId1");

            migrationBuilder.CreateIndex(
                name: "IX_PROGames2013_PersonId2",
                table: "PROGames2013",
                column: "PersonId2");

            migrationBuilder.CreateIndex(
                name: "IX_PROGames2013_PersonId3",
                table: "PROGames2013",
                column: "PersonId3");

            migrationBuilder.CreateIndex(
                name: "IX_PROGames2013_PersonId4",
                table: "PROGames2013",
                column: "PersonId4");

            migrationBuilder.CreateIndex(
                name: "IX_PROGames2013_SeriesId",
                table: "PROGames2013",
                column: "SeriesId");

            migrationBuilder.CreateIndex(
                name: "IX_PROGames2013_TeamId",
                table: "PROGames2013",
                column: "TeamId");

            migrationBuilder.CreateIndex(
                name: "IX_PROGames2013_TeamId1",
                table: "PROGames2013",
                column: "TeamId1");

            migrationBuilder.CreateIndex(
                name: "IX_PROGames2014_ArenaId",
                table: "PROGames2014",
                column: "ArenaId");

            migrationBuilder.CreateIndex(
                name: "IX_PROGames2014_GameStatusId",
                table: "PROGames2014",
                column: "GameStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_PROGames2014_PersonId",
                table: "PROGames2014",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_PROGames2014_PersonId1",
                table: "PROGames2014",
                column: "PersonId1");

            migrationBuilder.CreateIndex(
                name: "IX_PROGames2014_PersonId2",
                table: "PROGames2014",
                column: "PersonId2");

            migrationBuilder.CreateIndex(
                name: "IX_PROGames2014_PersonId3",
                table: "PROGames2014",
                column: "PersonId3");

            migrationBuilder.CreateIndex(
                name: "IX_PROGames2014_PersonId4",
                table: "PROGames2014",
                column: "PersonId4");

            migrationBuilder.CreateIndex(
                name: "IX_PROGames2014_SeriesId",
                table: "PROGames2014",
                column: "SeriesId");

            migrationBuilder.CreateIndex(
                name: "IX_PROGames2014_TeamId",
                table: "PROGames2014",
                column: "TeamId");

            migrationBuilder.CreateIndex(
                name: "IX_PROGames2014_TeamId1",
                table: "PROGames2014",
                column: "TeamId1");

            migrationBuilder.CreateIndex(
                name: "IX_PROGames2015_ArenaId",
                table: "PROGames2015",
                column: "ArenaId");

            migrationBuilder.CreateIndex(
                name: "IX_PROGames2015_GameStatusId",
                table: "PROGames2015",
                column: "GameStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_PROGames2015_PersonId",
                table: "PROGames2015",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_PROGames2015_PersonId1",
                table: "PROGames2015",
                column: "PersonId1");

            migrationBuilder.CreateIndex(
                name: "IX_PROGames2015_PersonId2",
                table: "PROGames2015",
                column: "PersonId2");

            migrationBuilder.CreateIndex(
                name: "IX_PROGames2015_PersonId3",
                table: "PROGames2015",
                column: "PersonId3");

            migrationBuilder.CreateIndex(
                name: "IX_PROGames2015_PersonId4",
                table: "PROGames2015",
                column: "PersonId4");

            migrationBuilder.CreateIndex(
                name: "IX_PROGames2015_SeriesId",
                table: "PROGames2015",
                column: "SeriesId");

            migrationBuilder.CreateIndex(
                name: "IX_PROGames2015_TeamId",
                table: "PROGames2015",
                column: "TeamId");

            migrationBuilder.CreateIndex(
                name: "IX_PROGames2015_TeamId1",
                table: "PROGames2015",
                column: "TeamId1");

            migrationBuilder.CreateIndex(
                name: "IX_PROGames2016_ArenaId",
                table: "PROGames2016",
                column: "ArenaId");

            migrationBuilder.CreateIndex(
                name: "IX_PROGames2016_GameStatusId",
                table: "PROGames2016",
                column: "GameStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_PROGames2016_PersonId",
                table: "PROGames2016",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_PROGames2016_PersonId1",
                table: "PROGames2016",
                column: "PersonId1");

            migrationBuilder.CreateIndex(
                name: "IX_PROGames2016_PersonId2",
                table: "PROGames2016",
                column: "PersonId2");

            migrationBuilder.CreateIndex(
                name: "IX_PROGames2016_PersonId3",
                table: "PROGames2016",
                column: "PersonId3");

            migrationBuilder.CreateIndex(
                name: "IX_PROGames2016_PersonId4",
                table: "PROGames2016",
                column: "PersonId4");

            migrationBuilder.CreateIndex(
                name: "IX_PROGames2016_SeriesId",
                table: "PROGames2016",
                column: "SeriesId");

            migrationBuilder.CreateIndex(
                name: "IX_PROGames2016_TeamId",
                table: "PROGames2016",
                column: "TeamId");

            migrationBuilder.CreateIndex(
                name: "IX_PROGames2016_TeamId1",
                table: "PROGames2016",
                column: "TeamId1");

            migrationBuilder.CreateIndex(
                name: "IX_PROGames2017_ArenaId",
                table: "PROGames2017",
                column: "ArenaId");

            migrationBuilder.CreateIndex(
                name: "IX_PROGames2017_GameStatusId",
                table: "PROGames2017",
                column: "GameStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_PROGames2017_PersonId",
                table: "PROGames2017",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_PROGames2017_PersonId1",
                table: "PROGames2017",
                column: "PersonId1");

            migrationBuilder.CreateIndex(
                name: "IX_PROGames2017_PersonId2",
                table: "PROGames2017",
                column: "PersonId2");

            migrationBuilder.CreateIndex(
                name: "IX_PROGames2017_PersonId3",
                table: "PROGames2017",
                column: "PersonId3");

            migrationBuilder.CreateIndex(
                name: "IX_PROGames2017_PersonId4",
                table: "PROGames2017",
                column: "PersonId4");

            migrationBuilder.CreateIndex(
                name: "IX_PROGames2017_SeriesId",
                table: "PROGames2017",
                column: "SeriesId");

            migrationBuilder.CreateIndex(
                name: "IX_PROGames2017_TeamId",
                table: "PROGames2017",
                column: "TeamId");

            migrationBuilder.CreateIndex(
                name: "IX_PROGames2017_TeamId1",
                table: "PROGames2017",
                column: "TeamId1");

            migrationBuilder.CreateIndex(
                name: "IX_PROGames2018_ArenaId",
                table: "PROGames2018",
                column: "ArenaId");

            migrationBuilder.CreateIndex(
                name: "IX_PROGames2018_GameStatusId",
                table: "PROGames2018",
                column: "GameStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_PROGames2018_PersonId",
                table: "PROGames2018",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_PROGames2018_PersonId1",
                table: "PROGames2018",
                column: "PersonId1");

            migrationBuilder.CreateIndex(
                name: "IX_PROGames2018_PersonId2",
                table: "PROGames2018",
                column: "PersonId2");

            migrationBuilder.CreateIndex(
                name: "IX_PROGames2018_PersonId3",
                table: "PROGames2018",
                column: "PersonId3");

            migrationBuilder.CreateIndex(
                name: "IX_PROGames2018_PersonId4",
                table: "PROGames2018",
                column: "PersonId4");

            migrationBuilder.CreateIndex(
                name: "IX_PROGames2018_SeriesId",
                table: "PROGames2018",
                column: "SeriesId");

            migrationBuilder.CreateIndex(
                name: "IX_PROGames2018_TeamId",
                table: "PROGames2018",
                column: "TeamId");

            migrationBuilder.CreateIndex(
                name: "IX_PROGames2018_TeamId1",
                table: "PROGames2018",
                column: "TeamId1");

            migrationBuilder.CreateIndex(
                name: "IX_PROGames2019_ArenaId",
                table: "PROGames2019",
                column: "ArenaId");

            migrationBuilder.CreateIndex(
                name: "IX_PROGames2019_GameStatusId",
                table: "PROGames2019",
                column: "GameStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_PROGames2019_PersonId",
                table: "PROGames2019",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_PROGames2019_PersonId1",
                table: "PROGames2019",
                column: "PersonId1");

            migrationBuilder.CreateIndex(
                name: "IX_PROGames2019_PersonId2",
                table: "PROGames2019",
                column: "PersonId2");

            migrationBuilder.CreateIndex(
                name: "IX_PROGames2019_PersonId3",
                table: "PROGames2019",
                column: "PersonId3");

            migrationBuilder.CreateIndex(
                name: "IX_PROGames2019_PersonId4",
                table: "PROGames2019",
                column: "PersonId4");

            migrationBuilder.CreateIndex(
                name: "IX_PROGames2019_SeriesId",
                table: "PROGames2019",
                column: "SeriesId");

            migrationBuilder.CreateIndex(
                name: "IX_PROGames2019_TeamId",
                table: "PROGames2019",
                column: "TeamId");

            migrationBuilder.CreateIndex(
                name: "IX_PROGames2019_TeamId1",
                table: "PROGames2019",
                column: "TeamId1");

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

            migrationBuilder.CreateIndex(
                name: "IX_Workout_LocationId",
                table: "Workout",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Workout_SportId",
                table: "Workout",
                column: "SportId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PaymentPost");

            migrationBuilder.DropTable(
                name: "ProGame");

            migrationBuilder.DropTable(
                name: "PROGames2012");

            migrationBuilder.DropTable(
                name: "PROGames2013");

            migrationBuilder.DropTable(
                name: "PROGames2014");

            migrationBuilder.DropTable(
                name: "PROGames2015");

            migrationBuilder.DropTable(
                name: "PROGames2016");

            migrationBuilder.DropTable(
                name: "PROGames2017");

            migrationBuilder.DropTable(
                name: "PROGames2018");

            migrationBuilder.DropTable(
                name: "PROGames2019");

            migrationBuilder.DropTable(
                name: "ShowCase");

            migrationBuilder.DropTable(
                name: "Workout");

            migrationBuilder.DropTable(
                name: "Game");

            migrationBuilder.DropTable(
                name: "GameStatus");

            migrationBuilder.DropTable(
                name: "Location");

            migrationBuilder.DropTable(
                name: "Sport");

            migrationBuilder.DropTable(
                name: "Arena");

            migrationBuilder.DropTable(
                name: "Series");

            migrationBuilder.DropTable(
                name: "Team");

            migrationBuilder.DropTable(
                name: "ArenaCategory");

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
