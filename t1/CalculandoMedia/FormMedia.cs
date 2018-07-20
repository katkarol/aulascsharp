using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculandoMedia
{
    public partial class FormMedia : Form
    {
        public FormMedia()
        {
            InitializeComponent();
        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            double i1 = Convert.ToInt32(txtIdade1.Text);
            double i2 = Convert.ToInt32(txtIdade2.Text);
            double i3 = Convert.ToInt32(txtIdade3.Text);

            double media = (i1 + i2 + i3) / 3;
            MessageBox.Show("A idade média é: " + media);
        }
    }
}
