using Microsoft.EntityFrameworkCore.Migrations;

namespace BaseballAnalysisTool.Data.Migrations
{
    public partial class AddedPropertiesToBaseballTeamModelInDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "firebaseTeamLogoImageName",
                table: "BaseballTeam",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "firebaseTeamLogoImageUrl",
                table: "BaseballTeam",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "firebaseTeamLogoImageName",
                table: "BaseballTeam");

            migrationBuilder.DropColumn(
                name: "firebaseTeamLogoImageUrl",
                table: "BaseballTeam");
        }
    }
}
