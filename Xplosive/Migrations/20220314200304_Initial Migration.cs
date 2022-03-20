using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.Data.EntityFrameworkCore.Metadata;

namespace Xplosive.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 200, nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 200, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 200, nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 200, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 200, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    Discriminator = table.Column<string>(nullable: false),
                    DATE_OF_BIRTH = table.Column<DateTime>(nullable: true),
                    FULL_NAME = table.Column<string>(nullable: true),
                    SEX = table.Column<string>(nullable: true),
                    WEIGHT = table.Column<double>(nullable: true),
                    HEIGHT = table.Column<double>(nullable: true),
                    ACTIVITY_LEVEL = table.Column<int>(nullable: true),
                    WEIGHT_GOAL = table.Column<double>(nullable: true),
                    CALORIC_GOAL = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<string>(maxLength: 200, nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(maxLength: 200, nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(maxLength: 200, nullable: false),
                    ProviderKey = table.Column<string>(maxLength: 200, nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(maxLength: 200, nullable: false),
                    RoleId = table.Column<string>(maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(maxLength: 200, nullable: false),
                    LoginProvider = table.Column<string>(maxLength: 200, nullable: false),
                    Name = table.Column<string>(maxLength: 200, nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DAILY_INFOS",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    WORKOUT_ID = table.Column<string>(nullable: true),
                    NUTRITION_ID = table.Column<string>(nullable: true),
                    WEIGHT = table.Column<double>(nullable: false),
                    USER_ID = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DAILY_INFOS", x => x.ID);
                    table.ForeignKey(
                        name: "FK_DAILY_INFOS_AspNetUsers_USER_ID",
                        column: x => x.USER_ID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DAILY_NUTRITIONS",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    DATE = table.Column<DateTime>(nullable: false),
                    LOG = table.Column<string>(nullable: true),
                    DAILY_INFO_ID = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DAILY_NUTRITIONS", x => x.ID);
                    table.ForeignKey(
                        name: "FK_DAILY_NUTRITIONS_DAILY_INFOS_DAILY_INFO_ID",
                        column: x => x.DAILY_INFO_ID,
                        principalTable: "DAILY_INFOS",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DAILY_WORKOUTS",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    DATE = table.Column<DateTime>(nullable: false),
                    LOG = table.Column<string>(nullable: true),
                    DAILY_INFO_ID = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DAILY_WORKOUTS", x => x.ID);
                    table.ForeignKey(
                        name: "FK_DAILY_WORKOUTS_DAILY_INFOS_DAILY_INFO_ID",
                        column: x => x.DAILY_INFO_ID,
                        principalTable: "DAILY_INFOS",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FOOD",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    NAME = table.Column<string>(nullable: false),
                    NUTRITIONAL_VALUE = table.Column<string>(nullable: true),
                    TIME_OF_DAY = table.Column<DateTime>(nullable: false),
                    ENERGY = table.Column<double>(nullable: false),
                    PROTEIN = table.Column<double>(nullable: false),
                    CARBOHYDRATES = table.Column<double>(nullable: false),
                    CARBOHYDRATES_SUGAR = table.Column<double>(nullable: false),
                    FAT = table.Column<double>(nullable: false),
                    FAT_SATURATED = table.Column<double>(nullable: false),
                    FIBRES = table.Column<double>(nullable: false),
                    SODIUM = table.Column<double>(nullable: false),
                    DAILY_NUTRITION_ID = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FOOD", x => x.ID);
                    table.ForeignKey(
                        name: "FK_FOOD_DAILY_NUTRITIONS_DAILY_NUTRITION_ID",
                        column: x => x.DAILY_NUTRITION_ID,
                        principalTable: "DAILY_NUTRITIONS",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SETS",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    EXERCISE_ID = table.Column<int>(nullable: false),
                    EXERCISE_NAME = table.Column<string>(nullable: true),
                    NUMBER = table.Column<int>(nullable: false),
                    REP_COUNT = table.Column<int>(nullable: false),
                    WEIGHT = table.Column<double>(nullable: false),
                    DAILY_WORKOUT_ID = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SETS", x => x.ID);
                    table.ForeignKey(
                        name: "FK_SETS_DAILY_WORKOUTS_DAILY_WORKOUT_ID",
                        column: x => x.DAILY_WORKOUT_ID,
                        principalTable: "DAILY_WORKOUTS",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DAILY_INFOS_USER_ID",
                table: "DAILY_INFOS",
                column: "USER_ID");

            migrationBuilder.CreateIndex(
                name: "IX_DAILY_NUTRITIONS_DAILY_INFO_ID",
                table: "DAILY_NUTRITIONS",
                column: "DAILY_INFO_ID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DAILY_WORKOUTS_DAILY_INFO_ID",
                table: "DAILY_WORKOUTS",
                column: "DAILY_INFO_ID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_FOOD_DAILY_NUTRITION_ID",
                table: "FOOD",
                column: "DAILY_NUTRITION_ID");

            migrationBuilder.CreateIndex(
                name: "IX_SETS_DAILY_WORKOUT_ID",
                table: "SETS",
                column: "DAILY_WORKOUT_ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "FOOD");

            migrationBuilder.DropTable(
                name: "SETS");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "DAILY_NUTRITIONS");

            migrationBuilder.DropTable(
                name: "DAILY_WORKOUTS");

            migrationBuilder.DropTable(
                name: "DAILY_INFOS");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
