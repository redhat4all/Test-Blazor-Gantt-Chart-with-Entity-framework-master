using Microsoft.EntityFrameworkCore.Migrations;

namespace GanttEF.Migrations
{
    public partial class T07 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ParentId",
                table: "GanttData",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ParentId",
                table: "GanttData");
        }
    }
}
