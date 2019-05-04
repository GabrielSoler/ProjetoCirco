using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Circo
{
	public partial class FrmRelatorio : Form
	{
		public FrmRelatorio()
		{
			InitializeComponent();
			panel3.Height = 236;

		}

		private void btnBuscar_Click(object sender, EventArgs e)
		{
			lstBuscar.Items.Clear();
			ProjetoCircoEntities db = new ProjetoCircoEntities();

			var espetaculos = db.Espetaculos.Where(x => x.NMEspetaculo.Contains(txtBuscar.Text));

			foreach (Espetaculos a in espetaculos)
			{
				lstBuscar.Items.Add(a);
			}
		}

		private void btnTudo_Click(object sender, EventArgs e)
		{
			lstBuscar.Items.Clear();
			ProjetoCircoEntities db = new ProjetoCircoEntities();

			var espetaculos = db.Espetaculos.Where(s => s.IDEspetaculo > 0);

			foreach (Espetaculos a in espetaculos)
			{
				lstBuscar.Items.Add(a);
			}
		}

		private void lstBuscar_Click(object sender, EventArgs e)
		{
			ProjetoCircoEntities db = new ProjetoCircoEntities();

			Espetaculos objEspetaculo = (Espetaculos)lstBuscar.SelectedItem;
			if (objEspetaculo != null)
				AtualizarFrmRelatorio(db, objEspetaculo.IDEspetaculo);

		}


		public void AtualizarFrmRelatorio(ProjetoCircoEntities db, int id)
		{
			txtDtEsp.Text = string.Empty;
			txtNMEsp.Text = string.Empty;

			lstCol.Items.Clear();
			lstArt.Items.Clear();
			lstPec.Items.Clear();
			lstLocal.Items.Clear();

			Espetaculos a = db.Espetaculos.Where(x => x.IDEspetaculo == id).Single();
			List<Artistas> lstArtistas = db.Artistas.ToList();
			List<Peças> lstPecas = db.Peças.ToList();

			txtDtEsp.Text = a.DTEspetaculo;
			txtNMEsp.Text = a.NMEspetaculo;

			foreach (LocalEspetaculo n in a.LocalEspetaculo)
			{
				var aux = db.Local.Where(x => x.IDLocal == n.IDLocal).Single();
				lstLocal.Items.Add(aux);
			}

			foreach (Figurino n in a.Figurino)
			{
				var aux = db.Peças.Where(x => x.CDPeças == n.IDPec).Single();
				lstPec.Items.Add(aux);

				var aux2 = db.Coleções.Where(x => x.IDColecao == aux.IDColecao).Single();	
				lstCol.Items.Add(aux2);		
			}

			foreach (Pagos n in a.Pagos)
			{
				var aux = db.Artistas.Where(x => x.Id == n.IDArtista).Single();
				lstArt.Items.Add(aux);
			}

			var lst = lstCol.Items;
		}

		private void exibirCalender_Click(object sender, EventArgs e)
		{
			if (monthCalendar.Visible)
			{
				monthCalendar.Visible = false;
				exibirCalender.Text = "Exibir Calendário";
				panel3.Height = 236;

			}
			else
			{
				monthCalendar.Visible = true;
				exibirCalender.Text = "Esconder Calendário";
				panel3.Height = 403;
			}
		}

		private void btnData_Click(object sender, EventArgs e)
		{
			lstBuscar.Items.Clear();
			ProjetoCircoEntities db = new ProjetoCircoEntities();

			var espetaculos = db.Espetaculos.Where(x => x.DTEspetaculo.Contains(txtBuscaDt.Text));

			foreach (Espetaculos a in espetaculos)
			{
				lstBuscar.Items.Add(a);
			}


		}

		private void monthCalendar_DateChanged(object sender, DateRangeEventArgs e)
		{
			txtBuscaDt.Text = monthCalendar.SelectionStart.ToString("dd/MM/yyyy");
		}

		private void lstBuscar_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
	}
}
