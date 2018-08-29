using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Loja
{
    public class LojaContext : DbContext
    {
        internal DbSet<Produto> Produtos { get; set; }
        internal DbSet<Compra> Compras { get; set; }
        public DbSet<Promocao> Promocoes { get; set; }
        internal DbSet<Cliente> Clientes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PromocaoProduto>().HasKey(pp => new { pp.PromocaoId, pp.ProdutoId });
            modelBuilder.Entity<Endereco>().ToTable("Enderecos");

            modelBuilder.Entity<Endereco>().Property<int>("ClienteID");

            modelBuilder.Entity<Endereco>().HasKey("ClienteID");
            base.OnModelCreating(modelBuilder);

        }

        public LojaContext()
        { }

        public LojaContext(DbContextOptions<LojaContext> options) : base(options)
        { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                    .UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Initial Catalog=LojaDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }
    }
}
