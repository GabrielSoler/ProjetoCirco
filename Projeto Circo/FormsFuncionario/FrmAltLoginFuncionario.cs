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
    public partial class FrmAltLoginFuncionario : Form
    {
        public FrmAltLoginFuncionario()
        {
            InitializeComponent();
        }

        private void FrmAltLoginFuncionario_Load(object sender, EventArgs e)
        {
			txtSenha.PasswordChar = '*';
			txtSenhaNovamente.PasswordChar = '*';

		}

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
