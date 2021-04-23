using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Exercicio18
{
    public partial class ListagemGeral : Form
    {
        public ListagemGeral()
        {
            InitializeComponent();
        }
        public ListagemGeral(object texto)
        {
            InitializeComponent();
            textBox1.Text = texto.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals(""))
            {
                MessageBox.Show("Lista vazia", "Erro", MessageBoxButtons.OK);
            }
        }
    }
}
