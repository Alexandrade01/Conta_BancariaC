
namespace Exercicio18
{
    partial class Principal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LimiteCC = new System.Windows.Forms.TextBox();
            this.maskedCC = new System.Windows.Forms.MaskedTextBox();
            this.saldoCC = new System.Windows.Forms.TextBox();
            this.txtNomeCC = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbTalãoN = new System.Windows.Forms.RadioButton();
            this.rbTalãoS = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCcorrente = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.maskedCp = new System.Windows.Forms.MaskedTextBox();
            this.SaldoCP = new System.Windows.Forms.TextBox();
            this.txtNomeCP = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnCadastro = new System.Windows.Forms.Button();
            this.btnSaque = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnInfo = new System.Windows.Forms.Button();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.masked = new System.Windows.Forms.MaskedTextBox();
            this.btnDeposito = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnListar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox1.Controls.Add(this.LimiteCC);
            this.groupBox1.Controls.Add(this.maskedCC);
            this.groupBox1.Controls.Add(this.saldoCC);
            this.groupBox1.Controls.Add(this.txtNomeCC);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnCcorrente);
            this.groupBox1.Location = new System.Drawing.Point(17, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 400);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CCorrente";
            // 
            // LimiteCC
            // 
            this.LimiteCC.Location = new System.Drawing.Point(155, 182);
            this.LimiteCC.Name = "LimiteCC";
            this.LimiteCC.Size = new System.Drawing.Size(111, 23);
            this.LimiteCC.TabIndex = 4;
            this.LimiteCC.TextChanged += new System.EventHandler(this.LimiteCC_TextChanged);
            // 
            // maskedCC
            // 
            this.maskedCC.Location = new System.Drawing.Point(216, 78);
            this.maskedCC.Mask = "0000-0";
            this.maskedCC.Name = "maskedCC";
            this.maskedCC.Size = new System.Drawing.Size(49, 23);
            this.maskedCC.TabIndex = 2;
            // 
            // saldoCC
            // 
            this.saldoCC.Location = new System.Drawing.Point(155, 129);
            this.saldoCC.Name = "saldoCC";
            this.saldoCC.ReadOnly = true;
            this.saldoCC.Size = new System.Drawing.Size(111, 23);
            this.saldoCC.TabIndex = 3;
            // 
            // txtNomeCC
            // 
            this.txtNomeCC.Location = new System.Drawing.Point(155, 22);
            this.txtNomeCC.Name = "txtNomeCC";
            this.txtNomeCC.Size = new System.Drawing.Size(111, 23);
            this.txtNomeCC.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbTalãoN);
            this.groupBox2.Controls.Add(this.rbTalãoS);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(10, 221);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(192, 93);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // rbTalãoN
            // 
            this.rbTalãoN.AutoSize = true;
            this.rbTalãoN.Location = new System.Drawing.Point(91, 57);
            this.rbTalãoN.Name = "rbTalãoN";
            this.rbTalãoN.Size = new System.Drawing.Size(51, 19);
            this.rbTalãoN.TabIndex = 7;
            this.rbTalãoN.TabStop = true;
            this.rbTalãoN.Text = "NÃO";
            this.rbTalãoN.UseVisualStyleBackColor = true;
            // 
            // rbTalãoS
            // 
            this.rbTalãoS.AutoSize = true;
            this.rbTalãoS.Location = new System.Drawing.Point(6, 57);
            this.rbTalãoS.Name = "rbTalãoS";
            this.rbTalãoS.Size = new System.Drawing.Size(45, 19);
            this.rbTalãoS.TabIndex = 6;
            this.rbTalãoS.TabStop = true;
            this.rbTalãoS.Text = "SIM";
            this.rbTalãoS.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(6, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 21);
            this.label5.TabIndex = 5;
            this.label5.Text = "Utiliza Talão";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(10, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Limite de crédito";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(10, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Saldo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(10, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Numero da Conta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(10, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome";
            // 
            // btnCcorrente
            // 
            this.btnCcorrente.Location = new System.Drawing.Point(38, 339);
            this.btnCcorrente.Name = "btnCcorrente";
            this.btnCcorrente.Size = new System.Drawing.Size(164, 25);
            this.btnCcorrente.TabIndex = 5;
            this.btnCcorrente.Text = "Cadastrar";
            this.btnCcorrente.UseVisualStyleBackColor = true;
            this.btnCcorrente.Click += new System.EventHandler(this.BtnCcorrente_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.DarkOrange;
            this.groupBox3.Controls.Add(this.numericUpDown1);
            this.groupBox3.Controls.Add(this.maskedCp);
            this.groupBox3.Controls.Add(this.SaldoCP);
            this.groupBox3.Controls.Add(this.txtNomeCP);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.btnCadastro);
            this.groupBox3.Location = new System.Drawing.Point(314, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(272, 400);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Conta Poupança";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(155, 181);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(109, 23);
            this.numericUpDown1.TabIndex = 9;
            // 
            // maskedCp
            // 
            this.maskedCp.Location = new System.Drawing.Point(216, 78);
            this.maskedCp.Mask = "0000-0";
            this.maskedCp.Name = "maskedCp";
            this.maskedCp.Size = new System.Drawing.Size(49, 23);
            this.maskedCp.TabIndex = 7;
            // 
            // SaldoCP
            // 
            this.SaldoCP.Location = new System.Drawing.Point(155, 129);
            this.SaldoCP.Name = "SaldoCP";
            this.SaldoCP.ReadOnly = true;
            this.SaldoCP.Size = new System.Drawing.Size(111, 23);
            this.SaldoCP.TabIndex = 8;
            // 
            // txtNomeCP
            // 
            this.txtNomeCP.Location = new System.Drawing.Point(155, 22);
            this.txtNomeCP.Name = "txtNomeCP";
            this.txtNomeCP.Size = new System.Drawing.Size(111, 23);
            this.txtNomeCP.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(10, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 21);
            this.label7.TabIndex = 4;
            this.label7.Text = "Dia do Aniversario";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(10, 131);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 21);
            this.label8.TabIndex = 3;
            this.label8.Text = "Saldo";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(10, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 21);
            this.label9.TabIndex = 2;
            this.label9.Text = "Conta Corrente";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(10, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 21);
            this.label10.TabIndex = 1;
            this.label10.Text = "Nome";
            // 
            // btnCadastro
            // 
            this.btnCadastro.Location = new System.Drawing.Point(38, 339);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(164, 25);
            this.btnCadastro.TabIndex = 10;
            this.btnCadastro.Text = "Cadastrar";
            this.btnCadastro.UseVisualStyleBackColor = true;
            this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click);
            // 
            // btnSaque
            // 
            this.btnSaque.Location = new System.Drawing.Point(31, 114);
            this.btnSaque.Name = "btnSaque";
            this.btnSaque.Size = new System.Drawing.Size(70, 50);
            this.btnSaque.TabIndex = 13;
            this.btnSaque.Text = "Saque";
            this.btnSaque.UseVisualStyleBackColor = true;
            this.btnSaque.Click += new System.EventHandler(this.BtnSaque_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnInfo);
            this.groupBox4.Controls.Add(this.txtValor);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.masked);
            this.groupBox4.Controls.Add(this.btnDeposito);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.btnSaque);
            this.groupBox4.Location = new System.Drawing.Point(612, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(210, 225);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Saque e Depósito";
            // 
            // btnInfo
            // 
            this.btnInfo.Location = new System.Drawing.Point(22, 184);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(164, 25);
            this.btnInfo.TabIndex = 15;
            this.btnInfo.Text = "Exibir Informações";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(75, 78);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(111, 23);
            this.txtValor.TabIndex = 12;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(6, 80);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 21);
            this.label11.TabIndex = 11;
            this.label11.Text = "Valor";
            // 
            // masked
            // 
            this.masked.Location = new System.Drawing.Point(137, 33);
            this.masked.Mask = "0000-0";
            this.masked.Name = "masked";
            this.masked.Size = new System.Drawing.Size(49, 23);
            this.masked.TabIndex = 11;
            this.masked.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.masked_MaskInputRejected);
            // 
            // btnDeposito
            // 
            this.btnDeposito.Location = new System.Drawing.Point(116, 114);
            this.btnDeposito.Name = "btnDeposito";
            this.btnDeposito.Size = new System.Drawing.Size(70, 50);
            this.btnDeposito.TabIndex = 14;
            this.btnDeposito.Text = "Depósito";
            this.btnDeposito.UseVisualStyleBackColor = true;
            this.btnDeposito.Click += new System.EventHandler(this.btnDeposito_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(6, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 21);
            this.label6.TabIndex = 11;
            this.label6.Text = "Conta Corrente";
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(634, 240);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(164, 49);
            this.btnListar.TabIndex = 16;
            this.btnListar.Text = "Lista Tudo";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 406);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "Principal";
            this.Text = "Main Menu";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCcorrente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbTalãoN;
        private System.Windows.Forms.RadioButton rbTalãoS;
        private System.Windows.Forms.MaskedTextBox maskedCC;
        private System.Windows.Forms.TextBox saldoCC;
        private System.Windows.Forms.TextBox txtNomeCC;
        private System.Windows.Forms.TextBox LimiteCC;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.MaskedTextBox maskedCp;
        private System.Windows.Forms.TextBox SaldoCP;
        private System.Windows.Forms.TextBox txtNomeCP;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnCadastro;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btnSaque;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MaskedTextBox masked;
        private System.Windows.Forms.Button btnDeposito;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button btnListar;
    }
}