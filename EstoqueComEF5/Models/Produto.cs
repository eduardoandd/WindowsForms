﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoqueComEF5.Models
{
    internal class Produto
    {
        [Key]
        public int IdProduto { get; set; }

        [Required, MaxLength(100)]
        public string Nome { get; set; }
        public int Estoque { get; set; }
        public double Preco { get; set; }


        [ForeignKey("Categoria")]
        public int IdCategoria { get; set; }
        public Categoria Categoria { get; set; }
    }
}
