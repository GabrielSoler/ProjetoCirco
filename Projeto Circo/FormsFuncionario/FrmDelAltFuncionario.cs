using System;
using System.Linq;
using System.Windows.Forms;

namespace Projeto_Circo.FormsFuncionario
{
	public partial class FrmDelAltFuncionario : Form
	{
		ProjetoCircoEntities db = new ProjetoCircoEntities();
		Funcionario a;

		public FrmDelAltFuncionario(Funcionario funcionario)
		{
			InitializeComponent();
			limparFrmDelAltFuncionario();
			InjetarDados(funcionario);
			a = funcionario;

		}

		private void btnSair_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void limparFrmDelAltFuncionario()
		{
			txtNome.Text = string.Empty;
			txtCargo.Text = string.Empty;
			txtDataNasc.Text = string.Empty;
			txtCpf.Text = string.Empty;
			txtRG.Text = string.Empty;
			txtTelefone.Text = string.Empty;
			txtEmail.Text = string.Empty;
			rbtFeminino.Checked = false;
			rbtMasculino.Checked = false;
			picFoto.Image = null;
		}

		private void btnMudaSenha_Click(object sender, EventArgs e)
		{
			FrmAltLoginFuncionario Form = new FrmAltLoginFuncionario(a);
			Form.Show();
		}

		private void btnInserirFoto_Click(object sender, EventArgs e)
		{
			OpenFileDialog file = new OpenFileDialog();
			file.Filter = "jpg|*.jpg";
			if (file.ShowDialog() == DialogResult.OK)
			{
				picFoto.ImageLocation = file.FileName;
			}
		}

		public void InjetarDados(Funcionario funcionario)
		{
			if (funcionario != null)
			{
				txtNome.Text = funcionario.NMFuncionario;
				txtCargo.Text = funcionario.Cargo;
				txtDataNasc.Text = funcionario.DTNascimento.ToString();
				txtCpf.Text = funcionario.CPF;
				txtRG.Text = funcionario.RG;
				txtTelefone.Text = funcionario.Telefone;
				txtEmail.Text = funcionario.Email;
	
				if (funcionario.Sexo == "M")
				{
					rbtMasculino.Checked = true;
					rbtFeminino.Checked = false;
				}
				else
				{
					rbtFeminino.Checked = true;
					rbtMasculino.Checked = false;
				}

				picFoto.ImageLocation = funcionario.CaminhoImagem;
			}
		}

		public bool LoadFuncionario(Funcionario funcionario)
		{
			if ((txtNome.Text != string.Empty) && (txtCpf.MaskFull && txtDataNasc.MaskFull))
			{
				funcionario.NMFuncionario = txtNome.Text; ;
				funcionario.Cargo = txtCargo.Text;
				funcionario.CPF = txtCpf.Text;
				funcionario.RG = txtRG.Text;
				funcionario.Email = txtEmail.Text;
				funcionario.CaminhoImagem = picFoto.ImageLocation;

				if (txtDataNasc.MaskFull)
				{
					funcionario.DTNascimento = txtDataNasc.Text;
				}

				if (txtTelefone.MaskFull)
				{
					funcionario.Telefone = txtTelefone.Text;
				}
				if (rbtMasculino.Checked)
				{
					funcionario.Sexo = "M";
				}
				else if (rbtFeminino.Checked)
				{
					funcionario.Sexo = "F";
				}

				return true;
			}
			else if (!txtDataNasc.MaskFull)
			{
				MessageBox.Show("PREENCHA o campo Data de nascimento!!!");
				return false;
			}
			else
			{
				MessageBox.Show("PREENCHA o campo NOME e/ou CPF!!!");
				return false;
			}
		}

		private void btnEditar_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show("Tem certeza que deseja alterar? ", "Mensagem do Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (result == DialogResult.Yes)
			{
				Funcionario x = db.Funcionario.Single(s => s.IDFuncionario == a.IDFuncionario);
				LoadFuncionario(x);

				db.SaveChanges();
				MessageBox.Show("CADASTRO DO FUNCIONÁRIO ALTERADO COM SUCESSO", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private void btnExcluir_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show("Tem certeza que deseja excluir? ", "Mensagem do Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (result == DialogResult.Yes)
			{
				limparFrmDelAltFuncionario();
				db.Funcionario.Remove(db.Funcionario.Single(x => x.IDFuncionario == a.IDFuncionario));
				db.SaveChanges();
				MessageBox.Show("CADASTRO DO FUNCIONÁRIO EXCLUIDO COM SUCESSO", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
				FrmFuncionario frm = new FrmFuncionario();
				frm.Show();
				this.Close();
			}
		}
	}
}

