using Projeto_Circo.FormsFigurino.FormsPeças;
using System;

using System.Linq;

using System.Windows.Forms;

namespace Projeto_Circo.FormsFigurino
{
	public partial class FrmDelAltPec : Form
	{

		ProjetoCircoEntities db = new ProjetoCircoEntities();
		Peças a;


		public FrmDelAltPec(Peças pec)
		{
			InitializeComponent();
			InjetarDados(pec);
			a = pec;

			var aux = db.Coleções.Where(x=>x.IDColecao == pec.IDColecao).ToList();

			foreach (Coleções n in aux)
			{
				lstColecao.Items.Add(n);
			}
		}

		private void btnSair_Click(object sender, EventArgs e)
		{
			this.Close();
		}



		private void btnEditar_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show("Tem certeza que deseja alterar? ", "Mensagem do Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (result == DialogResult.Yes)
			{
				Peças x = db.Peças.Single(s => s.CDPeças == a.CDPeças);
				if (LoadPec(x))
				{
					db.SaveChanges();
					MessageBox.Show("CADASTRO DE PEÇA ALTERADO COM SUCESSO", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}

			}
		}

		private void btnCostureira_Click(object sender, EventArgs e)
		{
			FrmEmail form = new FrmEmail();
			form.Show();
		}

		private void limparFrmDelAltPec()
		{
			txtNotas.Text = string.Empty;
			txtCodPec.Text = string.Empty;
			txtQtdComp.Text = string.Empty;


			rbtAtivo.Checked = false;
			rbtInativo.Checked = false;

			rbtSim.Checked = false;
			rbtNao.Checked = false;
			lstColecao.Items.Clear();
			picFoto.Image = null;
		}

		private void btnInserirImage_Click(object sender, EventArgs e)
		{
			OpenFileDialog file = new OpenFileDialog();
			file.Filter = "jpg|*.jpg";
			if (file.ShowDialog() == DialogResult.OK)
			{
				picFoto.ImageLocation = file.FileName;
			}
		}


		public bool LoadPec(Peças pec)
		{
			if (txtCodPec.MaskFull && lstColecao.SelectedItem != null)
			{
				pec.QtdComponentes = int.TryParse(txtQtdComp.Text, out var tempVal) ? tempVal : (int?)null;

				pec.Notas = txtNotas.Text;

				pec.IDColecao = ((Coleções)lstColecao.SelectedItem).IDColecao;

				if (txtCodPec.MaskFull)
				{
					string semPonto = txtCodPec.Text.Replace(".", "");
					pec.CDPeças = int.TryParse(semPonto, out tempVal) ? tempVal : default(int);

				}
				if (rbtAtivo.Checked)
				{
					pec.Situacao = true;
				}
				else if (rbtInativo.Checked)
				{
					pec.Situacao = false;
				}

				if (rbtSim.Checked)
				{
					pec.Reparo = true;
				}
				else if (rbtNao.Checked)
				{
					pec.Reparo = false;
				}

				pec.AnexoCroquis = picFoto.ImageLocation;

				return true;
			}
			else if (!txtCodPec.MaskFull)
			{
				MessageBox.Show("PREENCHA o campo Código Peça!!!");
				return false;
			}
			else
			{
				MessageBox.Show("Escolha uma Coleção!!!");
				return false;
			}
		}

		public void InjetarDados(Peças pec)
		{
			if (pec != null)
			{
				txtCodPec.Text = pec.CDPeças.ToString();
				txtNotas.Text = pec.Notas;
				txtQtdComp.Text = pec.QtdComponentes.ToString();

				//CARREGA A lstColecao NO CONSTRUTOR

				if (pec.Situacao == true)
				{
					rbtAtivo.Checked = true;
					rbtInativo.Checked = false;
				}
				else
				{
					rbtAtivo.Checked = false;
					rbtInativo.Checked = true;
				}

				if (pec.Reparo == true)
				{
					rbtSim.Checked = true;
					rbtNao.Checked = false;
				}
				else
				{
					rbtSim.Checked = false;
					rbtNao.Checked = true;
				}

				picFoto.ImageLocation = pec.AnexoCroquis;

			}
		}

		private void btnExcluir_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show("Tem certeza que deseja excluir? ", "Mensagem do Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (result == DialogResult.Yes)
			{
				limparFrmDelAltPec();
				db.Peças.Remove(db.Peças.Single(x => x.CDPeças == a.CDPeças));
				db.SaveChanges();
				MessageBox.Show("CADASTRO DE PEÇA EXCLUIDO COM SUCESSO", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
				FrmPec frmPec = new FrmPec();
				frmPec.Show();
				this.Close();
			}
		}
	}
}
