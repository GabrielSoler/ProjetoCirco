using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Circo.FormsFigurino
{
    public partial class FrmCadPec : Form
    {
        public FrmCadPec()
        {
            InitializeComponent();
        }

        private void btnSair_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void limparFrmCadPec()
        {
            txtEnderecoImage.Text = string.Empty;
            txtNotas.Text = string.Empty;
            txtCodPec.Text = string.Empty;
            txtQtdComp.Text = string.Empty;


            chkAtivo.Checked = false;
            chkInativo.Checked = false;

            rbtSim.Checked = false;
            rbtNao.Checked = false;
            lstColecao.Items.Clear();
            picFoto.Image = null;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            limparFrmCadPec();
        }
    }
}
