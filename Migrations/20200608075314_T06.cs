using Microsoft.EntityFrameworkCore.Migrations;

namespace GanttEF.Migrations
{
    public partial class T06 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ParentId",
                table: "GanttData");

            migrationBuilder.RenameColumn(
                name: "SDate",
                table: "GanttData",
                newName: "Sdate");

            migrationBuilder.RenameColumn(
                name: "EDate",
                table: "GanttData",
                newName: "Edate");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Sdate",
                table: "GanttData",
                newName: "SDate");

            migrationBuilder.RenameColumn(
                name: "Edate",
                table: "GanttData",
                newName: "EDate");

            migrationBuilder.AddColumn<int>(
                name: "ParentId",
                table: "GanttData",
                type: "int",
                nullable: true);
        }
    }
}
