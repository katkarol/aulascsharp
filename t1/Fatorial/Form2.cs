using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fatorial
{
    public partial class Form2 : System.Windows.Forms.Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnFatorial_Click(object sender, EventArgs e)
        {
            StringBuilder sfatorials = new StringBuilder();
            int fatorial = 1;
            for (int n = 1; n <= 10; n++)
            {
                fatorial *= n;
                sfatorials.AppendLine(n + " ! =  " + fatorial);

            }
            MessageBox.Show(sfatorials.ToString());
        }
    }
}
