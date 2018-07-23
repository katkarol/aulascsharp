using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Loja.Migrations
{
    public partial class Promocoes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_promocoes_Produtos_ProdutoId",
                table: "promocoes");

            migrationBuilder.DropForeignKey(
                name: "FK_promocoes_Promocao_PromocaoId",
                table: "promocoes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_promocoes",
                table: "promocoes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Promocao",
                table: "Promocao");

            migrationBuilder.RenameTable(
                name: "promocoes",
                newName: "PromocaoProduto");

            migrationBuilder.RenameTable(
                name: "Promocao",
                newName: "Promocoes");

            migrationBuilder.RenameIndex(
                name: "IX_promocoes_ProdutoId",
                table: "PromocaoProduto",
                newName: "IX_PromocaoProduto_ProdutoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PromocaoProduto",
                table: "PromocaoProduto",
                columns: new[] { "PromocaoId", "ProdutoId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Promocoes",
                table: "Promocoes",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_PromocaoProduto_Produtos_ProdutoId",
                table: "PromocaoProduto",
                column: "ProdutoId",
                principalTable: "Produtos",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PromocaoProduto_Promocoes_PromocaoId",
                table: "PromocaoProduto",
                column: "PromocaoId",
                principalTable: "Promocoes",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PromocaoProduto_Produtos_ProdutoId",
                table: "PromocaoProduto");

            migrationBuilder.DropForeignKey(
                name: "FK_PromocaoProduto_Promocoes_PromocaoId",
                table: "PromocaoProduto");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PromocaoProduto",
                table: "PromocaoProduto");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Promocoes",
                table: "Promocoes");

            migrationBuilder.RenameTable(
                name: "PromocaoProduto",
                newName: "promocoes");

            migrationBuilder.RenameTable(
                name: "Promocoes",
                newName: "Promocao");

            migrationBuilder.RenameIndex(
                name: "IX_PromocaoProduto_ProdutoId",
                table: "promocoes",
                newName: "IX_promocoes_ProdutoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_promocoes",
                table: "promocoes",
                columns: new[] { "PromocaoId", "ProdutoId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Promocao",
                table: "Promocao",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_promocoes_Produtos_ProdutoId",
                table: "promocoes",
                column: "ProdutoId",
                principalTable: "Produtos",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_promocoes_Promocao_PromocaoId",
                table: "promocoes",
                column: "PromocaoId",
                principalTable: "Promocao",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
