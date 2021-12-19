﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace AKCore.Migrations
{
    public partial class balettmeny : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Balett",
                table: "Menus",
                type: "bit",
                nullable: false,
                defaultValue: false);

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.DropColumn(
                name: "Balett",
                table: "Menus");

        }
    }
}
