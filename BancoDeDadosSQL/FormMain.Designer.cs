namespace BancoDeDadosSQL
{
    partial class FormMain
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
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnAtualizarExibir = new System.Windows.Forms.Button();
            this.btnConsultaLimiteMedio = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnLer = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnCriar = new System.Windows.Forms.Button();
            this.nd = new System.Windows.Forms.NumericUpDown();
            this.grdClientes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.nd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(28, 207);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(101, 24);
            this.btnConsultar.TabIndex = 3;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            // 
            // btnAtualizarExibir
            // 
            this.btnAtualizarExibir.Location = new System.Drawing.Point(24, 344);
            this.btnAtualizarExibir.Name = "btnAtualizarExibir";
            this.btnAtualizarExibir.Size = new System.Drawing.Size(105, 42);
            this.btnAtualizarExibir.TabIndex = 4;
            this.btnAtualizarExibir.Text = "Atualia e Exibir";
            this.btnAtualizarExibir.UseVisualStyleBackColor = true;
            // 
            // btnConsultaLimiteMedio
            // 
            this.btnConsultaLimiteMedio.Location = new System.Drawing.Point(24, 295);
            this.btnConsultaLimiteMedio.Name = "btnConsultaLimiteMedio";
            this.btnConsultaLimiteMedio.Size = new System.Drawing.Size(105, 43);
            this.btnConsultaLimiteMedio.TabIndex = 5;
            this.btnConsultaLimiteMedio.Text = "Consultar Limite Médio";
            this.btnConsultaLimiteMedio.UseVisualStyleBackColor = true;
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(28, 87);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(101, 24);
            this.btnInserir.TabIndex = 7;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnLer
            // 
            this.btnLer.Location = new System.Drawing.Point(28, 117);
            this.btnLer.Name = "btnLer";
            this.btnLer.Size = new System.Drawing.Size(101, 24);
            this.btnLer.TabIndex = 8;
            this.btnLer.Text = "Ler";
            this.btnLer.UseVisualStyleBackColor = true;
            this.btnLer.Click += new System.EventHandler(this.btnLer_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(28, 147);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(101, 24);
            this.btnAtualizar.TabIndex = 9;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(28, 177);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(101, 24);
            this.btnExcluir.TabIndex = 10;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnCriar
            // 
            this.btnCriar.Location = new System.Drawing.Point(28, 57);
            this.btnCriar.Name = "btnCriar";
            this.btnCriar.Size = new System.Drawing.Size(101, 24);
            this.btnCriar.TabIndex = 11;
            this.btnCriar.Text = "Criar";
            this.btnCriar.UseVisualStyleBackColor = true;
            this.btnCriar.Click += new System.EventHandler(this.btnCriar_Click);
            // 
            // nd
            // 
            this.nd.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nd.Location = new System.Drawing.Point(28, 246);
            this.nd.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nd.Name = "nd";
            this.nd.Size = new System.Drawing.Size(120, 23);
            this.nd.TabIndex = 12;
            this.nd.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // grdClientes
            // 
            this.grdClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdClientes.Location = new System.Drawing.Point(163, 46);
            this.grdClientes.Name = "grdClientes";
            this.grdClientes.RowTemplate.Height = 25;
            this.grdClientes.Size = new System.Drawing.Size(605, 353);
            this.grdClientes.TabIndex = 13;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grdClientes);
            this.Controls.Add(this.nd);
            this.Controls.Add(this.btnCriar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnLer);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.btnConsultaLimiteMedio);
            this.Controls.Add(this.btnAtualizarExibir);
            this.Controls.Add(this.btnConsultar);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnAtualizarExibir;
        private System.Windows.Forms.Button btnConsultaLimiteMedio;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnLer;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnCriar;
        private System.Windows.Forms.NumericUpDown nd;
        private System.Windows.Forms.DataGridView grdClientes;
    }
}
