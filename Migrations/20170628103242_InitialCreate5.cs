using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CourseApi.Migrations
{
    public partial class InitialCreate5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Title",
                table: "PCourse",
                newName: "title");

            migrationBuilder.RenameColumn(
                name: "Credits",
                table: "PCourse",
                newName: "credits");

            migrationBuilder.AddColumn<string>(
                name: "code",
                table: "PCourse",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "code",
                table: "PCourse");

            migrationBuilder.RenameColumn(
                name: "title",
                table: "PCourse",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "credits",
                table: "PCourse",
                newName: "Credits");
        }
    }
}
