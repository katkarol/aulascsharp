using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Operadores
{
    public partial class FormOperadores : Form
    {
        public FormOperadores()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder divis = new StringBuilder();
            if (15 % 3 == 0)
            {
                divis.AppendLine("15 é divisível por 3");

            }
            else
            {
                divis.AppendLine("15 não é divisível por 3");
            }
            if (15 % 4 == 0)
            {
                divis.AppendLine("15 é divisível por 4");

            }
            else
            {
                divis.AppendLine("15 não é divisível por 4");
            }

            if (15 % 3 == 1 || 15 % 4 == 1)
            {
                divis.AppendLine("15 não é divisível nem 3, nem por 4");
            }
            MessageBox.Show(divis.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder numeros3 = new StringBuilder();
            StringBuilder numeros4 = new StringBuilder();

            for (int i = 0; i <= 30; i++)
            {
                if (i % 3 == 0)
                {
                    numeros3.AppendLine(i.ToString());
                }
                if (i % 4 == 0)
                {
                    numeros4.AppendLine(i.ToString());
                }

            }
            MessageBox.Show("Numeros divisíveis por 3 de 0 até 30:\r\n" + numeros3);
            MessageBox.Show("Numeros divisíveis por 4 de 0 até 30:\r\n" + numeros4);
        }
    }
}
