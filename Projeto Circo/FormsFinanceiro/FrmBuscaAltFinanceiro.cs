using System;
using System.Linq;
using System.Windows.Forms;

namespace Projeto_Circo.FormsFinanceiro
{
	public partial class FrmBuscaAltFinanceiro : Form
    {
		ProjetoCircoEntities db = new ProjetoCircoEntities();
		Financeiro a;

		public FrmBuscaAltFinanceiro(Financeiro fin )
        {
			InitializeComponent();
			InjetarDados(fin);
			a = fin;
		}

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


		public bool LoadFinanceiro(Financeiro financeiro)
		{
			if ((txtContratante.Text != string.Empty) && (txtTotalAReceber.Text != string.Empty))
			{
				ProjetoCircoEntities db = new ProjetoCircoEntities();

				financeiro.Contratante = txtContratante.Text;

				var str = txtTotalAReceber.Text.Replace("R$", "").Replace(".", ",").Trim();

				financeiro.TotalReceber = double.TryParse(str, out var tempVal) ? tempVal : (double?)null;

				str = txtCacheArtista.Text.Replace("R$", "").Replace(".", ",").Trim();
				financeiro.CacheArtista = double.TryParse(str, out tempVal) ? tempVal : (double?)null;

				financeiro.PrevisaoPagamento = txtPrevisaoPaga.Text;
				financeiro.FormaPagamento = txtFormaPag.Text;

				if (rbtPago.Checked)
				{
					financeiro.Status = "Pago";
				}
				else if (rbtAtraso.Checked)
				{
					financeiro.Status = "Atraso";
				}

				if (rbtRealizado.Checked)
				{
					financeiro.Realizado = true;
				}
				else if (rbtNORealizado.Checked)
				{
					financeiro.Realizado = false;
				}


				foreach (var item in lstPendente.Items)
				{
					Pagos pag = (Pagos)item;
					Pagos x = db.Pagos.Single(s => s.IDArtista == pag.IDArtista && s.IDEspetaculo == financeiro.IDEspetaculo);
					x.Pago = false;
					db.SaveChanges();

				}

				foreach (var item in lstPago.Items)
				{
					Pagos pag = (Pagos)item;

					Pagos x = db.Pagos.Single(s => s.IDArtista == pag.IDArtista && s.IDEspetaculo == financeiro.IDEspetaculo);
					x.Pago = true;
					db.SaveChanges();
				}

				return true;
			}
			else if (txtContratante.Text == string.Empty)
			{
				MessageBox.Show("PREENCHA  o campo CONTRATANTE!!!");
				txtContratante.Focus();
				return false;
			}
			else
			{
				MessageBox.Show("PREENCHA o campo Total a receber!!!");
				txtTotalAReceber.Focus();
				return false;
			}

		}

		public void InjetarDados(Financeiro financeiro)
		{
			if (financeiro != null)
			{
				ProjetoCircoEntities db = new ProjetoCircoEntities();

				txtContratante.Text = financeiro.Contratante;
				txtTotalAReceber.Text = financeiro.TotalReceber.ToString();
				txtCacheArtista.Text = financeiro.CacheArtista.ToString();
				txtPrevisaoPaga.Text = financeiro.PrevisaoPagamento;
				txtFormaPag.Text = financeiro.FormaPagamento;
				txtEspe.Text = db.Espetaculos.Where(x => x.IDEspetaculo == financeiro.IDEspetaculo).Select(s => s.NMEspetaculo).SingleOrDefault();


				if (financeiro.Realizado == true)
				{
					rbtRealizado.Checked = true;
					rbtNORealizado.Checked = false;
				}
				else
				{
					rbtRealizado.Checked = false;
					rbtNORealizado.Checked = true;
				}

				if (financeiro.Status == "Pago")
				{
					rbtPago.Checked = true;
					rbtAtraso.Checked = false;
				}
				else
				{
					rbtPago.Checked = false;
					rbtAtraso.Checked = true;
				}

				var lstPen = db.Pagos.Where(s => s.IDEspetaculo == financeiro.IDEspetaculo &&  s.Pago == false).ToList();
				var lstPag = db.Pagos.Where(s => s.IDEspetaculo == financeiro.IDEspetaculo && s.Pago == true).ToList();

				foreach (Pagos a in lstPen)
				{
					lstPendente.Items.Add(a);
				}

				foreach (Pagos a in lstPag)
				{
					lstPago.Items.Add(a);
				}
			}
		}

		public void LimparArtista()
		{
			txtContratante.Text = string.Empty;
			txtTotalAReceber.Text = string.Empty;
			txtCacheArtista.Text = string.Empty;
			txtPrevisaoPaga.Text = string.Empty;
			txtFormaPag.Text = string.Empty;

			rbtPago.Checked = false;
			rbtAtraso.Checked = true;

			rbtRealizado.Checked = false;
			rbtNORealizado.Checked = true;

			lstPendente.Items.Clear();
			lstPago.Items.Clear();

		}

		private void lstPago_Click(object sender, EventArgs e)
		{
			if (lstPago.SelectedItem != null)
			{
				lstPendente.Items.Add(lstPago.SelectedItem);
				lstPago.Items.Remove(lstPago.SelectedItem);
			}
		}

		private void lstPendente_Click(object sender, EventArgs e)
		{
			if (lstPendente.SelectedItem != null)
			{
				lstPago.Items.Add(lstPendente.SelectedItem);
				lstPendente.Items.Remove(lstPendente.SelectedItem);
			}
		}

		private void btnEditar_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show("Tem certeza que deseja alterar? ", "Mensagem do Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (result == DialogResult.Yes)
			{
				Financeiro x = db.Financeiro.Single(s => s.IDFinanceiro == a.IDFinanceiro);
				if (LoadFinanceiro(x))
				{
					db.SaveChanges();
					MessageBox.Show("CADASTRO DO FINANCEIRO ALTERADO COM SUCESSO", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}

			}
		}
	}
}
