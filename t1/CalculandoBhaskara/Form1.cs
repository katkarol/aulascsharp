using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculandoBhaskara
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double valorA = Convert.ToInt32(txtValorA.Text);
            double valorB = Convert.ToInt32(txtValorB.Text);
            double valorC = Convert.ToInt32(txtValorC.Text);

            double delta = valorB * valorB - 4 * valorA * valorC;

            double valorA1 = (-valorB + Math.Sqrt(delta)) / 2 * valorA;
            double valorA2 = (-valorB - Math.Sqrt(delta)) / 2 * valorA;

            MessageBox.Show("A1: " + valorA1);
            MessageBox.Show("A2: " + valorA2);
        }
    }
}
