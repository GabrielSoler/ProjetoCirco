using Projeto_Circo.FormsFinanceiro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Circo.FormsLogin
{
    public partial class FrmLoginFinanceiro : Form
    {
        public FrmLoginFinanceiro()
        {
            InitializeComponent();
        }

        private void FrmLoginFinanceiro_Load(object sender, EventArgs e)
        {
            // Set to no text.  
            txtSenha.Text = "";
            // The password character is an asterisk.  
            txtSenha.PasswordChar = '*';
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtSenha.Text = string.Empty;
            txtUsuario.Text = string.Empty;
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("FAlta fazer :( \n estou fazendo o possivel");
            this.Close();

            FrmFinanceiro form = new FrmFinanceiro();
            form.Show();

        }
    }
}
