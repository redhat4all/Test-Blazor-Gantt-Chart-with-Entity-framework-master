using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GanttEF.Migrations
{
    public partial class M04 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "BaselineEndDate",
                table: "GanttData",
                type: "datetime",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "BaselineStartDate",
                table: "GanttData",
                type: "datetime",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Duration",
                table: "GanttData",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GanttDataId",
                table: "GanttData",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Notes",
                table: "GanttData",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Predecessor",
                table: "GanttData",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TaskType",
                table: "GanttData",
                maxLength: 50,
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_GanttData_GanttDataId",
                table: "GanttData",
                column: "GanttDataId");

            migrationBuilder.AddForeignKey(
                name: "FK_GanttData_GanttData_GanttDataId",
                table: "GanttData",
                column: "GanttDataId",
                principalTable: "GanttData",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GanttData_GanttData_GanttDataId",
                table: "GanttData");

            migrationBuilder.DropIndex(
                name: "IX_GanttData_GanttDataId",
                table: "GanttData");

            migrationBuilder.DropColumn(
                name: "BaselineEndDate",
                table: "GanttData");

            migrationBuilder.DropColumn(
                name: "BaselineStartDate",
                table: "GanttData");

            migrationBuilder.DropColumn(
                name: "Duration",
                table: "GanttData");

            migrationBuilder.DropColumn(
                name: "GanttDataId",
                table: "GanttData");

            migrationBuilder.DropColumn(
                name: "Notes",
                table: "GanttData");

            migrationBuilder.DropColumn(
                name: "Predecessor",
                table: "GanttData");

            migrationBuilder.DropColumn(
                name: "TaskType",
                table: "GanttData");
        }
    }
}
