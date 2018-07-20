using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EditorTexto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists("Texto.txt"))
            {
                Stream stream = File.Open("Texto.txt", FileMode.Open);
                StreamReader leitor = new StreamReader(stream);
                string linha = leitor.ReadToEnd();
                 txtTexto.Text = linha ;


               
                leitor.Close();
                stream.Close();
            }
           

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Stream stream = File.Open("Texto.txt", FileMode.Create);
            StreamWriter escritor = new StreamWriter(stream);
            escritor.Write(txtTexto.Text);

            escritor.Close();
            stream.Close();
            MessageBox.Show("Texto salvo!" );
        }
    }
}
