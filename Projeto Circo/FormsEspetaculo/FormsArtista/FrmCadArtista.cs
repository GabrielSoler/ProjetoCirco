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

            Artista artista = new Artista();

            if (LoadArtista(artista))
            {
                LimparArtista();
                artista.Salvar();
                MessageBox.Show("Usuário salvo com sucesso!");
            }
            
        }

        //Converte imagem para bytes
        public byte[] ConverterImagemParaBytes()
        {
            MemoryStream stream = new MemoryStream();

            if (picFoto.Image != null)
            {
                picFoto.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] foto = stream.ToArray();
                return foto;
            }
            return null;    
        }
        //Inverte data para salvar no banco
        public string InverteData(string dataBr)
        {
            string[] dateS = dataBr.Split('/');
            string dataEUA = string.Empty;
            for(int i=2; i >= 0; i--)
            {
                dataEUA += dateS[i] + '/';
            }
            dataEUA = dataEUA.Remove(dataEUA.Length - 1);
            return dataEUA;
        }


        public bool LoadArtista(Artista artista)
        {
            if (txtNomeArt.Text != string.Empty && txtCpf.MaskFull) {
                //////////////Carregar DADOS PESSOAIS///////////////////////////////////
                artista.Nome = txtNomeArt.Text;
                artista.CPF = txtCpf.Text;
                artista.Funcao = txtFunc.Text;
                artista.Email = txtEmail.Text;
                if (txtDataNasc.MaskFull)
                {
                    string tempData = InverteData(txtDataNasc.Text);
                    artista.DataNascimento = Convert.ToDateTime(tempData);
                }
                else
                {
                    artista.DataNascimento = DateTime.Now;
                }
                if (txtTel.MaskFull)
                {
                    artista.Telefone = txtTel.Text;
                }
                if (rbtMasc.Checked)
                {
                    artista.Sexo = 'M';
                }
                else if (rbtFem.Checked)
                {
                    artista.Sexo = 'F';
                }
                artista.FotoArtista = ConverterImagemParaBytes();
                //////////////Carregar MEDIDAS///////////////////////////////////
                if (txtOmbroAOmbro.MaskFull)
                {
                    artista.OmbroAOmbro = Convert.ToDouble(txtOmbroAOmbro.Text);
                }
                if (txtOmbro.MaskFull)
                {
                    artista.Ombro = Convert.ToDouble(txtOmbro.Text);
                }
                if (txtColarinho.MaskFull)
                {
                    artista.Colarinho = Convert.ToDouble(txtColarinho.Text);
                }
                if (txtEntreCavasFrente.MaskFull)
                {
                    artista.EntreCavasFrente = Convert.ToDouble(txtEntreCavasFrente.Text);
                }
                if (txtCentroCosta.MaskFull)
                {
                    artista.CentroCosta = Convert.ToDouble(txtCentroCosta.Text);
                }
                if (txtBusto.MaskFull)
                {
                    artista.Busto = Convert.ToDouble(txtBusto.Text);
                }
                if (txtAlturaBusto.MaskFull)
                {
                    artista.AlturaBusto = Convert.ToDouble(txtAlturaBusto.Text);
                }
                if (txtEntreCavasFrente.MaskFull)
                {
                    artista.EntreCavasFrente = Convert.ToDouble(txtEntreCavasFrente.Text);
                }
                if (txtSeparacaoBusto.MaskFull)
                {
                    artista.SeparacaoBusto = Convert.ToDouble(txtSeparacaoBusto.Text);
                }
                if (txtCintura.MaskFull)
                {
                    artista.Cintura = Convert.ToDouble(txtCintura.Text);
                }
                if (txtAltura.MaskFull)
                {
                    artista.Altura = Convert.ToDouble(txtAltura.Text);
                }
                if (txtAlturaQuadril.MaskFull)
                {
                    artista.AlturaQuadril = Convert.ToDouble(txtAlturaQuadril.Text);
                }
                if (txtQuadril.MaskFull)
                {
                    artista.Quadril = Convert.ToDouble(txtQuadril.Text);
                }
                if (txtAltCintDoJoelho.MaskFull)
                {
                    artista.AlturaCinturaDoJoelho = Convert.ToDouble(txtAltCintDoJoelho.Text);
                }
                if (txtAltCintAoTornozelo.MaskFull)
                {
                    artista.AlturaCinturaAoTornozelo = Convert.ToDouble(txtAltCintAoTornozelo.Text);
                }
                if (txtCompBraco.MaskFull)
                {
                    artista.ComprimentoBraco = Convert.ToDouble(txtCompBraco.Text);
                }
                if (txtLargBraco.MaskFull)
                {
                    artista.LarguraBraco = Convert.ToDouble(txtLargBraco.Text);
                }
                if (txtPunho.MaskFull)
                {
                    artista.Punho = Convert.ToDouble(txtPunho.Text);
                }
                if (txtAltManga.MaskFull)
                {
                    artista.AlturaManga = Convert.ToDouble(txtAltManga.Text);
                }
                if (txtAltMangaCurta.MaskFull)
                {
                    artista.AlturaMangaCurta = Convert.ToDouble(txtAltMangaCurta.Text);
                }
                if (txtAltDesjDaSaia.MaskFull)
                {
                    artista.AlturaDesejadaDaSaia = Convert.ToDouble(txtAltDesjDaSaia.Text);
                }
                return true;
            }
            else
            {
                MessageBox.Show("PREENCHA o campo NOME e/ou CPF!!!");
                return false;
            }
        }

        public void LimparArtista()
        {
            //////////////LIMPAR DADOS PESSOAIS///////////////////////////////////
            txtNomeArt.Text = string.Empty;
            txtFunc.Text = string.Empty;
            txtDataNasc.Text = string.Empty;
            txtCpf.Text = string.Empty;
            txtTel.Text = string.Empty;
            txtEmail.Text = string.Empty;
           

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
