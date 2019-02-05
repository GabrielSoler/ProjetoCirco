using Projeto_Circo.FormsArtista;
using Projeto_Circo.FormsFigurino;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Circo
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            var Form = new FrmRelatorio();
            Form.Show();
        }

        private void btnEspetaculo_Click(object sender, EventArgs e)
        {
            var Form = new FrmEspetaculo();
            Form.Show();
        }

        private void btnArtista_Click(object sender, EventArgs e)
        {
            FrmArtistas Form = new FrmArtistas();
            Form.Show();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnFigurino_Click(object sender, EventArgs e)
        {
            FrmFigurino Form = new FrmFigurino();
            Form.Show();
        }
    }
}
