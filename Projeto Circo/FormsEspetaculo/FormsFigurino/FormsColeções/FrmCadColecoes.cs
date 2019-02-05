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
    public partial class FrmCadColecoes : Form
    {
        public FrmCadColecoes()
        {
            InitializeComponent();
        }

        private void FrmCadColecoes_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Enter(object sender, EventArgs e)
        {
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void limparFrmCadColecoes()
        {

            txtNomeCole.Text = string.Empty;
            txtDataCria.Text = string.Empty;
            cboCostu.Items.Clear();
            cboCostu.Text = string.Empty;
            txtTeciAvi.Text = string.Empty;
            txtQtdPecUnic.Text = string.Empty;
            txtNotas.Text = string.Empty;

            rbtInativo.Checked = false;
            rbtAtivo.Checked = false;

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            limparFrmCadColecoes();
        }
    }
}
