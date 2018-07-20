using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                primeiro.Preco = produto.Preco;
                repo.Atualizar(primeiro);
            }

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Produto p = new Produto();
            p.Nome = txtNome.Text;
            p.Categoria = txtCategoria.Text;
            p.Preco = Convert.ToDouble(txtValor.Text);

            GravarUsandoEntity(p);
            LerProdutos();
            MessageBox.Show("Cadastrado com sucesso");
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            Produto p = new Produto();
            p.Nome = txtNomeAtualizar.Text;
            p.Categoria = txtCategoriaAtualizar.Text;
            p.Preco = Convert.ToDouble(txtValorAtualizr.Text);

            AtualizarProduto(p);
            LerProdutos();
            MessageBox.Show("Atualizado com sucesso");
        }
    }
}
