using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroDeClientes
{
    public class Pais
    {
        
        public string Sigla { get; set; }
        public string Nome { get; set; }

        public Pais(string sigla, string nome)
        {
            this.Sigla = sigla;
            this.Nome = nome;
        }

        public static List<Pais> Listagem { get; set; }

        static Pais()
        {
            var lista = Pais.Listagem = new List<Pais>();

            lista.Add(new Pais("BR", "BRASIL"));
            lista.Add(new Pais("AR", "ARGENTINA"));
            lista.Add(new Pais("CO", "COLOMBIA"));
            lista.Add(new Pais("CH", "CHILE"));
        }

    }
}
