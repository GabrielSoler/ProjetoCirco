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
			var financeiro = (Financeiro)lstPesquisa.SelectedItem;
			if (financeiro != null)
			{
				this.Close();
				FrmBuscaAltFinanceiro Form = new FrmBuscaAltFinanceiro(financeiro);
				Form.Show();
			}			
        }

        private void btnCad_Click(object sender, EventArgs e)
        {
            FrmCadFinanceiro Form = new FrmCadFinanceiro();
            Form.Show();
        }

        private void btnTudo_Click(object sender, EventArgs e)
        {
			ProjetoCircoEntities db = new ProjetoCircoEntities();

			lstPesquisa.Items.Clear();

			var financeiro = db.Financeiro.Where(s => s.IDFinanceiro > 0);

			foreach (Financeiro a in financeiro)
			{
				lstPesquisa.Items.Add(a);
			}
		}

		private void FrmFinanceiro_Load(object sender, EventArgs e)
		{

		}

		private void btnBusca_Click(object sender, EventArgs e)
		{
			ProjetoCircoEntities db = new ProjetoCircoEntities();

			lstPesquisa.Items.Clear();

			var financeiro = db.Financeiro.Where(x => x.Contratante.Contains(toolStripTextBoxPesquisa.Text));
			foreach (Financeiro a in financeiro)
			{
				lstPesquisa.Items.Add(a);
			}

		}
	}
}
