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
    public partial class FrmFigurino : Form
    {
        public FrmFigurino()
        {
            InitializeComponent();
        }

        private void btnColecao_Click(object sender, EventArgs e)
        {
            FrmColecoes Form = new FrmColecoes();
            Form.Show();
        }

        private void btnPec_Click(object sender, EventArgs e)
        {
            FrmPec Form = new FrmPec();
            Form.Show();
        }
    }
}
