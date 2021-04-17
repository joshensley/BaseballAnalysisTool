using Microsoft.EntityFrameworkCore.Migrations;

namespace BaseballAnalysisTool.Data.Migrations
{
    public partial class AddedVariousModelsToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BaseballLeagues",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BaseballLeagues", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "StateOrProvinces",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StateOrProvinces", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "BaseballDivisions",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    BaseballLeagueID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BaseballDivisions", x => x.ID);
                    table.ForeignKey(
                        name: "FK_BaseballDivisions_BaseballLeagues_BaseballLeagueID",
                        column: x => x.BaseballLeagueID,
                        principalTable: "BaseballLeagues",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BaseballDivisions_BaseballLeagueID",
                table: "BaseballDivisions",
                column: "BaseballLeagueID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BaseballDivisions");

            migrationBuilder.DropTable(
                name: "StateOrProvinces");

            migrationBuilder.DropTable(
                name: "BaseballLeagues");
        }
    }
}
