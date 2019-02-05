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
    public partial class FrmDelAltFuncionario : Form
    {
        public FrmDelAltFuncionario()
        {
            InitializeComponent();
            limparFrmDelAltFuncionario();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void limparFrmDelAltFuncionario()
        {
            txtNome.Text = string.Empty;
            txtCargo.Text = string.Empty;
            txtDataNasc.Text = string.Empty;
            txtCpf.Text = string.Empty;
            txtRG.Text = string.Empty;
            txtTelefone.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtEnderecoImagem.Text = string.Empty;
            rbtFeminino.Checked = false;
            rbtMasculino.Checked = false;
            picFoto.Image = null;
        }

    }
}
