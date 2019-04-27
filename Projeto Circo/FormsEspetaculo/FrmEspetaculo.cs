using Projeto_Circo.FormsEspetaculo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Projeto_Circo
{
	public partial class FrmEspetaculo : Form
	{
		public FrmEspetaculo()
		{
			InitializeComponent();

			ProjetoCircoEntities db = new ProjetoCircoEntities();
			AtualizarFrmEspetaculo(db);

		}

		private void btnInserirLocal_Click(object sender, EventArgs e)
		{
			FrmLocal frm = new FrmLocal();
			frm.Show();
		}


		public void AtualizarFrmEspetaculo(ProjetoCircoEntities db)
		{
			List<Coleções> lstCo = db.Coleções.ToList();
			List<Artistas> lstArt = db.Artistas.ToList();
			List<Peças> lstPecas = db.Peças.ToList();
			List<Local> lstLoc = db.Local.ToList();

			lstCol.Items.Clear();
			lstArtistas.Items.Clear();
			lstPec.Items.Clear();
			lstLocal.Items.Clear();

			foreach (Coleções n in lstCo)
			{
				lstCol.Items.Add(n);
			}

			foreach (Artistas n in lstArt)
			{
				lstArtistas.Items.Add(n);
			}

			foreach (Peças n in lstPecas)
			{
				lstPec.Items.Add(n);
			}

			foreach (Local n in lstLoc)
			{
				lstLocal.Items.Add(n);
			}
		}

		private void btnExcluirLocal_Click(object sender, EventArgs e)
		{
			var deletados = lstLocal.SelectedItems;
			DialogResult result = MessageBox.Show("Tem certeza que deseja excluir? ", "Mensagem do Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (result == DialogResult.Yes)
			{
				ProjetoCircoEntities db = new ProjetoCircoEntities();

				foreach (Local l in deletados)
				{
					db.Local.Remove(db.Local.Single(x => x.IDLocal == l.IDLocal));

				}
				db.SaveChanges();
				AtualizarFrmEspetaculo(db);
				MessageBox.Show("CADASTRO DE LOCAL EXCLUIDO COM SUCESSO", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private void btnAtualizar_Click(object sender, EventArgs e)
		{
			ProjetoCircoEntities db = new ProjetoCircoEntities();
			lstLocal.Items.Clear();
			List<Local> lstLoc = db.Local.ToList();

			foreach (Local n in lstLoc)
			{
				lstLocal.Items.Add(n);
			}
		}

		private void btnSalvarEspetaculo_Click(object sender, EventArgs e)
		{
			Espetaculos espetaculos = new Espetaculos();
			ProjetoCircoEntities db = new ProjetoCircoEntities();

			if (LoadEspetaculos(espetaculos))
			{
				MessageBox.Show("Espetaculo salvo com sucesso!", "Mensagem do sistema");
			}

		}


		private bool LoadEspetaculos(Espetaculos es)
		{
			ProjetoCircoEntities db = new ProjetoCircoEntities();

			es.NMEspetaculo = txtNMEspetaculo.Text;
			es.DTEspetaculo = txtDTHR.Text;

			db.Espetaculos.Add(es);
			db.SaveChanges();


			ListBox.SelectedObjectCollection listaCol = lstCol.SelectedItems;
			ListBox.SelectedObjectCollection listLocal = lstLocal.SelectedItems;
			ListBox.SelectedObjectCollection listArtista = lstArtistas.SelectedItems;
			ListBox.SelectedObjectCollection listaPec = lstPec.SelectedItems;

			try
			{
				foreach (Artistas art in listArtista)
				{
					Pagos f = new Pagos
					{
						IDArtista = art.Id,
						IDEspetaculo = es.IDEspetaculo,
						Pago = false
					};
					db.Pagos.Add(f);
				}
				db.SaveChanges();


				foreach (Local loc in listLocal)
				{
					LocalEspetaculo e = new LocalEspetaculo
					{
						IDEspetaculo = es.IDEspetaculo,
						IDLocal = loc.IDLocal
					};
					db.LocalEspetaculo.Add(e);
				}
				db.SaveChanges();


				foreach (Peças pe in listaPec)
				{
					Figurino f = new Figurino
					{
						IDPec = pe.CDPeças,
						IDEspetaculo = es.IDEspetaculo
					};
					db.Figurino.Add(f);
				}
				db.SaveChanges();
			}catch(Exception ex)
			{
				MessageBox.Show("Erro ao salvar :( " + ex.Message);
				return false;
			} 
			return true;
		}

		private void lstCol_SelectedIndexChanged(object sender, EventArgs e)
		{
			ProjetoCircoEntities db = new ProjetoCircoEntities();

			ListBox.SelectedObjectCollection col = lstCol.SelectedItems;
			lstPec.Items.Clear();
			foreach (Coleções c in col)
			{			
				List<Peças> lstP = db.Peças.Where(x=>x.IDColecao == c.IDColecao ).ToList();
				foreach (Peças busca in lstP)
				{
					lstPec.Items.Add(busca);
				}
			}
		}
	}
}
