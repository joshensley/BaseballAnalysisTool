using Microsoft.EntityFrameworkCore.Migrations;

namespace BaseballAnalysisTool.Data.Migrations
{
    public partial class EditPropertiesInBaseballTeamModelInDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "firebaseTeamLogoImageName",
                table: "BaseballTeam");

            migrationBuilder.RenameColumn(
                name: "firebaseTeamLogoImageUrl",
                table: "BaseballTeam",
                newName: "TeamLogoImagePath");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TeamLogoImagePath",
                table: "BaseballTeam",
                newName: "firebaseTeamLogoImageUrl");

            migrationBuilder.AddColumn<string>(
                name: "firebaseTeamLogoImageName",
                table: "BaseballTeam",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
