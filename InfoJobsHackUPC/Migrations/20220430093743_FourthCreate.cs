using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace InfoJobsHackUPC.Migrations
{
    public partial class FourthCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Leads",
                columns: table => new
                {
                    IdLead = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PublicationDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Province = table.Column<string>(type: "text", nullable: true),
                    OfferType = table.Column<string>(type: "text", nullable: true),
                    Industry = table.Column<string>(type: "text", nullable: true),
                    JobTitle = table.Column<string>(type: "text", nullable: true),
                    NormalizedName = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Requirements = table.Column<string>(type: "text", nullable: true),
                    MinimumSalary = table.Column<int>(type: "integer", nullable: false),
                    MaximumSalary = table.Column<int>(type: "integer", nullable: false),
                    IsSalaryShowed = table.Column<bool>(type: "boolean", nullable: false),
                    NumViews = table.Column<int>(type: "integer", nullable: false),
                    NumLeads = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Leads", x => x.IdLead);
                });

            migrationBuilder.CreateTable(
                name: "Profiles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Field = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profiles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Skill",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skill", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: true),
                    Province = table.Column<string>(type: "text", nullable: true),
                    Country = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SkillProfile",
                columns: table => new
                {
                    IdProfile = table.Column<int>(type: "integer", nullable: false),
                    IdSkill = table.Column<int>(type: "integer", nullable: false),
                    IDSkill = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SkillProfile", x => x.IdProfile);
                    table.ForeignKey(
                        name: "FK_SkillProfile_Profiles_IdProfile",
                        column: x => x.IdProfile,
                        principalTable: "Profiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SkillProfile_Skill_IDSkill",
                        column: x => x.IDSkill,
                        principalTable: "Skill",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UserProfile",
                columns: table => new
                {
                    IdProfile = table.Column<int>(type: "integer", nullable: false),
                    IdUser = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserProfile", x => x.IdProfile);
                    table.ForeignKey(
                        name: "FK_UserProfile_Profiles_IdProfile",
                        column: x => x.IdProfile,
                        principalTable: "Profiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserProfile_Users_IdUser",
                        column: x => x.IdUser,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserSkill",
                columns: table => new
                {
                    IdSkill = table.Column<int>(type: "integer", nullable: false),
                    IdUser = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserSkill", x => x.IdSkill);
                    table.ForeignKey(
                        name: "FK_UserSkill_Skill_IdSkill",
                        column: x => x.IdSkill,
                        principalTable: "Skill",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserSkill_Users_IdUser",
                        column: x => x.IdUser,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SkillProfile_IdProfile",
                table: "SkillProfile",
                column: "IdProfile");

            migrationBuilder.CreateIndex(
                name: "IX_SkillProfile_IdSkill",
                table: "SkillProfile",
                column: "IdSkill");

            migrationBuilder.CreateIndex(
                name: "IX_SkillProfile_IDSkill",
                table: "SkillProfile",
                column: "IDSkill");

            migrationBuilder.CreateIndex(
                name: "IX_UserProfile_IdProfile",
                table: "UserProfile",
                column: "IdProfile");

            migrationBuilder.CreateIndex(
                name: "IX_UserProfile_IdUser",
                table: "UserProfile",
                column: "IdUser");

            migrationBuilder.CreateIndex(
                name: "IX_UserSkill_IdSkill",
                table: "UserSkill",
                column: "IdSkill");

            migrationBuilder.CreateIndex(
                name: "IX_UserSkill_IdUser",
                table: "UserSkill",
                column: "IdUser");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Leads");

            migrationBuilder.DropTable(
                name: "SkillProfile");

            migrationBuilder.DropTable(
                name: "UserProfile");

            migrationBuilder.DropTable(
                name: "UserSkill");

            migrationBuilder.DropTable(
                name: "Profiles");

            migrationBuilder.DropTable(
                name: "Skill");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
