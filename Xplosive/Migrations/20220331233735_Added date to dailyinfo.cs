using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Xplosive.Migrations
{
    public partial class Addeddatetodailyinfo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DATE",
                table: "DAILY_INFOS",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DATE",
                table: "DAILY_INFOS");
        }
    }
}
