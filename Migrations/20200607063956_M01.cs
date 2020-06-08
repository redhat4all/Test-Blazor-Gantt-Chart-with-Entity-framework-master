using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GanttEF.Migrations
{
    public partial class M01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GanttData",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: true),
                    SDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    EDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Progress = table.Column<string>(maxLength: 50, nullable: true),
                    ParentId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GanttData", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GanttData");
        }
    }
}
