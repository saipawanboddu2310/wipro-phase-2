﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentReactWebApIDemo.Migrations
{
    /// <inheritdoc />
    public partial class extracoladded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Students",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Students");
        }
    }
}
