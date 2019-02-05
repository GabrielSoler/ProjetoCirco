using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Circo.FormsLogin
{
    public partial class FrmLoginADM : Form
    {
        public FrmLoginADM()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtSenha.Text = string.Empty;
            txtUsuario.Text = string.Empty;
        }

    
        private void btnLogarADM_Click(object sender, EventArgs e)
        {
            string Usuario = "admin";
            string Senha = "admin";


            if (Usuario == txtUsuario.Text && Senha == txtSenha.Text && txtUsuario.Text != "" && txtSenha.Text != "")
            {
                this.Close();

                FrmMenuADM form = new FrmMenuADM();
                form.Show();
            }
            else
            {
                MessageBox.Show("SENHA OU USUÁRIO INCORRETO(S)","Aviso",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void FrmLoginADM_Load(object sender, EventArgs e)
        {
            // Set to no text.  
            txtSenha.Text = "";
            // The password character is an asterisk.  
            txtSenha.PasswordChar = '*';
        }
    }
 }

