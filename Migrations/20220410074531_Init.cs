using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineCodePlatform.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProblemSolution",
                columns: table => new
                {
                    ProblemSolutionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Solution = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProblemSolution", x => x.ProblemSolutionId);
                });

            migrationBuilder.CreateTable(
                name: "ProblemStatements",
                columns: table => new
                {
                    ProblemStatementId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProblemName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProblemSolutionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProblemStatements", x => x.ProblemStatementId);
                    table.ForeignKey(
                        name: "FK_ProblemStatements_ProblemSolution_ProblemSolutionId",
                        column: x => x.ProblemSolutionId,
                        principalTable: "ProblemSolution",
                        principalColumn: "ProblemSolutionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProblemStatements_ProblemSolutionId",
                table: "ProblemStatements",
                column: "ProblemSolutionId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProblemStatements");

            migrationBuilder.DropTable(
                name: "ProblemSolution");
        }
    }
}
