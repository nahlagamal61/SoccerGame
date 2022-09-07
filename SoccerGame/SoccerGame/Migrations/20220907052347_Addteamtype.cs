using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SoccerGame.Migrations
{
    public partial class Addteamtype : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TeamType",
                table: "Team",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TeamType",
                table: "Team");
        }
    }
}
