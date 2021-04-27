using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Exercicio18
{
    public partial class Principal : Form
    {
        List<Conta_Bancaria> listagem = new List<Conta_Bancaria>();
        
        public Principal()
        {
            InitializeComponent();
        }


        private void BtnCcorrente_Click(object sender, EventArgs e)
        {
           
            try
            {
                if (!maskedCC.MaskCompleted)
                {
                    throw new Exception("Conta Invalida!");
                }
                if(rbTalãoS.Checked == false && rbTalãoN.Checked == false)
                {
                    throw new Exception("Possui Talão? (S/N)");

                }
                Conta_Corrente cc = new Conta_Corrente
                {
                    NomeCliente = txtNomeCC.Text,
                    NumerodaConta = maskedCC.Text,
                    
                    LimiteCredito = Convert.ToDouble(LimiteCC.Text),




                };

                if (rbTalãoS.Checked) { cc.UtilizaTalaoCheque = true; }
                else if (rbTalãoN.Checked) { cc.UtilizaTalaoCheque = false; }

                listagem.Add(cc);
                MessageBox.Show("Salvo!");
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.ToString(), "ERRO!", MessageBoxButtons.OK);
            }

            Limpar(this);

        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {

            
            try
            {

                if (!maskedCp.MaskCompleted)
                {
                    throw new Exception("Conta Invalida!");
                }
                if (numericUpDown1.Value > 31)
                {
                    throw new Exception("Dia Invalido!");
                }
               
                Conta_Poupanca cp = new Conta_Poupanca
                {
                    NomeCliente = txtNomeCP.Text,
                    NCCorrenteAtrelada = maskedCp.Text,
                   
                    Diadeaniversario = Convert.ToInt32(numericUpDown1.Value),




                };



                listagem.Add(cp);
                MessageBox.Show("Salvo!");
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.ToString(), "ERRO!", MessageBoxButtons.OK);
            }
            Limpar(this);

        }

        private void BtnSaque_Click(object sender, EventArgs e)
        { //LAMBDA
            try
            {
                Conta_Bancaria pesquisa = listagem.Find(pesquisaconta => pesquisaconta.NumerodaConta == masked.Text);
                if (pesquisa == null)
                {

                    MessageBox.Show("Conta não encontrada!");
                    return;
                }
                else
                {
                    pesquisa.Saque(Convert.ToDouble(txtValor.Text));
                    MessageBox.Show($"Feito, seu novo saldo é de {pesquisa.Saldo}");

                }
            }
            catch(Exception erro)
            {
                MessageBox.Show(erro.ToString());
            }
           
            /*foreach(var consulta in listagem)
            {
                if(consulta.NumerodaConta == masked.Text)
                { 
                    consulta.Saldo -= Convert.ToDouble(txtValor.Text);
                }
                else
                {
                    MessageBox.Show("Conta não encontrada!");
                    return;
                }
            }*/
        }

        private void btnDeposito_Click(object sender, EventArgs e)
        {//LAMBDA
            Conta_Bancaria pesquisa = listagem.Find(pesquisaconta => pesquisaconta.NumerodaConta == masked.Text);
            if (pesquisa == null)
            {

                MessageBox.Show("Conta não encontrada!");
                return;
            }
            else
            {
                pesquisa.Deposito(Convert.ToDouble(txtValor.Text));
                MessageBox.Show($"Feito, seu novo saldo é de {pesquisa.Saldo}");

            }
            /*foreach (var consulta in listagem)
            {
                if (consulta.NumerodaConta == masked.Text)
                {
                    consulta.Saldo += Convert.ToDouble(txtValor.Text);
                }
                else
                {
                    MessageBox.Show("Conta não encontrada!");
                    return;
                }
            }*/
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            Conta_Bancaria pesquisa = listagem.Find(pesquisaconta => pesquisaconta.NumerodaConta == masked.Text);
            if(pesquisa == null)
            {
                MessageBox.Show("Conta não encontrada!");
                return;
            }
           
            InfoCliente relatorio = new InfoCliente(pesquisa.ToString());
            relatorio.Show();
            

        }

        private void masked_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
           foreach(var item in listagem)
            {
                sb.Append(item.ToString() + Environment.NewLine + Environment.NewLine);
            }

            ListagemGeral lg = new ListagemGeral(sb.ToString());
            lg.Show();

        }

        private void LimiteCC_TextChanged(object sender, EventArgs e)
        {

        }

        private void Limpar(Control clean)
        {

            if (clean is TextBoxBase)
            {
                (clean as TextBoxBase).Clear();
            }
            foreach (Control control in clean.Controls)
            {
                Limpar(control);
            }


        }
    }
}
