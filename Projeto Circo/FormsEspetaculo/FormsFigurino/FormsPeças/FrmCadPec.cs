using System;
using System.Linq;
using System.Windows.Forms;

namespace Projeto_Circo.FormsFigurino
{
    public partial class FrmCadPec : Form
    {
		ProjetoCircoEntities db = new ProjetoCircoEntities();


		public FrmCadPec()
        {
            InitializeComponent();
			rbtAtivo.Checked = true;
			rbtSim.Checked = true;
			var aux = db.Coleções.ToList();

			foreach (Coleções n in aux)
			{
				lstColecao.Items.Add(n);
			}

		}



		private void limparFrmCadPec()
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

        private void btnSalvar_Click(object sender, EventArgs e)
        {
			Peças pec = new Peças();

			if (LoadPec(pec))
			{

				var objPec = db.Peças.Where(x => x.CDPeças == pec.CDPeças).SingleOrDefault();

				if(objPec == null)
				{
					db.Peças.Add(pec);
					db.SaveChanges();
					MessageBox.Show("Peça salva com sucesso!", "Mensagem do sistema");
					limparFrmCadPec();

				}
				else{
					MessageBox.Show("Código peça já existente, não aceitamos peça com codigo igual", "Mensagem do sistema");
					txtCodPec.Focus();
				}
			}
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
					string semPonto = txtCodPec.Text.Replace(".","");
					pec.CDPeças = int.TryParse(semPonto, out  tempVal) ? tempVal : default(int);

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
				txtCodPec.Focus();
				MessageBox.Show("PREENCHA o campo Código Peça!!!");
				return false;
			}
			else
			{
				MessageBox.Show("Escolha uma Coleção!!!");
				return false;
			}
		}

		private void btnSair_Click(object sender, EventArgs e)
		{
			this.Close();
		}


	}
}
