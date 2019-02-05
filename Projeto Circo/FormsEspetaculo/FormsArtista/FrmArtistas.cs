using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projeto_Circo.FormsArtista;


namespace Projeto_Circo.FormsArtista
{
    public partial class FrmArtistas : Form
    {
        public FrmArtistas()
        {
            InitializeComponent();
        }

        private void FrmArtistas_Load(object sender, EventArgs e)
        {
            pnlBuscar.BackColor = Color.Transparent;
        }

        private void lstPesquisa_Click(object sender, EventArgs e)
        {
            FrmDelAltArtista Form = new FrmDelAltArtista();
            Form.Show();

        }

        private void lstPesquisa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCad_Click(object sender, EventArgs e)
        {
            FrmCadArtista Form = new FrmCadArtista();
            Form.Show();
        }
    }
}
