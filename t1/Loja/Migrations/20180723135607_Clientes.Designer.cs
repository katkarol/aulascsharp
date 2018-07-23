using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Loja;

namespace Loja.Migrations
{
    [DbContext(typeof(LojaContext))]
    [Migration("20180723135607_Clientes")]
    partial class Clientes
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Loja.Cliente", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nome");

                    b.HasKey("ID");

                    b.ToTable("Clientes");
                });

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

            modelBuilder.Entity("Loja.Endereco", b =>
                {
                    b.Property<int>("ClienteID");

                    b.Property<string>("Bairro");

                    b.Property<string>("Cidade");

                    b.Property<string>("Complemento");

                    b.Property<string>("Logradouro");

                    b.Property<int>("Numero");

                    b.HasKey("ClienteID");

                    b.ToTable("Enderecos");
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

            modelBuilder.Entity("Loja.Promocao", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DataInicio");

                    b.Property<DateTime>("DataTermino");

                    b.Property<string>("Descricao");

                    b.HasKey("ID");

                    b.ToTable("Promocoes");
                });

            modelBuilder.Entity("Loja.PromocaoProduto", b =>
                {
                    b.Property<int>("PromocaoId");

                    b.Property<int>("ProdutoId");

                    b.HasKey("PromocaoId", "ProdutoId");

                    b.HasIndex("ProdutoId");

                    b.ToTable("PromocaoProduto");
                });

            modelBuilder.Entity("Loja.Compra", b =>
                {
                    b.HasOne("Loja.Produto", "Produto")
                        .WithMany()
                        .HasForeignKey("ProdutoID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Loja.Endereco", b =>
                {
                    b.HasOne("Loja.Cliente", "Cliente")
                        .WithOne("Endereco")
                        .HasForeignKey("Loja.Endereco", "ClienteID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Loja.PromocaoProduto", b =>
                {
                    b.HasOne("Loja.Produto", "Produto")
                        .WithMany("Promocao")
                        .HasForeignKey("ProdutoId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Loja.Promocao", "Promocao")
                        .WithMany("Produtos")
                        .HasForeignKey("PromocaoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
