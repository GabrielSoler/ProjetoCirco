using Business;
using Projeto_Circo.FormsArtista;
using Projeto_Circo.FormsFigurino;
using Projeto_Circo.FormsFuncionario;
using Projeto_Circo.FormsLogin;
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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

       
        private void abrirArtista_Click(object sender, EventArgs e)
        {
            FrmCadArtista Form = new FrmCadArtista();
            Form.Show();

        }

        private void abrirColecao_Click(object sender, EventArgs e)
        {
            FrmCadColecoes Form = new FrmCadColecoes();
            Form.Show();
        }

        private void abrirPec_Click(object sender, EventArgs e)
        {
            FrmCadPec Form = new FrmCadPec();
            Form.Show();
        }

        private void fecha_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       


        private void FrmMain_Load(object sender, EventArgs e)
        {
            var contextMenu = new ContextMenu();
            contextMenu.MenuItems.Add(new MenuItem("Cadastrar Artista",abrirArtista_Click));
            contextMenu.MenuItems.Add(new MenuItem("Cadastrar Coleção",abrirColecao_Click));
            contextMenu.MenuItems.Add(new MenuItem("Cadastrar Peça Unica",abrirPec_Click));
            contextMenu.MenuItems.Add(new MenuItem("Sair",fecha_Click));
            notifyIcon.ContextMenu = contextMenu;      
        }

       
        private void btnEspeta_Click(object sender, EventArgs e)
        {
            var Form = new FrmMenu();
            Form.Show();
        }

        private void btnFinanceiro_Click(object sender, EventArgs e)
        {
            FrmLoginFinanceiro Form = new FrmLoginFinanceiro();
            Form.Show();
        }

        private void btnAdm_Click(object sender, EventArgs e)
        {
            FrmLoginADM Form = new FrmLoginADM();
            Form.Show();

            
        }

       
       
    }
}
