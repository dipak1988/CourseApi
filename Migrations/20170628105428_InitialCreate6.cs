using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CourseApi.Migrations
{
    public partial class InitialCreate6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MainCourse",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false),
                    code = table.Column<string>(nullable: true),
                    credits = table.Column<int>(nullable: false),
                    title = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MainCourse", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MainCourse");
        }
    }
}
