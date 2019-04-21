using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;


namespace Projeto_Circo.FormsArtista
{
	public partial class FrmArtistas : Form
	{
		ProjetoCircoEntities db = new ProjetoCircoEntities();

		public FrmArtistas()
		{
			InitializeComponent();
		}

		Artistas artista = new Artistas();

		private void FrmArtistas_Load(object sender, EventArgs e)
		{
			pnlBuscar.BackColor = Color.Transparent;
		}

		private void lstPesquisa_Click(object sender, EventArgs e)
		{
			var artista = (Artistas)lstPesquisa.SelectedItem;
			if (artista != null)
			{
				this.Close();
				FrmDelAltArtista Form = new FrmDelAltArtista(artista);
				Form.Show();
			}

		}

		private void btnCad_Click(object sender, EventArgs e)
		{
			FrmCadArtista Form = new FrmCadArtista();
			Form.Show();
		}

		private void btnTudo_Click(object sender, EventArgs e)
		{
			lstPesquisa.Items.Clear();

			var artistas = db.Artistas.Where(s => s.Id > 0);

			foreach (Artistas a in artistas)
			{
				lstPesquisa.Items.Add(a);
			}
		}

		private void btnBusca_Click(object sender, EventArgs e)
		{
			lstPesquisa.Items.Clear();

			var artistas = db.Artistas.Where(x=>x.Nome.Contains(toolStripTextBoxPesquisa.Text));
			foreach (Artistas a in artistas)
			{
				lstPesquisa.Items.Add(a);
			}

		}

	}
}
