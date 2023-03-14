using Maroquio;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ComponentesVisuais
{
    public class Produto
    {
      

        public enum enCategoria
        {
            Alimentos,
            Eletrônicos,
            HortiFruti,
            Limpeza
        }

        public int Codigo { get; set; }
        public string Nome { get; set; }
        public double Estoque { get; set; }
        public DateTime DataValidade { get; set; }
        public bool Empromocao { get; set; }
        public enCategoria  Categoria { get; set; }

        public Bitmap ImagemProduto { get; set; }



        public Produto(int codigo, string nome, double estoque
                     , DateTime dataValidade, bool empromocao, enCategoria categoria)
        {
            this.Codigo = codigo;
            this.Nome = nome;
            this.Estoque = estoque;
            this.DataValidade = dataValidade;
            this.Empromocao = empromocao;
            this.Categoria = categoria;
            this.ImagemProduto = new Bitmap("_Virgil van Dijk .png");
        }

        public static SortableBindingList<Produto> Listagem { get; set; }

        static Produto()
        {
            
            var lista = Produto.Listagem = new SortableBindingList<Produto>();

            lista.Add(new Produto(1, "Banana", 52.5, DateTime.Today.AddDays(32), false, enCategoria.HortiFruti));
            lista.Add(new Produto(2, "Maçã", 20, DateTime.Today.AddDays(55), true, enCategoria.HortiFruti));
            lista.Add(new Produto(3, "Morango", 10.8, DateTime.Today.AddDays(10), false, enCategoria.HortiFruti));

            lista.Add(new Produto(4, "Detergente", 22, DateTime.Today.AddDays(324), true, enCategoria.Limpeza));

            lista.Add(new Produto(5, "Celular", 15, DateTime.Today.AddYears(5), false, enCategoria.Eletrônicos));




        }

        public Produto()
        {
        }
    }



    
}
