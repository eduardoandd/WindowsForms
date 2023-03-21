using MessageUtils;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancoDeDadosSQL
{
    public partial class FormMain : Form
    {
        string caminhoBD = Path.Combine(Application.LocalUserAppDataPath, "data.db");
        public FormMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CriarBancoDeDados(string caminho)
        {
            using (SqliteConnection db = new SqliteConnection($"Filename={caminho}"))
            {
                db.Open();

                StringBuilder sb = new StringBuilder();
                sb.Append("CREATE TABLE IF NOT EXISTS Cliente(");
                sb.Append("IdCliente INTEGER PRIMARY KEY,");
                sb.Append("Nome VARCHAR(50) NOT NULL,");
                sb.Append("LimiteCredito DECIMAL(18,2),");
                sb.Append("DataNascimento DATE,");
                sb.Append("DataHoraUltimaCompra DATETIME,");
                sb.Append("Bloqueado BOOLEAN);");

                SqliteCommand sql = new SqliteCommand(sb.ToString(), db);
                sql.ExecuteNonQuery();
            }
        }

        private void PopularBancoDeDados(string caminho)
        {
            Random gerador = new Random();
            using (SqliteConnection db = new SqliteConnection($"FileName={caminho}"))
            {
                db.Open();
                StringBuilder sb = new StringBuilder();
                sb.Append("INSERT INTO Cliente VALUES (NULL,");
                sb.Append("@Nome, @LimiteCredito, @DataNascimento, @DataHoraUltimaCompra, @Bloqueado);");
                SqliteCommand sql = new SqliteCommand(sb.ToString(), db);
                int insertCount = 0;
                for (int i = 1; i <= 100; i++)
                {
                    sql.Parameters.Clear();
                    sql.Parameters.AddWithValue("@Nome", $"Cliente {i}");
                    sql.Parameters.AddWithValue("@LimiteCredito", gerador.NextDouble() * 100000);
                    sql.Parameters.AddWithValue("@DataNascimento", DateTime.Today.AddDays(
                        -gerador.Next(18 * 365, 75 * 365)));
                    sql.Parameters.AddWithValue("@DataHoraUltimaCompra", DateTime.Now.AddHours(
                        -gerador.Next(100000)));
                    sql.Parameters.AddWithValue("@Bloqueado", gerador.Next(0, 2));
                    insertCount += sql.ExecuteNonQuery();
                }
                SimpleMessage.Inform($"Foram inseridos {insertCount} clientes no banco de dados.", "Informação");
            }
        }

        private List<Cliente> LerBancoDeDados(string caminho)
        {
            using (SqliteConnection db = new SqliteConnection($"Filename={caminho}"))
            {
                db.Open();

                StringBuilder sb = new StringBuilder();

                sb.Append("SELECT * FROM Cliente ORDER BY IdCliente");
                SqliteCommand sql = new SqliteCommand(sb.ToString(), db);
                SqliteDataReader leitor = sql.ExecuteReader();
                List<Cliente> clientes = new List<Cliente>();
                while (leitor.Read())
                {
                    Cliente cliente = new Cliente
                    {
                        IdCliente = Convert.ToInt32(leitor["IdCliente"]),
                        Nome = leitor["Nome"].ToString(),
                        LimiteCredito = Convert.ToDecimal(leitor["LimiteCredito"]),
                        DataNascimento = Convert.ToDateTime(leitor["DataNascimento"]),
                        DataHoraUltimaCompra = Convert.ToDateTime(leitor["DataHoraUltimaCompra"]),
                        Bloqueado = Convert.ToBoolean(leitor["Bloqueado"])

                    };
                    clientes.Add(cliente);

                }
                return clientes;
            }
        }


        private List<Cliente> ConsultarBancoDeDados(string caminho, decimal limiteMaximo)
        {
            using (SqliteConnection db = new SqliteConnection($"Filename={caminho}"))
            {
                db.Open();

                StringBuilder sb = new StringBuilder();

                sb.Append("SELECT * FROM Cliente ");
                sb.Append("WHERE LimiteCredito < @LimiteCredito ");
                sb.Append("ORDER BY IdCliente");
                SqliteCommand sql = new SqliteCommand(sb.ToString(), db);
                sql.Parameters.AddWithValue("@LimiteCredito", limiteMaximo);
                SqliteDataReader leitor = sql.ExecuteReader();
                List<Cliente> clientes = new List<Cliente>();
                while (leitor.Read())
                {
                    Cliente cliente = new Cliente
                    {
                        IdCliente = Convert.ToInt32(leitor["IdCliente"]),
                        Nome = leitor["Nome"].ToString(),
                        LimiteCredito = Convert.ToDecimal(leitor["LimiteCredito"]),
                        DataNascimento = Convert.ToDateTime(leitor["DataNascimento"]),
                        DataHoraUltimaCompra = Convert.ToDateTime(leitor["DataHoraUltimaCompra"]),
                        Bloqueado = Convert.ToBoolean(leitor["Bloqueado"])

                    };
                    clientes.Add(cliente);

                }
                return clientes;
            }
        }

        private void AtualizarBancoDeDados(string caminho, int idCliente)
        {
            using (SqliteConnection db = new SqliteConnection($"Filename={caminho}"))
            {
                db.Open();

                StringBuilder sb = new StringBuilder();

                sb.Append("UPDATE CLIENTE SET ");
                sb.Append("Nome = @Nome, LimiteCredito = @LimiteCredito ");
                sb.Append("WHERE IdCliente = @IdCliente");
                SqliteCommand sql = new SqliteCommand(sb.ToString(), db);
                sql.Parameters.AddWithValue("@Nome", $"Cliente {idCliente} Modificado");
                sql.Parameters.AddWithValue("@LimiteCredito", 10000);
                sql.Parameters.AddWithValue("@IdCliente", idCliente);
                if (sql.ExecuteNonQuery() > 0)
                {
                    SimpleMessage.Inform($"Cliente {idCliente} atualizado com sucesso.");
                }
                
            }
        }

        private void ExcluirBancoDeDados(string caminho, int idCliente)
        {
            using (SqliteConnection db = new SqliteConnection($"Filename={caminho}"))
            {
                db.Open();

                StringBuilder sb = new StringBuilder();
                sb.Append("DELETE FROM Cliente WHERE IdCliente = @IdCliente");
                SqliteCommand sql = new SqliteCommand(sb.ToString(), db);
                sql.Parameters.AddWithValue("@IdCliente", idCliente);
                if (sql.ExecuteNonQuery() > 0)
                {
                    SimpleMessage.Inform($"Cliente {idCliente} excluido com sucesso.");
                }

            }
        }

        private decimal ObterMediarBancoDeDados(string caminho)
        {
            using (SqliteConnection db = new SqliteConnection($"Filename={caminho}"))
            {
                db.Open();

                StringBuilder sb = new StringBuilder();
                sb.Append("SELECT AVG(LimiteCredito) FROM Cliente");
                SqliteCommand sql = new SqliteCommand(sb.ToString(), db);
                decimal limiteMedio = Convert.ToDecimal(sql.ExecuteScalar());
                return limiteMedio;

            }
        }

        private Cliente AtualizarExibirBancoDeDados(string caminho, int idCliente)
        {
            using (SqliteConnection db = new SqliteConnection($"Filename={caminho}"))
            {
                db.Open();

                StringBuilder sb = new StringBuilder();

                sb.Append("UPDATE Cliente SET ");
                sb.Append("Nome = @Nome, LimiteCredito = @LimiteCredito ");
                sb.Append("WHERE IdCliente = @IdCliente; ");
                sb.Append("SELECT * FROM Cliente ");
                sb.Append("WHERE IdCliente = @IdCliente ");
               
                SqliteCommand sql = new SqliteCommand(sb.ToString(), db);
                sql.Parameters.AddWithValue("@Nome", $"Cliente {idCliente} Modificado");
                sql.Parameters.AddWithValue("@LimiteCredito", 10000);
                sql.Parameters.AddWithValue("@IdCliente", idCliente);
                SqliteDataReader leitor = sql.ExecuteReader();
                List<Cliente> clientes = new List<Cliente>();
                if (leitor.HasRows)
                {
                    leitor.Read();
                    Cliente cliente = new Cliente
                    {
                        IdCliente = Convert.ToInt32(leitor["IdCliente"]),
                        Nome = leitor["Nome"].ToString(),
                        LimiteCredito = Convert.ToDecimal(leitor["LimiteCredito"]),
                        DataNascimento = Convert.ToDateTime(leitor["DataNascimento"]),
                        DataHoraUltimaCompra = Convert.ToDateTime(leitor["DataHoraUltimaCompra"]),
                        Bloqueado = Convert.ToBoolean(leitor["Bloqueado"])

                    };
                    return cliente;
                }
                else return null;
                
                
            }
        }


        private void btnCriar_Click(object sender, EventArgs e)
        {
            CriarBancoDeDados(caminhoBD);
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            PopularBancoDeDados(caminhoBD);
        }

        private void btnLer_Click(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = LerBancoDeDados(caminhoBD);
            grdClientes.DataSource = bs;
            //List<Cliente> clientes = LerBancoDeDados(caminhoBD);
            //grdClientes.DataSource = clientes;

        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {

            int idCliente = Convert.ToInt32(grdClientes.SelectedCells[0].Value);
            AtualizarBancoDeDados(caminhoBD, idCliente);


        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int idCliente = Convert.ToInt32(grdClientes.SelectedCells[0].Value);
            ExcluirBancoDeDados(caminhoBD, idCliente);
            grdClientes.Rows.RemoveAt(grdClientes.SelectedRows[0].Index);
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {

            grdClientes.DataSource = ConsultarBancoDeDados(caminhoBD, nd.Value);
        }

        private void btnConsultaLimiteMedio_Click(object sender, EventArgs e)
        {
            decimal mediaLimiteCredito =  ObterMediarBancoDeDados(caminhoBD);
            SimpleMessage.Inform($"A média do limite de crédito é {mediaLimiteCredito:F2}.");
        }

        private void btnAtualizarExibir_Click(object sender, EventArgs e)
        {

            int idCliente = Convert.ToInt32(grdClientes.SelectedCells[0].Value);
            Cliente cliente = AtualizarExibirBancoDeDados(caminhoBD, idCliente);
            DataGridViewCellCollection linhaModificada = grdClientes.SelectedRows[0].Cells;
            linhaModificada["IdCliente"].Value = cliente.IdCliente;
            linhaModificada["Nome"].Value = cliente.Nome;
            linhaModificada["LimiteCredito"].Value = cliente.LimiteCredito;
            linhaModificada["DataNascimento"].Value = cliente.DataNascimento;
            linhaModificada["DataHoraUltimaCompra"].Value = cliente.DataHoraUltimaCompra;
            linhaModificada["Bloqueado"].Value = cliente.Bloqueado;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SimpleMessage.Alert("OI");
        }
    }
}
