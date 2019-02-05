using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Circo.FormsFinanceiro
{
    public partial class FrmFinanceiro : Form
    {
        public FrmFinanceiro()
        {
            InitializeComponent();
        }

        private void lstPesquisa_Click(object sender, EventArgs e)
        {
            FrmBuscaAltFinanceiro Form = new FrmBuscaAltFinanceiro();
            Form.Show();
        }

        private void btnCad_Click(object sender, EventArgs e)
        {
            FrmCadFinanceiro Form = new FrmCadFinanceiro();
            Form.Show();
        }

        private void btnTudo_Click(object sender, EventArgs e)
        {

        }

    }
}
