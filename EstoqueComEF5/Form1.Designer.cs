namespace EstoqueComEF5
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
            this.btnAddCategoria = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.cbxCategoria = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAlterarGrd = new System.Windows.Forms.Button();
            this.btnExcluirGrd = new System.Windows.Forms.Button();
            this.btnAddGrd = new System.Windows.Forms.Button();
            this.grdCategoria = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdCategoria)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddCategoria
            // 
            this.btnAddCategoria.Location = new System.Drawing.Point(188, 35);
            this.btnAddCategoria.Name = "btnAddCategoria";
            this.btnAddCategoria.Size = new System.Drawing.Size(36, 23);
            this.btnAddCategoria.TabIndex = 0;
            this.btnAddCategoria.Text = "Add";
            this.btnAddCategoria.UseVisualStyleBackColor = true;
            this.btnAddCategoria.Click += new System.EventHandler(this.btnAddCategoria_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(272, 36);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(36, 23);
            this.btnExcluir.TabIndex = 4;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(230, 35);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(36, 23);
            this.btnAlterar.TabIndex = 5;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // cbxCategoria
            // 
            this.cbxCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCategoria.FormattingEnabled = true;
            this.cbxCategoria.Location = new System.Drawing.Point(12, 36);
            this.cbxCategoria.Name = "cbxCategoria";
            this.cbxCategoria.Size = new System.Drawing.Size(159, 23);
            this.cbxCategoria.Sorted = true;
            this.cbxCategoria.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Categoria";
            // 
            // btnAlterarGrd
            // 
            this.btnAlterarGrd.Location = new System.Drawing.Point(551, 97);
            this.btnAlterarGrd.Name = "btnAlterarGrd";
            this.btnAlterarGrd.Size = new System.Drawing.Size(36, 23);
            this.btnAlterarGrd.TabIndex = 10;
            this.btnAlterarGrd.Text = "Alterar";
            this.btnAlterarGrd.UseVisualStyleBackColor = true;
            // 
            // btnExcluirGrd
            // 
            this.btnExcluirGrd.Location = new System.Drawing.Point(593, 98);
            this.btnExcluirGrd.Name = "btnExcluirGrd";
            this.btnExcluirGrd.Size = new System.Drawing.Size(36, 23);
            this.btnExcluirGrd.TabIndex = 9;
            this.btnExcluirGrd.Text = "Exclui";
            this.btnExcluirGrd.UseVisualStyleBackColor = true;
            // 
            // btnAddGrd
            // 
            this.btnAddGrd.Location = new System.Drawing.Point(509, 97);
            this.btnAddGrd.Name = "btnAddGrd";
            this.btnAddGrd.Size = new System.Drawing.Size(36, 23);
            this.btnAddGrd.TabIndex = 8;
            this.btnAddGrd.Text = "Ad";
            this.btnAddGrd.UseVisualStyleBackColor = true;
            // 
            // grdCategoria
            // 
            this.grdCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCategoria.Location = new System.Drawing.Point(12, 128);
            this.grdCategoria.Name = "grdCategoria";
            this.grdCategoria.RowTemplate.Height = 25;
            this.grdCategoria.Size = new System.Drawing.Size(622, 215);
            this.grdCategoria.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Produtos da Categoria Selecionada";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grdCategoria);
            this.Controls.Add(this.btnAlterarGrd);
            this.Controls.Add(this.btnExcluirGrd);
            this.Controls.Add(this.btnAddGrd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxCategoria);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAddCategoria);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.grdCategoria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddCategoria;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAlterarGrd;
        private System.Windows.Forms.Button btnExcluirGrd;
        private System.Windows.Forms.Button btnAddGrd;
        private System.Windows.Forms.DataGridView grdCategoria;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox cbxCategoria;
    }
}
