using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Projeto_Circo.FormsFinanceiro
{
	public partial class FrmCadFinanceiro : Form
    {
        public FrmCadFinanceiro()
        {
            InitializeComponent();
			rbtNORealizado.Checked = true;
			rbtAtraso.Checked = true;

		}

		private void FrmCadFinanceiro_Load(object sender, EventArgs e)
        {

        }

		private void limparFrmCadFinanceiro()
		{
			txtContratante.Text = string.Empty;
			txtTotalAReceber.Text = string.Empty;
			txtCacheArtista.Text = string.Empty;
			txtPrevisaoPaga.Text = string.Empty;
			txtFormaPag.Text = string.Empty;

			rbtPago.Checked = false;
			rbtRealizado.Checked = false;
			rbtNORealizado.Checked = true;
			rbtAtraso.Checked = true;

			lstPresente.Items.Clear();
			lstConvocado.Items.Clear();

		}

		private void btnTudo_Click(object sender, EventArgs e)
		{
			lstPesquisa.Items.Clear();
			ProjetoCircoEntities db = new ProjetoCircoEntities();

			var espetaculos = db.Espetaculos.Where(s => s.IDEspetaculo > 0);

			foreach (Espetaculos a in espetaculos)
			{
				lstPesquisa.Items.Add(a);
			}
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			lstPesquisa.Items.Clear();
			ProjetoCircoEntities db = new ProjetoCircoEntities();

			var espetaculos = db.Espetaculos.Where(x => x.NMEspetaculo.Contains(txtBuscarEsp.Text));

			foreach (Espetaculos a in espetaculos)
			{
				lstPesquisa.Items.Add(a);
			}
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
				financeiro.CacheArtista = double.TryParse(str, out  tempVal) ? tempVal : (double?)null;

				financeiro.PrevisaoPagamento = txtPrevisaoPaga.Text;
				financeiro.FormaPagamento = txtFormaPag.Text;

				Espetaculos esp = (Espetaculos)lstPesquisa.SelectedItem;

				financeiro.IDEspetaculo = (esp.IDEspetaculo);

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


				foreach (var item in lstPresente.Items)
				{
					Artistas artista = (Artistas)item;

					Pagos x = db.Pagos.Single(s => s.IDArtista == artista.Id && s.IDEspetaculo == financeiro.IDEspetaculo) ;
					x.Pago = false;
					db.SaveChanges();
					
				}

				return true;
			}
			else if (txtContratante.Text  == string.Empty)
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

		private void btnSalvar_Click(object sender, EventArgs e)
		{
			Financeiro financeiro = new Financeiro();
			ProjetoCircoEntities db = new ProjetoCircoEntities();

			if (LoadFinanceiro(financeiro))
			{
				limparFrmCadFinanceiro();
				db.Financeiro.Add(financeiro);
				db.SaveChanges();
				MessageBox.Show("Item de Financeiro salvo com sucesso!", "Mensagem do sistema");
			}
		}

		private void lstPesquisa_Click(object sender, EventArgs e)
		{
			ProjetoCircoEntities db = new ProjetoCircoEntities();

			Espetaculos objEspetaculo = (Espetaculos)lstPesquisa.SelectedItem;
			if (objEspetaculo != null)
			{
				lstConvocado.Items.Clear();
				lstPresente.Items.Clear();

				List<Pagos> lstCon = db.Pagos.Where(x => x.IDEspetaculo == objEspetaculo.IDEspetaculo).ToList();

				foreach (Pagos n in lstCon)
				{
					var aux = db.Artistas.Where(x => x.Id == n.IDArtista).Single();
					lstConvocado.Items.Add(aux);
				}
			}
				
		}

		private void lstConvocado_Click(object sender, EventArgs e)
		{
			if (lstConvocado.SelectedItem != null)
			{
				lstPresente.Items.Add(lstConvocado.SelectedItem);
				lstConvocado.Items.Remove(lstConvocado.SelectedItem);
			}
			
		}

		private void lstPresente_Click(object sender, EventArgs e)
		{
			if(lstPresente.SelectedItem != null)
			{
				lstConvocado.Items.Add(lstPresente.SelectedItem);
				lstPresente.Items.Remove(lstPresente.SelectedItem);
			}
		
		}



	}
}
