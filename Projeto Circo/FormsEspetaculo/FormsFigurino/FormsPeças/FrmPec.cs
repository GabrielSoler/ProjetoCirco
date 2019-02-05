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
        public FrmPec()
        {
            InitializeComponent();
        }

        private void lstPesquisa_Click(object sender, EventArgs e)
        {
            FrmDelAltPec Form = new FrmDelAltPec();
            Form.Show();
        }

        private void btnCad_Click(object sender, EventArgs e)
        {
            FrmCadPec Form = new FrmCadPec();
            Form.Show();
        }

        private void FrmPec_Load(object sender, EventArgs e)
        {

        }
    }
}
