using EstoqueComEF5.Models;
using MessageUtils;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstoqueComEF5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            
        }

        private void AtualizarCategoria(EstoqueContext db)
        {

            cbxCategoria.DataSource = db.Categorias.ToList();
            cbxCategoria.DisplayMember = "Nome";
            cbxCategoria.ValueMember = "IdCategoria";
        }

        private void AtualizarProdutos(EstoqueContext db)
        {
            if(cbxCategoria.Items.Count > 0)
            {
                this.Cursor = Cursors.WaitCursor;

                int idCategoria = (cbxCategoria.SelectedItem as Categoria).IdCategoria; //capturando o id do objeto categoria
                grdCategoria.DataSource = db.Produtos.
                    Where(x => x.IdCategoria == idCategoria).
                    Include(x => x.Categoria).ToList();
                grdCategoria.Columns.Remove(grdCategoria.Columns["IdCategoria"]);
                grdCategoria.Columns.Remove(grdCategoria.Columns["Categoria"]);
                grdCategoria.Columns["clmCodigo"].HeaderCell.Style.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;
                grdCategoria.Columns["clmPreco"].HeaderCell.Style.Alignment =
                    grdCategoria.Columns["clmEstoque"].HeaderCell.Style.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;
                

                this.Cursor = Cursors.Default;
            }
        }


        private void btnAddCategoria_Click(object sender, EventArgs e)
        {
            using( var form = new FormCategoria())
            {
                form.Text = "Adição de Categoria...";
                if(form.ShowDialog() == DialogResult.OK)
                {
                    using (var db = new EstoqueContext())
                    {
                        Categoria categoria = new Categoria();
                        categoria.Nome = form.txtNome.Text;
                        db.Categorias.Add(categoria);
                        db.SaveChanges();
                        AtualizarCategoria(db);
                        SimpleMessage.Inform("Categoria adicionada com sucesso.", "Informação");
                    }
                }
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            using (var form = new FormCategoria())
            {
               

                form.Text = "Alteração de Categoria...";
                form.txtNome.Text = cbxCategoria.Text;
                
                if (form.ShowDialog() == DialogResult.OK)
                {
                    using (var db = new EstoqueContext())
                    {
                        Categoria categoria = (cbxCategoria.SelectedItem as Categoria);
                        categoria.Nome = form.txtNome.Text;
                        db.Categorias.Attach(categoria);
                        db.Entry(categoria).State = EntityState.Modified;
                        db.SaveChanges();
                        AtualizarCategoria(db);
                        cbxCategoria.SelectedItem = categoria;
                        SimpleMessage.Inform("Categoria alterado com sucesso.", "Informação");
                    }
                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if(SimpleMessage.Confirm("Deseja realmente excluir a categoria selecionada", "Exclusão de categoria"))
            {
                using (var db = new EstoqueContext())
                {
                    Categoria categoria = cbxCategoria.SelectedItem as Categoria;
                    int qtdeProdutos = db.Produtos.Where(
                        x => x.IdCategoria == categoria.IdCategoria).Count();

                    //Categoria cat = db.Categorias.Include(x => x.Produtos).
                    //    FirstOrDefault(x => x.IdCategoria == categoria.IdCategoria);

                    if (qtdeProdutos== 0)
                    {
                        //Categoria cat = db.Categorias.Find(idCategoria);
                        db.Attach(categoria);
                        db.Entry(categoria).State = EntityState.Deleted;
                        db.SaveChanges();
                        AtualizarCategoria(db);
                        SimpleMessage.Inform("Categoria excluida com sucesso", "Informação");

                    }
                    else
                    {
                        SimpleMessage.Error("Não é possivel excluir uma categoria com produtos.");
                    }
                }
            }
        }

        private void btnAddGrd_Click(object sender, EventArgs e)
        {
            using (var form = new FormProduto())
            {
                form.Text = "Adição de Produto....";
                form.cbxCategoria.SelectedIndex = cbxCategoria.SelectedIndex;
                if (form.ShowDialog() == DialogResult.OK) 
                {
                    using(var db = new EstoqueContext())
                    {
                        Produto produto = new Produto();
                        produto.Nome = form.txtNome.Text;
                        produto.Estoque = Convert.ToInt32(form.ndEstoque.Value);
                        produto.Preco = Convert.ToDouble(form.ndPreco.Value);
                        produto.IdCategoria = 
                            (form.cbxCategoria.SelectedItem as Categoria).IdCategoria;
                        db.Produtos.Add(produto);
                        db.SaveChanges();
                        AtualizarProdutos(db);
                        SimpleMessage.Inform("Produto adicionado com sucesso.", "Informação");

                    }
                }
            }
        }

        private void cbxCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            using(var db = new EstoqueContext())
            {
                AtualizarProdutos(db);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (var db = new EstoqueContext())
            {

                AtualizarCategoria(db);
                AtualizarProdutos(db); 
            }
        }

        private void btnAlterarGrd_Click(object sender, EventArgs e)
        {
            DataGridViewRow linhaSelecioanda = null;
            if(grdCategoria.SelectedRows.Count> 0)
            {
                linhaSelecioanda = grdCategoria.SelectedRows[0]; //capturando a linha selecionada
                Produto produto = linhaSelecioanda.DataBoundItem as Produto;
                using (var form = new FormProduto())
                {
                    form.Text = "Alteração de Produto...";
                    form.txtNome.Text = produto.Nome;
                    form.ndEstoque.Value = produto.Estoque;
                    form.ndPreco.Value = Convert.ToDecimal(produto.Preco);
                    form.cbxCategoria.SelectedIndex =
                        form.cbxCategoria.FindString(produto.Categoria.Nome);
                    if(form.ShowDialog() == DialogResult.OK)
                    {
                        using (var db = new EstoqueContext())
                        {
                            produto.Nome = form.txtNome.Text;
                            produto.Estoque = Convert.ToInt32(form.ndEstoque.Value);
                            produto.Preco = Convert.ToDouble(form.ndPreco.Value);
                            produto.Categoria.IdCategoria = (form.cbxCategoria.SelectedItem as Categoria).IdCategoria;

                            db.Produtos.Attach(produto);
                            db.Entry(produto).State = EntityState.Modified;
                            db.SaveChanges();
                            AtualizarProdutos(db);
                            SimpleMessage.Inform("Produto alterado com sucesso.", "Informação");
                        }
                    }
                }


            }
        }

        private void grdCategoria_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnAlterarGrd_Click(null, null);
        }

        private void btnExcluirGrd_Click(object sender, EventArgs e)
        {
            DataGridViewRow linhaSelecionada = null;
            if(grdCategoria.SelectedRows.Count > 0)
            {
                linhaSelecionada = grdCategoria.SelectedRows[0];
                Produto produto = linhaSelecionada.DataBoundItem as Produto;
                if(SimpleMessage.Confirm(
                    "Deseja realmente excluir o produto selecionado?",
                    "Exclusão de Produto"))
                {
                    using (var db = new EstoqueContext())
                    {
                        db.Produtos.Attach(produto);
                        db.Entry(produto).State = EntityState.Deleted;
                        db.SaveChanges();
                        AtualizarProdutos(db);
                        SimpleMessage.Inform("Produto excluido com sucesso.", "Informação");
                    }
                }
            }
        }
    }
}
