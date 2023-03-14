namespace ComponentesVisuais
{
    partial class form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grdProdutos = new System.Windows.Forms.DataGridView();
            this.clmImagemProduto = new System.Windows.Forms.DataGridViewImageColumn();
            this.clmCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEstoque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDataValidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPromoção = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clmCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmExcluir = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clmAlterar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // grdProdutos
            // 
            this.grdProdutos.AllowUserToAddRows = false;
            this.grdProdutos.AllowUserToResizeColumns = false;
            this.grdProdutos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            this.grdProdutos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grdProdutos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdProdutos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grdProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmImagemProduto,
            this.clmCodigo,
            this.clmNome,
            this.clmEstoque,
            this.clmDataValidade,
            this.clmPromoção,
            this.clmCategoria,
            this.clmExcluir,
            this.clmAlterar});
            this.grdProdutos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdProdutos.Location = new System.Drawing.Point(10, 10);
            this.grdProdutos.MultiSelect = false;
            this.grdProdutos.Name = "grdProdutos";
            this.grdProdutos.ReadOnly = true;
            this.grdProdutos.RowTemplate.Height = 64;
            this.grdProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdProdutos.Size = new System.Drawing.Size(838, 295);
            this.grdProdutos.TabIndex = 0;
            this.grdProdutos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdProdutos_CellContentClick);
            this.grdProdutos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.grdProdutos_CellFormatting);
            this.grdProdutos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grdProdutos_KeyDown);
            this.grdProdutos.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.grdProdutos_MouseDoubleClick);
            // 
            // clmImagemProduto
            // 
            this.clmImagemProduto.DataPropertyName = "ImagemProduto";
            this.clmImagemProduto.HeaderText = "Imagem";
            this.clmImagemProduto.Name = "clmImagemProduto";
            this.clmImagemProduto.ReadOnly = true;
            this.clmImagemProduto.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmImagemProduto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.clmImagemProduto.Width = 64;
            // 
            // clmCodigo
            // 
            this.clmCodigo.DataPropertyName = "Codigo";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Format = "D6";
            this.clmCodigo.DefaultCellStyle = dataGridViewCellStyle3;
            this.clmCodigo.HeaderText = "Codigo ";
            this.clmCodigo.MaxInputLength = 6;
            this.clmCodigo.Name = "clmCodigo";
            this.clmCodigo.ReadOnly = true;
            this.clmCodigo.Width = 85;
            // 
            // clmNome
            // 
            this.clmNome.DataPropertyName = "Nome";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.clmNome.DefaultCellStyle = dataGridViewCellStyle4;
            this.clmNome.HeaderText = "Nome";
            this.clmNome.Name = "clmNome";
            this.clmNome.ReadOnly = true;
            this.clmNome.Width = 130;
            // 
            // clmEstoque
            // 
            this.clmEstoque.DataPropertyName = "Estoque";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clmEstoque.DefaultCellStyle = dataGridViewCellStyle5;
            this.clmEstoque.HeaderText = "Estoque";
            this.clmEstoque.Name = "clmEstoque";
            this.clmEstoque.ReadOnly = true;
            this.clmEstoque.Width = 85;
            // 
            // clmDataValidade
            // 
            this.clmDataValidade.DataPropertyName = "DataValidade";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clmDataValidade.DefaultCellStyle = dataGridViewCellStyle6;
            this.clmDataValidade.HeaderText = "Validade";
            this.clmDataValidade.Name = "clmDataValidade";
            this.clmDataValidade.ReadOnly = true;
            this.clmDataValidade.Width = 85;
            // 
            // clmPromoção
            // 
            this.clmPromoção.DataPropertyName = "EmPromocao";
            this.clmPromoção.HeaderText = "Promoção";
            this.clmPromoção.Name = "clmPromoção";
            this.clmPromoção.ReadOnly = true;
            this.clmPromoção.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmPromoção.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.clmPromoção.Width = 85;
            // 
            // clmCategoria
            // 
            this.clmCategoria.DataPropertyName = "Categoria";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle7.NullValue = "0";
            this.clmCategoria.DefaultCellStyle = dataGridViewCellStyle7;
            this.clmCategoria.HeaderText = "Categoria";
            this.clmCategoria.Name = "clmCategoria";
            this.clmCategoria.ReadOnly = true;
            this.clmCategoria.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // clmExcluir
            // 
            this.clmExcluir.HeaderText = "Excluir";
            this.clmExcluir.Name = "clmExcluir";
            this.clmExcluir.ReadOnly = true;
            this.clmExcluir.Text = "Excluir";
            this.clmExcluir.UseColumnTextForButtonValue = true;
            this.clmExcluir.Width = 80;
            // 
            // clmAlterar
            // 
            this.clmAlterar.HeaderText = "Alterar";
            this.clmAlterar.Name = "clmAlterar";
            this.clmAlterar.ReadOnly = true;
            this.clmAlterar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clmAlterar.Text = "Alterar";
            this.clmAlterar.UseColumnTextForButtonValue = true;
            this.clmAlterar.Width = 80;
            // 
            // form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 315);
            this.Controls.Add(this.grdProdutos);
            this.Name = "form";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdProdutos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdProdutos;
        private System.Windows.Forms.DataGridViewImageColumn clmImagemProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEstoque;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDataValidade;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clmPromoção;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCategoria;
        private System.Windows.Forms.DataGridViewButtonColumn clmExcluir;
        private System.Windows.Forms.DataGridViewButtonColumn clmAlterar;
    }
}
