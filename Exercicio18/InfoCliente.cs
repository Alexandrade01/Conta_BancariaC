using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Exercicio18
{
    public partial class InfoCliente : Form
    {
        public InfoCliente()
        {
            InitializeComponent();
        }

        public InfoCliente(string texto)
        {
            InitializeComponent();
            textBox1.Text = texto;
        }

        private void InfoCliente_Load(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Lista vazia", "Erro!", MessageBoxButtons.OK);
            }
        }
    }
}
