using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Circo.FormsFuncionario
{
    public partial class FrmCadFuncionario : Form
    {
        public FrmCadFuncionario()
        {
            InitializeComponent();
        }

        private void btnMudaSenha_Click(object sender, EventArgs e)
        {
            FrmAltLoginFuncionario Form = new FrmAltLoginFuncionario();
            Form.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void limparFrmCadFuncionario()
        {
            txtNome.Text = string.Empty;
            txtCargo.Text = string.Empty;
            txtDataNasc.Text = string.Empty;
            txtCPF.Text = string.Empty;
            txtRG.Text = string.Empty;
            txtTelefone.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtEnderecoImage.Text = string.Empty;
            txtUsuario.Text = string.Empty;
            txtSenha.Text = string.Empty;
            txtSenhaNovamente.Text = string.Empty;

            rbtFeminino.Checked = false;
            rbtMasculino.Checked = false;
            picFoto.Image = null;
        }

        private void btnInserirFoto_Click(object sender, EventArgs e)
        {
          
        }
    }
}
