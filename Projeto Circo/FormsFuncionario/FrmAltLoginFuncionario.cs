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
		ProjetoCircoEntities db = new ProjetoCircoEntities();
		Funcionario a;


		public FrmAltLoginFuncionario(Funcionario funcionario)
		{
			InitializeComponent();
			a = funcionario;
			LimparFrmAltLoginFuncionario();
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

		private void LimparFrmAltLoginFuncionario()
		{
			txtUsuario.Text = string.Empty;
			txtSenha.Text = string.Empty;
			txtSenhaNovamente.Text = string.Empty;

		}

		private void btnEditar_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show("Tem certeza que deseja alterar? ", "Mensagem do Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (result == DialogResult.Yes)
			{
				Funcionario x = db.Funcionario.Single(s => s.IDFuncionario == a.IDFuncionario);
				if (LoadLoginSenha(x))
				{
					db.SaveChanges();
					MessageBox.Show("CADASTRO DO FUNCIONÁRIO ALTERADO COM SUCESSO", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
					this.Close();

				}
			}
		}

		private bool LoadLoginSenha(Funcionario x)
		{
			if (txtSenha.Text == txtSenhaNovamente.Text)
			{
				x.Usuario = txtUsuario.Text;
				x.Senha = txtUsuario.Text;
				return true;

			}
			return false;
		}
	}
}