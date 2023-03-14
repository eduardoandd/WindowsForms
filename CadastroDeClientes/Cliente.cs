using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroDeClientes
{
    public enum enumEstadoCivil
    {
        Solteiro,
        Casado,
        Divorciado,
        Viuvo
    }

    public class Cliente
    {
        public Cliente(string nome, string cPF, DateTime dataNascimento
            , decimal rendaMensal, enumEstadoCivil estadoCivil, bool temFilhos
            , string nacionalidade, string placaVeiculo)
        {
            this.Nome = nome;
            this.CPF = cPF;
            this.DataNascimento = dataNascimento;
            this.RendaMensal = rendaMensal;
            this.EstadoCivil = estadoCivil;
            this.TemFilhos = temFilhos;
            this.Nacionalidade = nacionalidade;
            this.PlacaVeiculo = placaVeiculo;
        }

        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public DateTime DataNascimento { get; set; }
        public decimal RendaMensal { get; set; }
        public enumEstadoCivil EstadoCivil { get; set; }
        public bool TemFilhos { get; set; }
        public string Nacionalidade { get; set; }
        public string PlacaVeiculo { get; set; }

        public Cliente()
        {
            this.Codigo = 0;
        }

        public static List<Cliente> Listagem{get; set;}
        static Cliente()
        {
            Cliente.Listagem= new List<Cliente>();
        }

        public static Cliente Inserir(Cliente cliente)
        {
            int codigo = Cliente.Listagem.Count > 0 ?
                Cliente.Listagem.Max(c => c.Codigo) + 1 : 1;

            cliente.Codigo = codigo;
            Cliente.Listagem.Add(cliente);
            return cliente;
            
        }
        
    }
}
