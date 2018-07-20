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
    public partial class Form1 : Form
    {
        List<Conta> aConta;
        int operacao;
        private Button btnCadstrar;
        int qtdContas;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Conta coVictor = new ContaPoupanca();
            coVictor.Numero = 1;
            coVictor.Depositar(200);
            coVictor.Titular.Nome = "Victor";

            Conta coRafael = new ContaPoupanca();
            coRafael.Numero = 2;
            coRafael.Depositar(5000);
            coRafael.Titular.Nome = "Rafael";

            Conta coFelipe = new ContaPoupanca();
            coFelipe.Depositar(4000);
            coFelipe.Numero = 3;
            coFelipe.Titular.Nome = "Felipe";

            Conta coAlan = new ContaPoupanca();
            coAlan.Numero = 4;
            coAlan.Depositar(15000);
            coAlan.Titular.Nome = "Alan";

            this.aConta.Add(coVictor);
            this.aConta.Add(coRafael);
            this.aConta.Add(coFelipe);
            this.aConta.Add(coAlan);

            foreach (Conta conta in aConta)
            {
                cmbContas.Items.Add(conta.Titular);

            }

        }



        private void btnDepositar_Click(object sender, EventArgs e)
        {
            operacao = 1;
            
            txtSaldo.Text = this.OperarEmContas().ToString();
            
        }

        private void btnSacar_Click(object sender, EventArgs e)
        {
            operacao = 2;
            txtSaldo.Text = this.OperarEmContas().ToString();

        }

        private void AtualizarTela(Conta co)
        {

            txtTitular.Text = co.Titular.Nome;
            txtSaldo.Text = co.Saldo.ToString();
            txtNumero.Text = co.Numero.ToString();
        }

        private void cmbContas_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indiceSelecionado = cmbContas.SelectedIndex;
            Conta cselecionada = aConta[indiceSelecionado];


            AtualizarTela(cselecionada);

        }
        private double OperarEmContas()
        {
            
            int indiceSelecionado = cmbContas.SelectedIndex;
            Conta cselecionada = aConta[indiceSelecionado];
            int indiceSelecionadotranferir = cmbDestinoTenferencia.SelectedIndex;
            Conta cselecionadatranferir = aConta[indiceSelecionadotranferir];
            try
            {
                double valor = Convert.ToDouble(txtValor.Text);

                if (operacao == 1)
                {
                    cselecionada.Depositar(valor);

                }
                else if (operacao == 2)
                {
                    cselecionada.Sacar(valor);

                }
                else if (operacao == 3)
                {
                    cselecionada.Transferir(valor, cselecionadatranferir);
                }
            }
            catch (FormatException)
            {

                MessageBox.Show("Digite um número válido");
            }
            catch(SaldoInsuficienteException)
            {
                MessageBox.Show("Saldo Insuficiente. Verifique os valores informados.");
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Verifique os números informados");
            }
            
            AtualizarTela(cselecionada);
            return cselecionada.Saldo;
            
        }

        private void btnTransferir_Click(object sender, EventArgs e)
        {
            operacao = 3;
            this.OperarEmContas();
            txtSaldo.Text = this.OperarEmContas().ToString();


        }

        public void AdicionarConta(Conta conta)
        {
            this.aConta[this.qtdContas] = conta;
            this.qtdContas++;
            cmbContas.Items.Add(conta);
        }

        

        private void btnCadstrar_Click(object sender, EventArgs e)
        {
            CadastroConta cadastro = new CadastroConta(this);
            cadastro.ShowDialog();
        }

        public void RemoverConta(Conta conta)
        {
            cmbContas.Items.Remove(conta);
            int i;
            for (i = 0; i < this.qtdContas; i++)
            {
                if (this.aConta[i] == conta)
                {
                    break;
                }
            }
            while (i + 1 <= this.qtdContas)
            {
                this.aConta[i] = this.aConta[i + 1];
                i++;
            }
        }
    }
}
