﻿using Microsoft.EntityFrameworkCore.Migrations;
using ProductApi.Model;

#nullable disable

namespace ProductApi.Migrations
{
    /// <inheritdoc />
    public partial class init4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "categoryid",
                table: "Product");
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                    .Annotation("SqlServer:Identity", "1,1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
        constraints: table =>
        {
            table.PrimaryKey("PK_Category", x => x.Id);
        });
        }



        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Category");
            migrationBuilder.AddColumn<int>(
                name: "categoryid",
                table: "Producst",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        }
    }

