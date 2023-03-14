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
    public partial class form : Form
    {
        Produto produtoSelecionado = null;

        public form()
        {
            InitializeComponent();
            grdProdutos.Columns["clmNome"].HeaderCell.Style.Alignment =
                DataGridViewContentAlignment.MiddleLeft;
            grdProdutos.Columns["clmCategoria"].HeaderCell.Style.Alignment =
                DataGridViewContentAlignment.MiddleLeft;
            grdProdutos.DataSource = Produto.Listagem;
            //(grdProdutos.Columns["clmCategoria"] as DataGridViewComboBoxColumn).DataSource =
               // Enum.GetValues(typeof(enCategoria));
        }

        private void grdProdutos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if(e != null)
            {
                if (grdProdutos.Columns[e.ColumnIndex].HeaderText == "Estoque")
                {
                    if(e.Value != null)
                    {
                        double valor = Convert.ToDouble(e.Value);
                        e.Value = valor.ToString("F2");
                        e.FormattingApplied = true;
                        if(valor < 30)
                        {
                            //e.CellStyle.ForeColor = Color.Red;
                            grdProdutos.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Red;
                        }
                    }
                }
            }
        }

        private void grdProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grdProdutos.Columns[e.ColumnIndex].HeaderText == "Excluir")
            {
                if (MessageBox.Show("Deseja realmente excluir este produto?", "Confirmação",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Produto.Listagem.RemoveAt(e.RowIndex);
                }
            }

            else if (grdProdutos.Columns[e.ColumnIndex].HeaderText == "Alterar")
            {
                grdProdutos_MouseDoubleClick(null, null);
            }
        }

        private void grdProdutos_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Delete)
            {
                if(grdProdutos.SelectedRows.Count > 0)
                {
                    if (MessageBox.Show("Deseja realmente excluir este produto?", "Confirmação",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Produto.Listagem.RemoveAt(grdProdutos.SelectedRows[0].Index);
                    }
                }
            }
            else if (e.KeyCode == Keys.Insert) 
            {
                FormProduto formProduto = new FormProduto();
                formProduto.produto = new Produto();
                formProduto.produto.Codigo = Produto.Listagem.Max(p => p.Codigo) + 1;
                formProduto.produto.DataValidade = DateTime.Today.AddDays(90);
                if(formProduto.ShowDialog() == DialogResult.OK)
                {
                    Produto.Listagem.Insert(grdProdutos.Rows.Count, formProduto.produto);

                    MessageBox.Show("Produto incluido com sucesso.", "Informação",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                {
                    MessageBox.Show("Inclusão cancelada.", "Informação",
                        MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                formProduto.Dispose();

            }
        }

        private void grdProdutos_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            DataGridViewRow linhaSelecionada = null;
            if (grdProdutos.SelectedRows.Count > 0)
            {
                linhaSelecionada = grdProdutos.SelectedRows[0];
                produtoSelecionado = linhaSelecionada.DataBoundItem as Produto;
            }

            if(produtoSelecionado != null)
            {
                FormProduto formProduto = new FormProduto();
                formProduto.produto = produtoSelecionado;
                if(formProduto.ShowDialog() == DialogResult.OK)
                {
                    grdProdutos.InvalidateRow(linhaSelecionada.Index);
                    MessageBox.Show("Produto alterado com sucesso.", "Informação",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Alteração cancelada.", "Informação",
                        MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                produtoSelecionado = null;
                formProduto.Dispose();
            }
        }

        private void form_Load(object sender, EventArgs e)
        {
            grdProdutos.Columns["clmExcluir"].DisplayIndex = 8;
            grdProdutos.Columns["clmAlterar"].DisplayIndex = 8;
        }
    }
}
