using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Votando
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVotar_Click(object sender, EventArgs e)
        {
            int idade = Convert.ToInt32(txtIdade.Text);
            bool brasileira = ckBrasileiro.Checked;

            if (idade < 16 && !brasileira)
            {
                MessageBox.Show("Você não pode votar!");

            }
            else
            {
                MessageBox.Show("Voto computado com sucesso!");
            }
        }
    }
}
