using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Circo.FormsArtista
{
    public partial class FrmDelAltArtista : Form
    {
        public FrmDelAltArtista()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            tabControl.SelectTab("tbMedidas");

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            tabControl.SelectTab("tbDadosPessoais");

        }

        private void FrmDelAltArtista_Load(object sender, EventArgs e)
        {
            tabControl.SelectTab("tbDadosPessoais");
        }
    }
}
