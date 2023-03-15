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
                List<Cliente> clientes= new List<Cliente>();
                while(leitor.Read())
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
            List<Cliente> clientes = LerBancoDeDados(caminhoBD);
            grdClientes.DataSource = clientes;

        }
    }
}
