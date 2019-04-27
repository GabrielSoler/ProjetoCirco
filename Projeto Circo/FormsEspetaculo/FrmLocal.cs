using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Projeto_Circo.FormsEspetaculo
{
	public partial class FrmLocal : Form
	{
		ProjetoCircoEntities db = new ProjetoCircoEntities();

		public FrmLocal()
		{
			InitializeComponent();
			
		}

		private void btnSair_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnInserir_Click(object sender, EventArgs e)
		{

			Local local = new Local();

			local.NMLocal = txtEspetaculo.Text;
			txtEspetaculo.Text = string.Empty;

			db.Local.Add(local);
			db.SaveChanges();
			MessageBox.Show("Local salvo com sucesso!", "Mensagem do sistema");
			this.Close();		
		}

	}
}
