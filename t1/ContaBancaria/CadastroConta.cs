using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContaBancaria
{
    public partial class CadastroConta : Form
    {
        private Form1 aplicacaoPrincipal;
        public CadastroConta(Form1 aplicaccaoPrincipal)
        {
            this.aplicacaoPrincipal = aplicaccaoPrincipal;
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (cmbTipoConta.Text == "Poupança")
            {
                ContaPoupanca cp = new ContaPoupanca();
                cp.Titular.Nome = txtTitularConta.Text;
                cp.Numero = Convert.ToInt32(txtTitularConta.Text);
                this.aplicacaoPrincipal.AdicionarConta(cp);
            }
            else if (cmbTipoConta.Text == "Investimento")
            {
                ContaInvestimento ci = new ContaInvestimento();
                ci.Titular.Nome = txtTitularConta.Text;
                ci.Numero = Convert.ToInt32(txtTitularConta.Text);
                this.aplicacaoPrincipal.AdicionarConta(ci);
            }
            else
            {
                MessageBox.Show("Tipo de conta inválida");
            }
            
        }
    }
}
