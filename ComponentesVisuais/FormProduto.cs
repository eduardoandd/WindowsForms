using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ComponentesVisuais.Produto;

namespace ComponentesVisuais
{
    public partial class FormProduto : Form
    {




        public Produto produto = null;
        public FormProduto()
        {
            InitializeComponent();
            cbxCategoria.DataSource = Enum.GetValues(typeof(enCategoria));
           
        }

        private void FormProduto_Load(object sender, EventArgs e)
        {
            txtCodigo.ReadOnly = true;
            txtCodigo.Text = produto.Codigo.ToString();
            txtNome.Text = produto.Nome;
            txtEstoque.Text = produto.Estoque.ToString("F2");
            dtpData.Value = produto.DataValidade;
            cbxCategoria.SelectedText = produto.Categoria.ToString();
            cbPromoção.Checked = produto.Empromocao;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            
            produto.Codigo = Convert.ToInt32(txtCodigo.Text);
            produto.Nome = txtNome.Text;
            produto.Estoque = Convert.ToDouble(txtEstoque.Text);
            produto.DataValidade = dtpData.Value;
            produto.Categoria = (enCategoria)cbxCategoria.SelectedIndex;
            produto.Empromocao = cbPromoção.Checked;        
        }

       
    }
}
