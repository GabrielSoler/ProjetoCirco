using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;


namespace Projeto_Circo.FormsFuncionario
{
    public partial class FrmFuncionario : Form
    {
		ProjetoCircoEntities db = new ProjetoCircoEntities();

		public FrmFuncionario()
        {
            InitializeComponent();
        }

		Funcionario funcionario = new Funcionario();

        private void lstPesquisa_Click(object sender, EventArgs e)
        {
			var funcionario = (Funcionario)lstPesquisa.SelectedItem;
			if (funcionario != null)
			{
				this.Close();
				FrmDelAltFuncionario Form = new FrmDelAltFuncionario(funcionario);
				Form.Show();
			}
		}

        private void btnCad_Click(object sender, EventArgs e)
        {
            FrmCadFuncionario Form = new FrmCadFuncionario();
            Form.Show();
        }

		private void btnTudo_Click(object sender, EventArgs e)
		{
			lstPesquisa.Items.Clear();

			var fun = db.Funcionario.Where(x => x.NMFuncionario.Contains(toolStripTextBoxPesquisa.Text));
			foreach (Funcionario a in fun)
			{
				lstPesquisa.Items.Add(a);
			}
		}
	}
}
