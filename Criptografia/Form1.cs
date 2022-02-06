using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Criptografia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void brnEncriptografar_Click(object sender, EventArgs e)
        {
            int chave1 = Convert.ToInt32(numericUpDownChave1.Value);
            int chave2 = Convert.ToInt32(numericUpDownChave2.Value);

            txtResultado.Text = Criptografia.Encriptografar(txtTexto.Text, chave1, chave2);
        }

        private void brnDescriptografar_Click(object sender, EventArgs e)
        {
            int chave1 = Convert.ToInt32(numericUpDownChave1.Value);
            int chave2 = Convert.ToInt32(numericUpDownChave2.Value);

            txtResultado.Text = Criptografia.Descriptografar(txtTexto.Text, chave1, chave2);
        }
    }
}
