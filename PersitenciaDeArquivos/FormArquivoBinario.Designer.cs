namespace PersitenciaDeArquivos
{
    partial class FormArquivoBinario
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
            this.btnEscrever = new System.Windows.Forms.Button();
            this.btnLer = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnCriarArquivo = new System.Windows.Forms.Button();
            this.lbxLinhas = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnEscrever
            // 
            this.btnEscrever.Location = new System.Drawing.Point(12, 21);
            this.btnEscrever.Name = "btnEscrever";
            this.btnEscrever.Size = new System.Drawing.Size(192, 23);
            this.btnEscrever.TabIndex = 0;
            this.btnEscrever.Text = "Escrever Dados Binários";
            this.btnEscrever.UseVisualStyleBackColor = true;
            this.btnEscrever.Click += new System.EventHandler(this.btnEscrever_Click);
            // 
            // btnLer
            // 
            this.btnLer.Location = new System.Drawing.Point(210, 21);
            this.btnLer.Name = "btnLer";
            this.btnLer.Size = new System.Drawing.Size(176, 23);
            this.btnLer.TabIndex = 1;
            this.btnLer.Text = "Ler Dados Binários";
            this.btnLer.UseVisualStyleBackColor = true;
            this.btnLer.Click += new System.EventHandler(this.btnLer_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(392, 21);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(176, 23);
            this.btnAdicionar.TabIndex = 2;
            this.btnAdicionar.Text = "Adicionar Dados Binários";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnCriarArquivo
            // 
            this.btnCriarArquivo.Location = new System.Drawing.Point(591, 21);
            this.btnCriarArquivo.Name = "btnCriarArquivo";
            this.btnCriarArquivo.Size = new System.Drawing.Size(176, 23);
            this.btnCriarArquivo.TabIndex = 3;
            this.btnCriarArquivo.Text = "Criar Arquivo Texto";
            this.btnCriarArquivo.UseVisualStyleBackColor = true;
            this.btnCriarArquivo.Click += new System.EventHandler(this.btnCriarArquivo_Click);
            // 
            // lbxLinhas
            // 
            this.lbxLinhas.FormattingEnabled = true;
            this.lbxLinhas.ItemHeight = 15;
            this.lbxLinhas.Location = new System.Drawing.Point(12, 50);
            this.lbxLinhas.Name = "lbxLinhas";
            this.lbxLinhas.Size = new System.Drawing.Size(755, 334);
            this.lbxLinhas.TabIndex = 4;
            // 
            // FormArquivoBinario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbxLinhas);
            this.Controls.Add(this.btnCriarArquivo);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.btnLer);
            this.Controls.Add(this.btnEscrever);
            this.Name = "FormArquivoBinario";
            this.Text = "Persistência de dados em Arquivos Binários";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEscrever;
        private System.Windows.Forms.Button btnLer;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnCriarArquivo;
        private System.Windows.Forms.ListBox lbxLinhas;
    }
}