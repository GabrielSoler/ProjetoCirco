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
    public partial class FrmColecoes : Form
    {
        public FrmColecoes()
        {
            InitializeComponent();
        }

        private void lstPesquisa_Click(object sender, EventArgs e)
        {
            FrmDelAltColecoes Form = new FrmDelAltColecoes();
            Form.Show();
        }

        private void btnCad_Click(object sender, EventArgs e)
        {
            FrmCadColecoes Form = new FrmCadColecoes();
            Form.Show();
        }
    }
}
