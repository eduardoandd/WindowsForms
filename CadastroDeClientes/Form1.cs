using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroDeClientes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            AtualizarComboBoxPaises();
            CriarControlesEstadosCivis();
            DesabilitaCampos();
        }

        private void Informar(string mensagem)
        {
            MessageBox.Show(mensagem, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private bool Confirmar(string pergunta)
        {
            return MessageBox.Show(pergunta, "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        }

        private void AtualizarComboBoxPaises()
        {
            cbxNacionalidade.DataSource = Pais.Listagem;
            cbxNacionalidade.DisplayMember = "";
            cbxNacionalidade.DisplayMember = "Nome";
            cbxNacionalidade.ValueMember = "Sigla";
            cbxNacionalidade.SelectedIndex = -1;
            
        }

        private void AtualizarComboBoxClientes()
        {
            cbxClientes.DataSource = Cliente.Listagem;
            cbxClientes.DisplayMember = "";
            cbxClientes.DisplayMember = "Nome";
            cbxClientes.ValueMember = "Codigo";
        }

        private void CorrigirTabStop(object sender, EventArgs e)
        {
            ((RadioButton)sender).TabStop = true;
        }

        private void CriarControlesEstadosCivis()
        {
            int iRB = 0;
            var estadosCivis = Enum.GetValues(typeof(enumEstadoCivil));
            foreach(var ec in estadosCivis)
            {
                RadioButton rb = new RadioButton()
                {
                    Text = ec.ToString(),
                    Location = new Point(10, (iRB + 1) * 27),
                    Width = 85,
                    TabStop = true,
                    TabIndex = iRB,
                    Tag = ec
                };
                rb.TabStopChanged += new EventHandler(CorrigirTabStop);
                gbEstadoCivil.Controls.Add(rb);
                iRB++;
            }
        }

        private enumEstadoCivil? lerEstadoCivil()
        {
            foreach(var control in gbEstadoCivil.Controls)
            {
                RadioButton rb = control as RadioButton;
                if(rb.Checked)
                {
                    return (enumEstadoCivil)(rb.Tag);
                }
            }
            return null;
        }

        private void MarcarEstadoCivil(enumEstadoCivil estadoCivil)
        {
            foreach(var control in gbEstadoCivil.Controls)
            {
                RadioButton rb = control as RadioButton;
                if((enumEstadoCivil)(rb.Tag) == estadoCivil)
                {
                    rb.Checked = true;
                    return;
                }
            }
        }

        private void LimparCampos()
        {
            txtCodigo.Clear();
            txtNome.Clear();
            txtCPF.Clear();
            dtNascimento.Value = DateTime.Now.Date;
            ndRendaMensal.Value = 0;
            foreach (var control in gbEstadoCivil.Controls)
            {
                (control as RadioButton).Checked = false;
            }
            cbxNacionalidade.SelectedIndex = -1;
            txtPlaca.Clear();
            cbTemFilhos.CheckState = CheckState.Indeterminate;
        }

        private void preencherCamposComClientes(Cliente cliente)
        {
            txtCodigo.Text = cliente.Codigo.ToString();
            txtNome.Text = cliente.Nome;
            txtCPF.Text = cliente.CPF.ToString();
            dtNascimento.Value = cliente.DataNascimento;
            ndRendaMensal.Value = cliente.RendaMensal;
            MarcarEstadoCivil(cliente.EstadoCivil);
            cbxNacionalidade.SelectedValue = cliente.Nacionalidade;
            txtPlaca.Text = cliente.PlacaVeiculo;
            cbTemFilhos.Checked = cliente.TemFilhos;
            
        }

        private void PreencherClienteComCampos(Cliente cliente)
        {
            cliente.Nome = txtNome.Text;
            cliente.CPF = txtCPF.Text;
            cliente.DataNascimento = dtNascimento.Value;
            cliente.RendaMensal = ndRendaMensal.Value;
            cliente.EstadoCivil = lerEstadoCivil().Value;
            cliente.TemFilhos = cbTemFilhos.Checked;
            cliente.Nacionalidade = cbxNacionalidade.SelectedValue.ToString();
            cliente.PlacaVeiculo = txtPlaca.Text;
        }

        private bool PreencheuTodosOsCampos()
        {
            if (String.IsNullOrWhiteSpace(txtNome.Text)) return false;
            if (String.IsNullOrWhiteSpace(txtCPF.Text)) return false;
            if(dtNascimento.Value.Date == DateTime.Now.Date) return false;
            if (ndRendaMensal.Value == 0) return false;
            if (lerEstadoCivil() == null) return false;
            if (cbxNacionalidade.SelectedIndex < 0) return false;
            if (String.IsNullOrWhiteSpace(txtCPF.Text)) return false;
            if(cbTemFilhos.CheckState == CheckState.Indeterminate) return false;

            return true;
        }


        private bool PossuiValoresNaoSalvos()
        {
            if(cbxClientes.SelectedIndex <0)
            {
                if (!String.IsNullOrWhiteSpace(txtNome.Text)) return true;
                if (!String.IsNullOrWhiteSpace(txtCPF.Text)) return true;
                if (dtNascimento.Value.Date != DateTime.Now.Date) return true;
                if (ndRendaMensal.Value > 0) return true;
                if (lerEstadoCivil() != null) return true;
                if (cbxNacionalidade.SelectedIndex >= 0) return true;
                if (!String.IsNullOrWhiteSpace(txtPlaca.Text)) return true;
                if (cbTemFilhos.CheckState != CheckState.Indeterminate) return true;
            }
            else
            {
                Cliente cliente = cbxClientes.SelectedItem as Cliente;
                if (txtNome.Text.Trim() != cliente.Nome) return true;
                if (txtCPF.Text != cliente.CPF.ToString()) return true;
                if (dtNascimento.Value.Date != cliente.DataNascimento) return true;
                if (ndRendaMensal.Value != cliente.RendaMensal) return true;
                if (lerEstadoCivil() != cliente.EstadoCivil) return true;
                if (cbxNacionalidade.SelectedValue.ToString() != cliente.Nacionalidade) return true;
                if (txtPlaca.Text != cliente.PlacaVeiculo) return true;
                if (cbTemFilhos.Checked != cliente.TemFilhos) return true;
            }
            return false;

        }

        private void AlterarEstadoDosCampos(bool estado)
        {
            txtNome.Enabled = estado;
            txtCPF.Enabled = estado;
            dtNascimento.Enabled = estado;
            ndRendaMensal.Enabled = estado;
            gbEstadoCivil.Enabled = estado;
            cbxNacionalidade.Enabled = estado;
            txtPlaca.Enabled = estado;
            cbTemFilhos.Enabled = estado;
            btnSalvar.Enabled = estado;
            btnCancelar.Enabled = estado;
        }
        
        private void HabilitarCampos()
        {
            AlterarEstadoDosCampos(true);
        }
        private void DesabilitaCampos()
        {
            AlterarEstadoDosCampos(false);
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            cbxClientes.SelectedIndex = -1;
            LimparCampos();
            HabilitarCampos();
            txtNome.Select();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (PreencheuTodosOsCampos())
            {
                Cliente cliente = cbxClientes.SelectedIndex < 0 ?
                    new Cliente() : cbxClientes.SelectedItem as Cliente;

                PreencherClienteComCampos(cliente);
                DesabilitaCampos();

                if (cbxClientes.SelectedIndex < 0)
                {
                    cliente = Cliente.Inserir(cliente);
                    AtualizarComboBoxClientes();
                    Informar("Cliente cadastrado com sucesso!");
                }
                else
                {
                    AtualizarComboBoxClientes();
                    Informar("Cliente alterado com sucesso!");
                }
            }
            else
            {
                Informar("Só é possivel salvar se todos os campos forem preenchidos. Salvaento não realizado");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (PossuiValoresNaoSalvos())
            {
                if(Confirmar("Há alterações não salvar. Deseja realmente cancelar?"))
                {
                    if (cbxClientes.SelectedIndex == -1)
                        LimparCampos();
                    else
                        preencherCamposComClientes(cbxClientes.SelectedItem as Cliente);
                    cbxClientes.Select();
                    DesabilitaCampos();
                }
            }
            else
            {
                if (cbxClientes.SelectedIndex == -1)
                    LimparCampos();
                else
                    preencherCamposComClientes(cbxClientes.SelectedItem as Cliente);
                cbxClientes.Select();
                DesabilitaCampos();
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();

        }

       
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
            preencherCamposComClientes(cbxClientes.SelectedItem as Cliente);
            txtNome.Select();
        }

        private void cbxClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxClientes.SelectedIndex < 0)
            {
                btnAlterar.Enabled = false;
            }
            else
            {
                preencherCamposComClientes(cbxClientes.SelectedItem as Cliente);
                btnAlterar.Enabled = true;
            }

        }
    }
}
