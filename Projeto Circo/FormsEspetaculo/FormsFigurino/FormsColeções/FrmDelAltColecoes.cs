using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Projeto_Circo.FormsFigurino
{
	public partial class FrmDelAltColecoes : Form
	{

		ProjetoCircoEntities db = new ProjetoCircoEntities();
		Coleções c;

		public FrmDelAltColecoes(Coleções col)
		{
			InitializeComponent();
			InjetarDados(col);
			c = col;
		}

		public Image byteArrayToImage(byte[] imageByteArray)
		{
			Image image;
			using (MemoryStream stream = new MemoryStream(imageByteArray, 0, imageByteArray.Length))
			{
				stream.Write(imageByteArray, 0, imageByteArray.Length);
				image = Image.FromStream(stream, true);
			}
			return image;
		}

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void limparFrmDelAltColecoes()
		{

			txtNomeCole.Text = string.Empty;
			txtDataCria.Text = string.Empty;
			txtCostuResp.Text = string.Empty;
			txtTeciAvi.Text = string.Empty;
			txtQtdPecUnic.Text = string.Empty;
			txtNotas.Text = string.Empty;

			rbtInativo.Checked = false;
			rbtAtivo.Checked = false;

		}

		private void btnEditar_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show("Tem certeza que deseja alterar? ", "Mensagem do Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (result == DialogResult.Yes)
			{
				Coleções x = db.Coleções.Single(s => s.IDColecao == c.IDColecao);
				LoadCol(x);

				db.SaveChanges();
				MessageBox.Show("CADASTRO DA COLEÇÃO ALTERADO COM SUCESSO", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		public void InjetarDados(Coleções colecao)
		{
			if (colecao != null)
			{
				txtNomeCole.Text = colecao.NMColecao;
				txtDataCria.Text = colecao.DTCricao;
				txtCostuResp.Text = colecao.CostureiraResponsavel;
				txtTeciAvi.Text = colecao.TecidosEAviamentos;
				txtQtdPecUnic.Text = colecao.QtdPeçasUnicas.ToString();
				txtNotas.Text = colecao.Notas;
				if (colecao.Situacao == true)
				{
					rbtAtivo.Checked = true;
					rbtInativo.Checked = false;
				}
				else
				{
					rbtAtivo.Checked = false;
					rbtInativo.Checked = true;
				}
			}
		}

		public bool LoadCol(Coleções colecao)
		{
			if (txtNomeCole.Text != string.Empty)
			{
				colecao.NMColecao = txtNomeCole.Text;
				colecao.DTCricao = txtDataCria.Text;
				colecao.CostureiraResponsavel = txtCostuResp.Text;
				colecao.TecidosEAviamentos= txtTeciAvi.Text;
				colecao.QtdPeçasUnicas = int.TryParse(txtQtdPecUnic.Text, out var tempVal) ? tempVal : (int?)null;

				colecao.Notas= txtNotas.Text;

				if (rbtAtivo.Checked)
				{
					colecao.Situacao = true;
				}
				else if (rbtInativo.Checked)
				{
					colecao.Situacao = false;
				}
				return true;
			}
			else
			{
				MessageBox.Show("PREENCHA o campo NOME COLEÇÃO!!!");
				return false;
			}

		}
	}
}
