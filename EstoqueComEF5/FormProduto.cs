using EstoqueComEF5.Models;
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
    public partial class FormProduto : Form
    {
        public FormProduto()
        {
            InitializeComponent();

            using (var db = new EstoqueContext())
            {

                AtualizarCategoria(db);
            }
        }

        private void AtualizarCategoria(EstoqueContext db)
        {

            cbxCategoria.DataSource = db.Categorias.ToList();
            cbxCategoria.DisplayMember = "Nome";
            cbxCategoria.ValueMember = "IdCategoria";
        }
    }
}
