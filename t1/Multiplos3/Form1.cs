using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multiplos3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMultiplos3_Click(object sender, EventArgs e)
        {
            StringBuilder nmultiplos3 = new StringBuilder();
            for (int i = 1; i <= 100; i++)
            {
                if (i%3 == 0)
                {
                    nmultiplos3.AppendLine(i.ToString());
                }
            }
            MessageBox.Show("Os multiplos de 3 são: " + nmultiplos3.ToString());
        }
    }
}
