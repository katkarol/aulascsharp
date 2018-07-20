using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculandoImposto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double valorNotaFiscal = Convert.ToDouble(txtValorNotaFiscal.Text);

            if (valorNotaFiscal < 1000)
            {
                valorNotaFiscal *= 0.2;
            }
            else if (valorNotaFiscal < 3000)
            {
                valorNotaFiscal *= 0.25;
            }
            else if (valorNotaFiscal < 7000)
            {
                valorNotaFiscal *= 0.28;
            }
            else
            {
                valorNotaFiscal *= 0.3;
            }
            MessageBox.Show(valorNotaFiscal.ToString());
        }
    }
}
