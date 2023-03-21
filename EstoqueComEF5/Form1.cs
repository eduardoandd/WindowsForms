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
            using (var db = new EstoqueContext())
            {
                
                AtualizarCategoria(db);
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

        private void AtualizarCategoria(EstoqueContext db)
        {
            
            cbxCategoria.DataSource = db.Categorias.ToList();
            cbxCategoria.DisplayMember = "Nome";
            cbxCategoria.ValueMember = "IdCategoria";
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
    }
}
