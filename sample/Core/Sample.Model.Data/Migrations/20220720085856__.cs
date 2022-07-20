using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Sample.Model.Data.Migrations
{
    public partial class _ : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GuId",
                schema: "pbl",
                table: "Students");

            migrationBuilder.AddColumn<Guid>(
                name: "UnicId",
                schema: "pbl",
                table: "Students",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Students_UnicId",
                schema: "pbl",
                table: "Students",
                column: "UnicId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Students_UnicId",
                schema: "pbl",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "UnicId",
                schema: "pbl",
                table: "Students");

            migrationBuilder.AddColumn<Guid>(
                name: "GuId",
                schema: "pbl",
                table: "Students",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));
        }
    }
}
