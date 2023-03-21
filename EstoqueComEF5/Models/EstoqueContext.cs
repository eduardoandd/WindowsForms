using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoqueComEF5.Models
{
    internal class EstoqueContext : DbContext
    {
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet <Produto> Produtos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite("Data Source=estoque.db");
        }
    }
}
