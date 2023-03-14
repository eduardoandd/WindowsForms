using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01.Formularios
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Shown(object sender, EventArgs e)
        {
            //MessageBox.Show("bem vindo ao programa");
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
           //if(MessageBox.Show("Deseja realmente sair?", "Confirmação",
           //    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
           // {
           //     e.Cancel = true;
           // }
        }

        private void FormMain_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 'a')
            {
                var form = new FormAbout();
                form.ShowDialog();
            }
        }
    }
}
