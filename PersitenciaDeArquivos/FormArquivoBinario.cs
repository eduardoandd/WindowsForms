using MessageUtils;
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

namespace PersitenciaDeArquivos
{
    public partial class FormArquivoBinario : Form
    {
        string caminhoArquivo = Path.Combine(
            AppDomain.CurrentDomain.BaseDirectory, "dados.bin");
        public FormArquivoBinario()
        {
            InitializeComponent();
        }

        private void btnEscrever_Click(object sender, EventArgs e)
        {
            BinaryWriter bw = new BinaryWriter(File.Open(caminhoArquivo, FileMode.Create));

            Random random = new Random();

            for (int i =1; i <= 20; i++)
            {
                string titulo = $"Filnme {i}";
                int tempoSegundos = random.Next(3600, 10800);
                DateTime dataLancamento = DateTime.Now.AddDays(-random.Next(1, 3650)).AddSeconds(random.Next(24 * 60 * 60));
                double arrecadacao = random.NextDouble() * 5000000;
                bool publicado = true;

                bw.Write(titulo);
                bw.Write(tempoSegundos);
                bw.Write(dataLancamento.ToBinary());
                bw.Write(arrecadacao);
                bw.Write(publicado);
            }
            bw.Close();
            SimpleMessage.Inform("Arquivo binário criado com sucesso");

           


        }

        private void btnLer_Click(object sender, EventArgs e)
        {
            lbxLinhas.Items.Clear();
            if(File.Exists(caminhoArquivo))
            {
                List<string> dados = new List<String>();
                BinaryReader br = new BinaryReader(File.Open(caminhoArquivo, FileMode.Open));
                while (br.BaseStream.Position != br.BaseStream.Length)
                {
                    string titulo = br.ReadString();
                    int tempoSegundos = br.ReadInt32();
                    DateTime dataLancamento = DateTime.FromBinary(br.ReadInt64());
                    double arrecadacao = br.ReadDouble();
                    bool publicado = br.ReadBoolean();
                    dados.Add($"{titulo}{tempoSegundos}{dataLancamento}{arrecadacao}{publicado}");
                }
                br.Close();
                lbxLinhas.Items.AddRange(dados.ToArray());
                SimpleMessage.Inform("Arquivo binario carregado com sucesso", "Informação");


            }
            else
            {
                SimpleMessage.Error("Arquivo binario não encontrado", "Erro");
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (File.Exists(caminhoArquivo))
            {
                BinaryWriter bw = new BinaryWriter(File.Open(caminhoArquivo, FileMode.Append));
                Random random = new Random();

                for (int i = 1; i <= 20; i++)
                {
                    string titulo = $"Filnme {i}";
                    int tempoSegundos = random.Next(3600, 10800);
                    DateTime dataLancamento = DateTime.Now.AddDays(-random.Next(1, 3650)).AddSeconds(random.Next(24 * 60 * 60));
                    double arrecadacao = random.NextDouble() * 5000000;
                    bool publicado = true;

                    bw.Write(titulo);
                    bw.Write(tempoSegundos);
                    bw.Write(dataLancamento.ToBinary());
                    bw.Write(arrecadacao);
                    bw.Write(publicado);
                }
                bw.Close();
                SimpleMessage.Inform("Arquivo binário atualziado com sucesso");

            }
            else
            {
                SimpleMessage.Inform("Erro", "erro");
            }
          
        }

        private void btnCriarArquivo_Click(object sender, EventArgs e)
        {
            File.WriteAllLines(caminhoArquivo.Replace("dados.bin", "dadosBin.txt"),
                lbxLinhas.Items.OfType<string>().ToArray());
            SimpleMessage.Inform("Arquivo texto criado com sucesso", "Informação");
        }
    }
}
