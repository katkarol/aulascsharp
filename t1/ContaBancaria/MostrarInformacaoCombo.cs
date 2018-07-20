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
    public partial class MostrarInformacaoCombo : Form
    {
        Conta[] aConta;
        public MostrarInformacaoCombo()
        {
            InitializeComponent();
        }

        private void cmbContas_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indiceSelecionado = cmbContas.SelectedIndex;
            Conta cselecionada = aConta[indiceSelecionado];
            txtTitular.Text = cselecionada.Titular;
            txtNumero.Text = cselecionada.ToString();
            txtSaldo.Text = cselecionada.ToString();

        }

        private void MostrarInformacaoCombo_Load(object sender, EventArgs e)
        {
            Conta cVictor = new Conta();
            cVictor.Titular = "Victor";
            cVictor.Numero = 1;

            Conta cMario = new Conta();
            cMario.Titular = "Mario";
            cMario.Numero = 2;

            this.aConta = new Conta[2];
            aConta[0] = cVictor;
            aConta[1] = cMario;

            foreach (Conta conta in aConta)
            {
                cmbContas.Items.Add(conta.Titular);

            }


        }
    }
}
