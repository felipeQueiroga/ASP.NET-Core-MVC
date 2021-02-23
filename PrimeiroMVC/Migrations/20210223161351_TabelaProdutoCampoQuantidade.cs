﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace PrimeiroMVC.Migrations
{
    public partial class TabelaProdutoCampoQuantidade : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Quantidade",
                table: "Produto",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Quantidade",
                table: "Produto");
        }
    }
}
