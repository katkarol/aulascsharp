using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soma1a1000
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            int soma = 0;
            for (int i = 1; i <= 1000; i++)
            {
                soma += i;
            }
            MessageBox.Show("A soma dos números de 1 a 1000 é: " + soma);
        }
    }
}
