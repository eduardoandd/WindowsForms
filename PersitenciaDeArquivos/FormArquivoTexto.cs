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
    public partial class FormArquivoTexto : Form
    {
        string caminhoArquivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "dados.txt");

        public object SimplesMessage { get; private set; }

        public FormArquivoTexto()
        {
            InitializeComponent();
        }

        private void btnAdicionarLinha_Click(object sender, EventArgs e)
        {
            lbxLinha.Items.Add($"Linha adicionada em {DateTime.Now.ToLongDateString()} " +
                $"as " + $"{DateTime.Now.ToLongTimeString()}.");
        }

        private void btnExcluirLinha_Click(object sender, EventArgs e)
        {
            lbxLinha.Items.Remove(lbxLinha.SelectedItem);
        }

        private void btnCriarArquivo_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter(caminhoArquivo);

            foreach (var linha in lbxLinha.Items)
            {
                sw.WriteLine(linha);
            }
            sw.Close();

            SimpleMessage.Inform("Arquivo criado com sucesso.", "Informação");


        }

        private void btnLerArquivo_Click(object sender, EventArgs e)
        {
            if(File.Exists(caminhoArquivo))
            {
                lbxLinha.Items.Clear();
                StreamReader sr = new StreamReader(caminhoArquivo);
                while(!sr.EndOfStream)
                {
                    lbxLinha.Items.Add(sr.ReadLine());
                }
                sr.Close();
                SimpleMessage.Inform("Arquivo lido com sucesso.", "Informação");
            }
            else
            {
                SimpleMessage.Error("Arquivo texto não encontrado ");
            }
        }

        private void btnAtualizarArquivo_Click(object sender, EventArgs e)
        {
            if(File.Exists(caminhoArquivo))
            {
                StreamWriter sw = new StreamWriter(caminhoArquivo, true);
                foreach (string linha in lbxLinha.Items)
                {
                    sw.WriteLine(linha);
                }
                sw.Close();
                SimpleMessage.Inform("Arquivo atualizado com sucesso. ", "Informação");
            }
            else
            {
                SimpleMessage.Error("Arquivo texto não encontado", "Erro");
            }

            

        }

        private void btnCriarArquivo2_Click(object sender, EventArgs e)
        {
            File.WriteAllLines(caminhoArquivo, lbxLinha.Items.OfType<string>().ToArray());

            SimpleMessage.Inform("Arquivo criado com sucesso.", "Informação");

        }

        private void btnLerArquivo2_Click(object sender, EventArgs e)
        {

            lbxLinha.Items.Clear();
            if (File.Exists(caminhoArquivo))
            {
                lbxLinha.Items.AddRange(File.ReadAllLines(caminhoArquivo));
                SimpleMessage.Inform("Arquivo lido com sucesso.", "Informação");
            }
            else
            {
                SimpleMessage.Error("Arquivo texto não encotrado", "Erro");
            }
            
        }

        private void btnAtualizarArquivo2_Click(object sender, EventArgs e)
        {
            if(File.Exists(caminhoArquivo))
            {
                File.AppendAllLines(caminhoArquivo,
                    lbxLinha.Items.OfType<string>().ToArray());
                SimpleMessage.Inform("Arquivo atualizado com sucesso.", "informação");
            }
            else
            {
                SimpleMessage.Error("Arquivo texto não encontrado.", "Erro");
            }
        }
    }
}
