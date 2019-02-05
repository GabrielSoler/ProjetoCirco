using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Circo.FormsFuncionario
{
    public partial class FrmCadFuncionario : Form
    {
        public FrmCadFuncionario()
        {
            InitializeComponent();
        }

        private void btnMudaSenha_Click(object sender, EventArgs e)
        {
            FrmAltLoginFuncionario Form = new FrmAltLoginFuncionario();
            Form.Show();
        }
    }
}
