using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business;
using Projeto_Circo.FormsArtista;


namespace Projeto_Circo.FormsArtista
{
    public partial class FrmArtistas : Form
    {
        public FrmArtistas()
        {
            InitializeComponent();
        }

        Artista artista = new Artista();

        private void FrmArtistas_Load(object sender, EventArgs e)
        {
            pnlBuscar.BackColor = Color.Transparent;
        }

        private void lstPesquisa_Click(object sender, EventArgs e)
        {
            var artista = (Artista)lstPesquisa.SelectedItem;
            if (artista != null)
            {
                this.Close();
                FrmDelAltArtista Form = new FrmDelAltArtista(artista);
                Form.Show();
            }
            
        }

        private void btnCad_Click(object sender, EventArgs e)
        {
            FrmCadArtista Form = new FrmCadArtista();
            Form.Show();
        }

        private void btnTudo_Click(object sender, EventArgs e)
        {
            lstPesquisa.Items.Clear();
            List<Artista> artistas = new Artista().Todos();
            foreach (Artista a in artistas)
            {
                lstPesquisa.Items.Add(a);
            
            }
    
        }

        private void btnBusca_Click(object sender, EventArgs e)
        {
            lstPesquisa.Items.Clear();
            List<Artista> artistas = artista.BuscaNome(toolStripTextBoxPesquisa.Text);
            foreach (Artista a in artistas)
            {
                lstPesquisa.Items.Add(a);
            }
           
        }

		
	}
}
