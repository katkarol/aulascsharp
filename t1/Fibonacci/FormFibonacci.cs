using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fibonacci
{
    public partial class FormFibonacci : Form
    {
        public FormFibonacci()
        {
            InitializeComponent();
        }

        private void btnFibonacci_Click(object sender, EventArgs e)
        {
            StringBuilder fibonacci = new StringBuilder();
            int natual = 1;
            int nanterior = 0;
            
            while (natual <= 100)
            {
                fibonacci.AppendLine(natual.ToString());
                int nposterior = nanterior + natual;
                nanterior = natual;
                natual = nposterior;
            }
            MessageBox.Show("Os número de fibonacci até 100 é: " + fibonacci);
        }
    }
}
