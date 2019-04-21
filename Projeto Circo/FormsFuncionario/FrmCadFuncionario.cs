using System;
using System.Windows.Forms;

namespace Projeto_Circo.FormsFuncionario
{
    public partial class FrmCadFuncionario : Form
    {

		ProjetoCircoEntities db = new ProjetoCircoEntities();


		public FrmCadFuncionario()
        {
            InitializeComponent();
			rbtMasculino.Checked = true;

		}

		private void btnMudaSenha_Click(object sender, EventArgs e)
        {
            FrmAltLoginFuncionario Form = new FrmAltLoginFuncionario(null);
            Form.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
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

		private void limparFrmCadFuncionario()
        {
            txtNome.Text = string.Empty;
            txtCargo.Text = string.Empty;
            txtDataNasc.Text = string.Empty;
            txtCPF.Text = string.Empty;
            txtRG.Text = string.Empty;
            txtTelefone.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtUsuario.Text = string.Empty;
            txtSenha.Text = string.Empty;
            txtSenhaNovamente.Text = string.Empty;

            rbtFeminino.Checked = false;
            rbtMasculino.Checked = false;
            picFoto.Image = null;
        }

		private void FrmCadFuncionario_Load(object sender, EventArgs e)
		{
			txtSenha.PasswordChar = '*';
			txtSenhaNovamente.PasswordChar = '*';
		}

		public bool LoadFuncionario(Funcionario funcionario)
		{
			if ((txtNome.Text != string.Empty) && (txtCPF.MaskFull && txtDataNasc.MaskFull) &&(txtSenhaNovamente.Text == txtSenha.Text) )
			{

				funcionario.NMFuncionario = txtNome.Text; ;
				funcionario.Cargo = txtCargo.Text;
				funcionario.CPF = txtCPF.Text;
				funcionario.RG = txtRG.Text;
				funcionario.Email = txtEmail.Text;
				funcionario.CaminhoImagem = picFoto.ImageLocation;
				funcionario.Usuario = txtUsuario.Text;
				funcionario.Senha = txtSenha.Text;

				picFoto.Image = null;

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
			else if(txtSenhaNovamente.Text != txtSenha.Text)
			{
				MessageBox.Show("AS SENHAS SÃO DIFERENTES!!!");
				return false;
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

		private void btnSalvar_Click(object sender, EventArgs e)
		{
			Funcionario funcionarios = new Funcionario();

			if (LoadFuncionario(funcionarios))
			{
				limparFrmCadFuncionario();
				db.Funcionario.Add(funcionarios);
				db.SaveChanges();
				MessageBox.Show("Funcionários salvo com sucesso!", "Mensagem do sistema");
			}
		}
	}
}
