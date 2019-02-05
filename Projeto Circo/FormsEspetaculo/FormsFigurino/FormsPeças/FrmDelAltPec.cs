using Projeto_Circo.FormsFigurino.FormsPeças;
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
    public partial class FrmDelAltPec : Form
    {
        public FrmDelAltPec()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

   

        private void btnEditar_Click(object sender, EventArgs e)
        {
            limparFrmDelAltPec();
        }

        private void btnCostureira_Click(object sender, EventArgs e)
        {
            FrmEmail form = new FrmEmail();
            form.Show();
        }

        private void limparFrmDelAltPec()
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

    }
}
