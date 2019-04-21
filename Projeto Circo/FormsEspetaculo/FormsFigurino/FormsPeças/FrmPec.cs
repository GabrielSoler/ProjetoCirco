using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Circo.FormsFigurino
{
    public partial class FrmPec : Form
    {
		ProjetoCircoEntities db = new ProjetoCircoEntities();
		Peças pec = new Peças();


		public FrmPec()
        {
            InitializeComponent();
        }

        private void lstPesquisa_Click(object sender, EventArgs e)
        {
			var pec = (Peças)lstPesquisa.SelectedItem;
			if (pec != null)
			{
				this.Close();
				FrmDelAltPec Form = new FrmDelAltPec(pec);
				Form.Show();
			}
		}

        private void btnCad_Click(object sender, EventArgs e)
        {
            FrmCadPec Form = new FrmCadPec();
            Form.Show();
        }

        private void FrmPec_Load(object sender, EventArgs e)
        {

        }

		private void btnTudo_Click(object sender, EventArgs e)
		{
			lstPesquisa.Items.Clear();

			var pecs = db.Peças.Where(s => s.CDPeças > 0);

			foreach (Peças a in pecs)
			{
				lstPesquisa.Items.Add(a);
			}
		}

		private void btnBusca_Click(object sender, EventArgs e)
		{
			lstPesquisa.Items.Clear();

			toolStripTextBoxPesquisa.Text = toolStripTextBoxPesquisa.Text.Replace(".", "");

			int? cdPec =int.TryParse(toolStripTextBoxPesquisa.Text, out var tempVal) ? tempVal : (int?)null;
			var pecs = db.Peças.Where(x => x.CDPeças == cdPec);
			foreach (Peças a in pecs)
			{
				lstPesquisa.Items.Add(a);
			}
		}
	}
}
