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
    public partial class FrmDelAltColecoes : Form
    {
        public FrmDelAltColecoes()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void limparFrmDelAltColecoes()
        {

            txtNomeCole.Text = string.Empty;
            txtDataCria.Text = string.Empty;
            txtCostuResp.Text = string.Empty;
            txtTeciAvi.Text = string.Empty;
            txtQtdPecUnic.Text = string.Empty;
            txtNotas.Text = string.Empty;

            rbtInativo.Checked = false;
            rbtAtivo.Checked = false;

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            limparFrmDelAltColecoes();
        }
    }
}
