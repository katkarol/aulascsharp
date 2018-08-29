using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;

namespace Loja
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LerProdutos();
        }


        private void GravarUsandoEntity(Produto produto)
        {


            using (var repo = new ProdutoDAOEntity())
            {

                repo.Adicionar(produto);
            }
        }

        private void LerProdutos()
        {
            using (var repo = new ProdutoDAOEntity())
            {
                IList<Produto> produtos = repo.LerProdutos();
                cmbNomeProduto.DataSource = produtos;
                cmbNomeProduto.DisplayMember = "Nome";
            }
        }

        private void ExcluirProdutos()
        {
            using (var repo = new ProdutoDAOEntity())
            {
                IList<Produto> produtos = repo.LerProdutos();
                foreach (var p in produtos)
                {
                    repo.Remover(p);
                }
            }

        }

        private void AtualizarProduto(Produto produto)
        {
            using (var repo = new ProdutoDAOEntity())
            {
                Produto primeiro = repo.LerProdutos().First();
                primeiro.Nome = produto.Nome;
                primeiro.Categoria = produto.Categoria;
                primeiro.PrecoUnitario = produto.PrecoUnitario;
                repo.Atualizar(primeiro);
            }

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Produto p = new Produto();
            p.Nome = txtNome.Text;
            p.Categoria = txtCategoria.Text;
            p.PrecoUnitario = Convert.ToDouble(txtValor.Text);

            GravarUsandoEntity(p);
            LerProdutos();
            MessageBox.Show("Cadastrado com sucesso");
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            Produto p = new Produto();
            p.Nome = txtNomeAtualizar.Text;
            p.Categoria = txtCategoriaAtualizar.Text;
            p.PrecoUnitario = Convert.ToDouble(txtValorAtualizr.Text);

            AtualizarProduto(p);
            LerProdutos();
            MessageBox.Show("Atualizado com sucesso");
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            Compra compra = new Compra
            {
                Quantidade = Convert.ToInt32(txtQuantidade.Text),
                Produto = new Produto()
                {
                    Nome = txtProduto.Text,
                    Categoria = txtCategoriaCompra.Text,
                    PrecoUnitario = Convert.ToDouble(txtPrecoUnitario.Text),
                    Unidade = txtUnidade.Text
                }
            };
            compra.Preco = compra.Produto.PrecoUnitario * compra.Quantidade;
            MessageBox.Show("Preço" + compra.Preco.ToString("C2"));
            using (var contexto = new LojaContext())
            {
                contexto.Compras.Add(compra);
                contexto.SaveChanges();
            }
            LerProdutos();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Produto produto1 = new Produto()
            {
                Nome = "Suco de Laranja",
                Categoria = "Bebidas",
                PrecoUnitario = 8.79,
                Unidade = "Litros"
            };
            Produto produto2 = new Produto()
            {
                Nome = "Café",
                Categoria = "Bebidas",
                PrecoUnitario = 12.45,
                Unidade = "Gramas"
            };
            Produto produto3 = new Produto()
            {
                Nome = "Macarrão",
                Categoria = "Alimentos",
                PrecoUnitario = 4.23,
                Unidade = "Gramas"
            };

            Promocao promocaoPascoa = new Promocao();
            promocaoPascoa.Descricao = "Páscoa Feliz";
            promocaoPascoa.DataInicio = DateTime.Now;
            promocaoPascoa.DataTermino = DateTime.Now.AddMonths(3);

            promocaoPascoa.IncluirProduto(produto1);
            promocaoPascoa.IncluirProduto(produto2);
            promocaoPascoa.IncluirProduto(produto3);

            using (var contexto = new LojaContext())
            {
                contexto.Promocoes.Add(promocaoPascoa);
                contexto.SaveChanges();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cliente fulano = new Cliente();
            fulano.Nome = "Fulano de Tal";
            fulano.Endereco = new Endereco()
            {
                Numero = 0,
                Logradouro = "Rua dos bobos",
                Complemento = "Casa muito engraçada",
                Bairro = "Bairro",
                Cidade = "Cidade"
            };

            using (var contexto = new LojaContext())
            {
                contexto.Clientes.Add(fulano);
                contexto.SaveChanges();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (var contexto = new LojaContext())
            {
                Promocao promocao = new Promocao();
                promocao.Descricao = "Queima Total 2018";
                promocao.DataInicio = new DateTime(2018, 1, 1);
                promocao.DataTermino = new DateTime(2018, 1, 31);

                var produtos = contexto.Produtos.Where(p => p.Categoria == "Livros").ToList();
                

                foreach (var item in produtos)
                {
                    promocao.IncluirProduto(item);
                }

                contexto.Promocoes.Add(promocao);
            
            }
            using (var contexto2 = new LojaContext())
            {
                var promocao = contexto2.Promocoes.Include(p => p.Produtos).ThenInclude(pp => pp.Produto).FirstOrDefault();
                StringBuilder mensagem = new StringBuilder();
                mensagem.AppendLine("Mostrando os produtos da promoção");
                foreach (var item in promocao.Produtos)
                {
                    mensagem.AppendLine(item.Produto.ToString());
                }
                MessageBox.Show(mensagem.ToString());
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (var contexto = new LojaContext())
            {
                Cliente cliente = contexto.Clientes.Include(c => c.Endereco).FirstOrDefault();
                MessageBox.Show($"Endereço de entrega: {cliente.Endereco.Logradouro}");

                var produto = contexto.Produtos.Where(p => p.ID == 1).FirstOrDefault();
                contexto.Entry(produto).Collection(p => p.Compra).Query().Where(c => c.Preco > 10).Load();
                StringBuilder mensagem = new StringBuilder();
                mensagem.AppendLine($"Mostrando as compras do produto {produto.Nome}");
                foreach (var item in produto.Compra)
                {
                    mensagem.AppendLine(item.Produto.ToString());

                }
                MessageBox.Show(mensagem.ToString());

            }
        }
    }
}
