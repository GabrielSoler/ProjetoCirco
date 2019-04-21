using System;
using System.Linq;
using System.Windows.Forms;

namespace Projeto_Circo.FormsFigurino
{
    public partial class FrmCadColecoes : Form
    {
		ProjetoCircoEntities db = new ProjetoCircoEntities();


		public FrmCadColecoes()
        {
            InitializeComponent();
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void limparFrmCadColecoes()
        {

            txtNomeCole.Text = string.Empty;
            txtDataCria.Text = string.Empty;
            cboCostu.Items.Clear();
            cboCostu.Text = string.Empty;
            txtTeciAvi.Text = string.Empty;
            txtQtdPecUnic.Text = string.Empty;
            txtNotas.Text = string.Empty;

            rbtInativo.Checked = false;
            rbtAtivo.Checked = false;

        }

		private void btnSalvar_Click(object sender, EventArgs e)
		{

			Coleções col = new Coleções();

			if (LoadCol(col))
			{
				limparFrmCadColecoes();
				db.Coleções.Add(col);
				db.SaveChanges();
				MessageBox.Show("Coleção salva com sucesso!", "Mensagem do sistema");
			}

		}

		public bool LoadCol(Coleções colecao)
		{
			if (txtNomeCole.Text != string.Empty)
			{
				colecao.NMColecao = txtNomeCole.Text;
				colecao.DTCricao = txtDataCria.Text;
				colecao.CostureiraResponsavel = cboCostu.Text;
				colecao.TecidosEAviamentos = txtTeciAvi.Text;
				colecao.QtdPeçasUnicas = int.TryParse(txtQtdPecUnic.Text, out var tempVal) ? tempVal : (int?)null;

				colecao.Notas = txtNotas.Text;

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
