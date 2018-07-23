using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Loja;

namespace Loja.Migrations
{
    [DbContext(typeof(LojaContext))]
    [Migration("20180723115604_Compra")]
    partial class Compra
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Loja.Compra", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("Preco");

                    b.Property<int>("ProdutoID");

                    b.Property<int>("Quantidade");

                    b.HasKey("ID");

                    b.HasIndex("ProdutoID");

                    b.ToTable("Compras");
                });

            modelBuilder.Entity("Loja.Produto", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Categoria");

                    b.Property<string>("Nome");

                    b.Property<double>("PrecoUnitario");

                    b.Property<string>("Unidade");

                    b.HasKey("ID");

                    b.ToTable("Produtos");
                });

            modelBuilder.Entity("Loja.Compra", b =>
                {
                    b.HasOne("Loja.Produto", "Produto")
                        .WithMany()
                        .HasForeignKey("ProdutoID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
