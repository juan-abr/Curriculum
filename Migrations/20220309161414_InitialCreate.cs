using Microsoft.EntityFrameworkCore.Migrations;

namespace Curriculum.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Syllabus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Rank = table.Column<string>(type: "TEXT", nullable: true),
                    Media = table.Column<string>(type: "TEXT", nullable: true),
                    Thumbnail = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Syllabus", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Syllabus");
        }
    }
}
