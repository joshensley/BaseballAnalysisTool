using Microsoft.EntityFrameworkCore.Migrations;

namespace BaseballAnalysisTool.Data.Migrations
{
    public partial class AddedBaseballTeamModelsToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BaseballTeam",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Location = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    NickName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    StadiumName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StateOrProvinceID = table.Column<int>(type: "int", nullable: false),
                    CountryID = table.Column<int>(type: "int", nullable: false),
                    BaseballDivisionID = table.Column<int>(type: "int", nullable: false),
                    BaseballLeagueID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BaseballTeam", x => x.ID);
                    table.ForeignKey(
                        name: "FK_BaseballTeam_BaseballDivisions_BaseballDivisionID",
                        column: x => x.BaseballDivisionID,
                        principalTable: "BaseballDivisions",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseballTeam_BaseballLeagues_BaseballLeagueID",
                        column: x => x.BaseballLeagueID,
                        principalTable: "BaseballLeagues",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BaseballTeam_Country_CountryID",
                        column: x => x.CountryID,
                        principalTable: "Country",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BaseballTeam_StateOrProvinces_StateOrProvinceID",
                        column: x => x.StateOrProvinceID,
                        principalTable: "StateOrProvinces",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BaseballTeam_BaseballDivisionID",
                table: "BaseballTeam",
                column: "BaseballDivisionID");

            migrationBuilder.CreateIndex(
                name: "IX_BaseballTeam_BaseballLeagueID",
                table: "BaseballTeam",
                column: "BaseballLeagueID");

            migrationBuilder.CreateIndex(
                name: "IX_BaseballTeam_CountryID",
                table: "BaseballTeam",
                column: "CountryID");

            migrationBuilder.CreateIndex(
                name: "IX_BaseballTeam_StateOrProvinceID",
                table: "BaseballTeam",
                column: "StateOrProvinceID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BaseballTeam");
        }
    }
}
