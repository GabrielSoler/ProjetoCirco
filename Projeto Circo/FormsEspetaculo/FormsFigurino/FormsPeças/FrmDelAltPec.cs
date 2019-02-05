using Projeto_Circo.FormsFigurino.FormsPeças;
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
    public partial class FrmDelAltPec : Form
    {
        public FrmDelAltPec()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

   

        private void btnSalvar_Click(object sender, EventArgs e)
        {

        }

        private void btnCostureira_Click(object sender, EventArgs e)
        {
            FrmEmail form = new FrmEmail();
            form.Show();
        }
    }
}
