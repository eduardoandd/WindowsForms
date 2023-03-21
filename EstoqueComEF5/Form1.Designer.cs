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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAddCategoria = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.cbxCategoria = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAlterarGrd = new System.Windows.Forms.Button();
            this.btnExcluirGrd = new System.Windows.Forms.Button();
            this.btnAddGrd = new System.Windows.Forms.Button();
            this.grdCategoria = new System.Windows.Forms.DataGridView();
            this.clmCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPreco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEstoque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdCategoria)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddCategoria
            // 
            this.btnAddCategoria.Location = new System.Drawing.Point(188, 35);
            this.btnAddCategoria.Name = "btnAddCategoria";
            this.btnAddCategoria.Size = new System.Drawing.Size(36, 23);
            this.btnAddCategoria.TabIndex = 1;
            this.btnAddCategoria.Text = "Add";
            this.btnAddCategoria.UseVisualStyleBackColor = true;
            this.btnAddCategoria.Click += new System.EventHandler(this.btnAddCategoria_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(272, 36);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(36, 23);
            this.btnExcluir.TabIndex = 3;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(230, 35);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(36, 23);
            this.btnAlterar.TabIndex = 2;
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
            this.cbxCategoria.TabIndex = 0;
            this.cbxCategoria.SelectedIndexChanged += new System.EventHandler(this.cbxCategoria_SelectedIndexChanged);
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
            this.btnAlterarGrd.Location = new System.Drawing.Point(321, 97);
            this.btnAlterarGrd.Name = "btnAlterarGrd";
            this.btnAlterarGrd.Size = new System.Drawing.Size(36, 23);
            this.btnAlterarGrd.TabIndex = 5;
            this.btnAlterarGrd.Text = "Alterar";
            this.btnAlterarGrd.UseVisualStyleBackColor = true;
            this.btnAlterarGrd.Click += new System.EventHandler(this.btnAlterarGrd_Click);
            // 
            // btnExcluirGrd
            // 
            this.btnExcluirGrd.Location = new System.Drawing.Point(363, 98);
            this.btnExcluirGrd.Name = "btnExcluirGrd";
            this.btnExcluirGrd.Size = new System.Drawing.Size(36, 23);
            this.btnExcluirGrd.TabIndex = 6;
            this.btnExcluirGrd.Text = "Exclui";
            this.btnExcluirGrd.UseVisualStyleBackColor = true;
            this.btnExcluirGrd.Click += new System.EventHandler(this.btnExcluirGrd_Click);
            // 
            // btnAddGrd
            // 
            this.btnAddGrd.Location = new System.Drawing.Point(279, 97);
            this.btnAddGrd.Name = "btnAddGrd";
            this.btnAddGrd.Size = new System.Drawing.Size(36, 23);
            this.btnAddGrd.TabIndex = 4;
            this.btnAddGrd.Text = "Ad";
            this.btnAddGrd.UseVisualStyleBackColor = true;
            this.btnAddGrd.Click += new System.EventHandler(this.btnAddGrd_Click);
            // 
            // grdCategoria
            // 
            this.grdCategoria.AllowUserToAddRows = false;
            this.grdCategoria.AllowUserToDeleteRows = false;
            this.grdCategoria.AllowUserToResizeColumns = false;
            this.grdCategoria.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdCategoria.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCategoria.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCodigo,
            this.clmNome,
            this.clmPreco,
            this.clmEstoque});
            this.grdCategoria.Location = new System.Drawing.Point(12, 128);
            this.grdCategoria.Name = "grdCategoria";
            this.grdCategoria.ReadOnly = true;
            this.grdCategoria.RowHeadersVisible = false;
            this.grdCategoria.RowTemplate.Height = 25;
            this.grdCategoria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdCategoria.Size = new System.Drawing.Size(386, 215);
            this.grdCategoria.TabIndex = 7;
            this.grdCategoria.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdCategoria_CellDoubleClick);
            // 
            // clmCodigo
            // 
            this.clmCodigo.DataPropertyName = "iDpRODUTO";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Format = "D4";
            this.clmCodigo.DefaultCellStyle = dataGridViewCellStyle2;
            this.clmCodigo.HeaderText = "Codigo";
            this.clmCodigo.Name = "clmCodigo";
            this.clmCodigo.ReadOnly = true;
            this.clmCodigo.Width = 70;
            // 
            // clmNome
            // 
            this.clmNome.DataPropertyName = "Nome";
            this.clmNome.HeaderText = "Nome do Produto";
            this.clmNome.Name = "clmNome";
            this.clmNome.ReadOnly = true;
            this.clmNome.Width = 150;
            // 
            // clmPreco
            // 
            this.clmPreco.DataPropertyName = "Preco";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Format = "C2";
            this.clmPreco.DefaultCellStyle = dataGridViewCellStyle3;
            this.clmPreco.HeaderText = "Preço";
            this.clmPreco.Name = "clmPreco";
            this.clmPreco.ReadOnly = true;
            this.clmPreco.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clmPreco.Width = 80;
            // 
            // clmEstoque
            // 
            this.clmEstoque.DataPropertyName = "Estoque";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Format = "D4";
            this.clmEstoque.DefaultCellStyle = dataGridViewCellStyle4;
            this.clmEstoque.HeaderText = "Estoque";
            this.clmEstoque.Name = "clmEstoque";
            this.clmEstoque.ReadOnly = true;
            this.clmEstoque.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clmEstoque.Width = 70;
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
            this.ClientSize = new System.Drawing.Size(470, 353);
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
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPreco;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEstoque;
    }
}
