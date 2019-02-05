using Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace Projeto_Circo.FormsArtista
{
    public  partial class FrmCadArtista : Form
    {
        public FrmCadArtista()
        {
            InitializeComponent();
            
        }

        private void FrmCadArtista_Load(object sender, EventArgs e)
        {
            tabControl.SelectTab("tbDadosPessoais");

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            tabControl.SelectTab("tbMedidas");
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            tabControl.SelectTab("tbDadosPessoais");
           
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

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            
            var U = new Usuario();
        }

        //Converte imagem para bytes
        public byte[] ConverterImagemParaBytes()
        {
            MemoryStream stream = new MemoryStream();
            picFoto.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
            byte[] foto = stream.ToArray();
            return foto;
        }


        public void LimparArtista()
        {
            //////////////LIMPAR DADDOS PESSOAIS///////////////////////////////////
            txtNomeArt.Text = string.Empty;
            txtFunc.Text = string.Empty;
            txtDataNasc.Text = string.Empty;
            txtCpf.Text = string.Empty;
            txtTel.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtEnderecoImage.Text = string.Empty;

            rbtMasc.Checked = false;
            rbtFem.Checked = false;
            picFoto.Image = null;
            //////////////LIMPAR MEDIDAS///////////////////////////////////
            txtOmbroAOmbro.Text = string.Empty;
            txtOmbro.Text = string.Empty;
            txtColarinho.Text = string.Empty;
            txtEntreCavasFrente.Text = string.Empty;
            txtCentroCosta.Text = string.Empty;
            txtBusto.Text = string.Empty;
            txtAlturaBusto.Text = string.Empty;
            txtSeparacaoBusto.Text = string.Empty;
            txtCintura.Text = string.Empty;
            txtAltura.Text = string.Empty;
            txtAlturaQuadril.Text = string.Empty;
            txtQuadril.Text = string.Empty;
            txtAltCintDoJoelho.Text = string.Empty;
            txtAltCintAoTornozelo.Text = string.Empty;
            txtCompBraco.Text = string.Empty;
            txtLargBraco.Text = string.Empty;
            txtPunho.Text = string.Empty;
            txtAltManga.Text = string.Empty;
            txtAltMangaCurta.Text = string.Empty;
            txtAltDesjDaSaia.Text = string.Empty;

        }


    }
}
