namespace CadastroDeClientes
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cbxClientes = new System.Windows.Forms.ComboBox();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnClick = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtNascimento = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.ndRendaMensal = new System.Windows.Forms.NumericUpDown();
            this.gbEstadoCivil = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbxNacionalidade = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.cbTemFilhos = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtCPF = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ndRendaMensal)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Clientes";
            // 
            // cbxClientes
            // 
            this.cbxClientes.FormattingEnabled = true;
            this.cbxClientes.Location = new System.Drawing.Point(48, 48);
            this.cbxClientes.Name = "cbxClientes";
            this.cbxClientes.Size = new System.Drawing.Size(270, 23);
            this.cbxClientes.TabIndex = 0;
            this.cbxClientes.SelectedIndexChanged += new System.EventHandler(this.cbxClientes_SelectedIndexChanged);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Enabled = false;
            this.btnAlterar.Location = new System.Drawing.Point(324, 47);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(35, 23);
            this.btnAlterar.TabIndex = 1;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnClick
            // 
            this.btnClick.Location = new System.Drawing.Point(365, 47);
            this.btnClick.Name = "btnClick";
            this.btnClick.Size = new System.Drawing.Size(35, 23);
            this.btnClick.TabIndex = 2;
            this.btnClick.Text = "novoCliente";
            this.btnClick.UseVisualStyleBackColor = true;
            this.btnClick.Click += new System.EventHandler(this.btnClick_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Código";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(45, 124);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(49, 23);
            this.txtCodigo.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(123, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nome Completo";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(123, 124);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(150, 23);
            this.txtNome.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(300, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "CPF";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Data de Nascimento";
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Location = new System.Drawing.Point(45, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(355, 1);
            this.label6.TabIndex = 11;
            // 
            // dtNascimento
            // 
            this.dtNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNascimento.Location = new System.Drawing.Point(48, 184);
            this.dtNascimento.Name = "dtNascimento";
            this.dtNascimento.Size = new System.Drawing.Size(111, 23);
            this.dtNascimento.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(177, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Renda Mensal";
            // 
            // ndRendaMensal
            // 
            this.ndRendaMensal.Location = new System.Drawing.Point(177, 184);
            this.ndRendaMensal.Name = "ndRendaMensal";
            this.ndRendaMensal.Size = new System.Drawing.Size(96, 23);
            this.ndRendaMensal.TabIndex = 7;
            // 
            // gbEstadoCivil
            // 
            this.gbEstadoCivil.Location = new System.Drawing.Point(300, 166);
            this.gbEstadoCivil.Name = "gbEstadoCivil";
            this.gbEstadoCivil.Size = new System.Drawing.Size(100, 108);
            this.gbEstadoCivil.TabIndex = 8;
            this.gbEstadoCivil.TabStop = false;
            this.gbEstadoCivil.Text = "Estado Civil";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(45, 233);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 15);
            this.label8.TabIndex = 16;
            this.label8.Text = "Nacionalidade";
            // 
            // cbxNacionalidade
            // 
            this.cbxNacionalidade.FormattingEnabled = true;
            this.cbxNacionalidade.Location = new System.Drawing.Point(45, 251);
            this.cbxNacionalidade.Name = "cbxNacionalidade";
            this.cbxNacionalidade.Size = new System.Drawing.Size(114, 23);
            this.cbxNacionalidade.Sorted = true;
            this.cbxNacionalidade.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(175, 233);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 15);
            this.label9.TabIndex = 18;
            this.label9.Text = "Placa do Veículo";
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(178, 251);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(95, 23);
            this.txtPlaca.TabIndex = 10;
            // 
            // cbTemFilhos
            // 
            this.cbTemFilhos.AutoSize = true;
            this.cbTemFilhos.Checked = true;
            this.cbTemFilhos.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.cbTemFilhos.Location = new System.Drawing.Point(45, 309);
            this.cbTemFilhos.Name = "cbTemFilhos";
            this.cbTemFilhos.Size = new System.Drawing.Size(80, 19);
            this.cbTemFilhos.TabIndex = 11;
            this.cbTemFilhos.Text = "Tem filhos";
            this.cbTemFilhos.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Location = new System.Drawing.Point(45, 345);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(355, 1);
            this.label10.TabIndex = 11;
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(45, 364);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(63, 23);
            this.btnFechar.TabIndex = 12;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(255, 364);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(63, 23);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(337, 364);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(63, 23);
            this.btnSalvar.TabIndex = 14;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(300, 122);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(100, 23);
            this.txtCPF.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.cbTemFilhos);
            this.Controls.Add(this.txtPlaca);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbxNacionalidade);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.gbEstadoCivil);
            this.Controls.Add(this.ndRendaMensal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtNascimento);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnClick);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.cbxClientes);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ndRendaMensal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxClientes;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnClick;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtNascimento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown ndRendaMensal;
        private System.Windows.Forms.GroupBox gbEstadoCivil;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbxNacionalidade;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.CheckBox cbTemFilhos;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.MaskedTextBox mtbCPF;
        private System.Windows.Forms.TextBox txtCPF;
    }
}
