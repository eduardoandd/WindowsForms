using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoDeDadosSQL
{
    internal class Cliente
    {
        public int IdCliente { get; set; }
        public string Nome { get; set; }
        public decimal LimiteCredito { get; set; }
        public DateTime DataNascimento { get; set; }
        public DateTime DataHoraUltimaCompra { get; set; }
        public bool Bloqueado { get; set; }
    }
}
