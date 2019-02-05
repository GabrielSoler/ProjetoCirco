using Projeto_Circo.FormsFinanceiro;
using Projeto_Circo.FormsFuncionario;
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
    public partial class FrmMenuADM : Form
    {
        public FrmMenuADM()
        {
            InitializeComponent();
        }

        private void btnFuncionario_Click(object sender, EventArgs e)
        {
            FrmFuncionario form = new FrmFuncionario();
            form.Show();
        }

        private void btnFinanceiro_Click(object sender, EventArgs e)
        {
            FrmFinanceiro form = new FrmFinanceiro();
            form.Show();
        }
    }
}
