using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LacosMultiplos
{
    public partial class FormLacos : Form
    {
        public FormLacos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder nnaomultiplos = new StringBuilder();

            for (int i = 1; i <=100; i++)
            {
                if (i%3 == 1)
                {
                    nnaomultiplos.AppendLine(i.ToString());
                }
            }
            MessageBox.Show("Numeros de 1 a 100 que não são multiplos por 3;  \r\n" +  nnaomultiplos );
        }
    }
}
