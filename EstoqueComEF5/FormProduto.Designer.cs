namespace EstoqueComEF5
{
    partial class FormProduto
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
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxCategoria = new System.Windows.Forms.ComboBox();
            this.ndPreco = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.Estoque = new System.Windows.Forms.Label();
            this.ndEstoque = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.ndPreco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ndEstoque)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSalvar.Location = new System.Drawing.Point(242, 138);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 7;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(156, 138);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(12, 26);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(137, 23);
            this.txtNome.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Categoria";
            // 
            // cbxCategoria
            // 
            this.cbxCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCategoria.FormattingEnabled = true;
            this.cbxCategoria.Location = new System.Drawing.Point(158, 86);
            this.cbxCategoria.Name = "cbxCategoria";
            this.cbxCategoria.Size = new System.Drawing.Size(159, 23);
            this.cbxCategoria.Sorted = true;
            this.cbxCategoria.TabIndex = 8;
            // 
            // ndPreco
            // 
            this.ndPreco.DecimalPlaces = 2;
            this.ndPreco.Location = new System.Drawing.Point(182, 27);
            this.ndPreco.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.ndPreco.Name = "ndPreco";
            this.ndPreco.Size = new System.Drawing.Size(120, 23);
            this.ndPreco.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(182, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Preço";
            // 
            // Estoque
            // 
            this.Estoque.AutoSize = true;
            this.Estoque.Location = new System.Drawing.Point(12, 69);
            this.Estoque.Name = "Estoque";
            this.Estoque.Size = new System.Drawing.Size(37, 15);
            this.Estoque.TabIndex = 13;
            this.Estoque.Text = "Preço";
            // 
            // ndEstoque
            // 
            this.ndEstoque.Location = new System.Drawing.Point(12, 87);
            this.ndEstoque.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.ndEstoque.Name = "ndEstoque";
            this.ndEstoque.Size = new System.Drawing.Size(120, 23);
            this.ndEstoque.TabIndex = 12;
            // 
            // FormProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 206);
            this.Controls.Add(this.Estoque);
            this.Controls.Add(this.ndEstoque);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ndPreco);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxCategoria);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Name = "FormProduto";
            this.Text = "Produto";
            ((System.ComponentModel.ISupportInitialize)(this.ndPreco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ndEstoque)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox cbxCategoria;
        public System.Windows.Forms.NumericUpDown ndPreco;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Estoque;
        public System.Windows.Forms.NumericUpDown ndEstoque;
    }
}