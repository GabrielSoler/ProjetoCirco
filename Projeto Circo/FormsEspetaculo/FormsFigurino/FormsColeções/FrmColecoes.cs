using System;
using System.Windows.Forms;
using System.Linq;

namespace Projeto_Circo.FormsFigurino
{
	public partial class FrmColecoes : Form
    {

		ProjetoCircoEntities db = new ProjetoCircoEntities();

		public FrmColecoes()
        {
            InitializeComponent();
        }

		Coleções colecoes = new Coleções();

		private void lstPesquisa_Click(object sender, EventArgs e)
        {

			var colecoes = (Coleções)lstPesquisa.SelectedItem;
			if (colecoes != null)
			{
				this.Close();
				FrmDelAltColecoes Form = new FrmDelAltColecoes(colecoes);
				Form.Show();
			}
		}

        private void btnCad_Click(object sender, EventArgs e)
        {
            FrmCadColecoes Form = new FrmCadColecoes();
            Form.Show();
        }

		private void btnBusca_Click(object sender, EventArgs e)
		{
			lstPesquisa.Items.Clear();

			var colecoes = db.Coleções.Where(x => x.NMColecao.Contains(toolStripTextBoxPesquisa.Text));
			foreach (Coleções a in colecoes)
			{
				lstPesquisa.Items.Add(a);
			}

		}

		private void btnTudo_Click(object sender, EventArgs e)
		{
			lstPesquisa.Items.Clear();

			var colecoes = db.Coleções.Where(s => s.IDColecao > 0);

			foreach (Coleções a in colecoes)
			{
				lstPesquisa.Items.Add(a);
			}
		}
	}
}
