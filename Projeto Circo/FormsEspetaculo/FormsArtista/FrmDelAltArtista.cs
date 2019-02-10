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
    public partial class FrmDelAltArtista : Form
    {
        Artista artista = new Artista();

        public FrmDelAltArtista(Artista artista)
        {
            InitializeComponent();
            this.artista = artista;
            InjetarDados(artista);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            tabControl.SelectTab("tbMedidas");

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            tabControl.SelectTab("tbDadosPessoais");

        }

        private void FrmDelAltArtista_Load(object sender, EventArgs e)
        {
            tabControl.SelectTab("tbDadosPessoais");
        }

      

      

        public Image byteArrayToImage(byte[] imageByteArray)
        {
            Image image;
            using (MemoryStream stream = new MemoryStream(imageByteArray, 0, imageByteArray.Length))
            {
                stream.Write(imageByteArray, 0, imageByteArray.Length);
                image = Image.FromStream(stream, true);
            }
            return image;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Tem certeza que deseja excluir? ", "Mensagem do Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                artista.Excluir();
                LimparArtista();

                MessageBox.Show("CADASTRO DO ARTISTA EXCLUIDO COM SUCESSO", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FrmArtistas frmArtistas = new FrmArtistas();
                frmArtistas.Show();
                this.Close();
            }           
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Tem certeza que deseja alterar? ", "Mensagem do Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                LoadArtista(artista);
                artista.Salvar();
                MessageBox.Show("CADASTRO DO ARTISTA ALTERADO COM SUCESSO", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);              
            }      
        }

        public bool LoadArtista(Artista artista)
        {
            if (txtNomeArt.Text != string.Empty && txtCpf.MaskFull && txtDataNasc.MaskFull)
            {
                //////////////Carregar DADOS PESSOAIS///////////////////////////////////
                artista.Nome = txtNomeArt.Text;
                artista.CPF = txtCpf.Text;
                artista.Funcao = txtFunc.Text;
                artista.Email = txtEmail.Text;
                if (txtDataNasc.MaskFull)
                {
                    artista.DataNascimento = txtDataNasc.Text;

                }

                if (txtTel.MaskFull)
                {
                    artista.Telefone = txtTel.Text;
                }
                if (rbtMasc.Checked)
                {
                    artista.Sexo = "M";
                }
                else if (rbtFem.Checked)
                {
                    artista.Sexo = "F";
                }

                //artista.FotoArtista = imageToByteArray(picFoto.Image);

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

        public void InjetarDados(Artista artista)
        {
            if (artista != null)
            {

                //////////////INJETAR DADDOS PESSOAIS///////////////////////////////////
                txtNomeArt.Text = artista.Nome;
                txtFunc.Text = artista.Funcao;
                txtDataNasc.Text = artista.DataNascimento.ToString();
                txtCpf.Text = artista.CPF;
                txtTel.Text = artista.Telefone;
                txtEmail.Text = artista.Email;

                if (artista.Sexo == "M")
                {
                    rbtMasc.Checked = true;
                    rbtFem.Checked = false;
                }
                else
                {
                    rbtFem.Checked = true;
                    rbtMasc.Checked = false;
                }
                if (artista.FotoArtista != null)
                {
                    //artista.BuscarFotoId(artista.Id);
                    //picFoto.Image = byteArrayToImage(artista.BuscarFotoId(artista.Id));
                    // picFoto.Image = byteArrayToImage(artista.FotoArtista);
                }

                //////////////INJETAR MEDIDAS///////////////////////////////////
                txtOmbroAOmbro.Text = artista.OmbroAOmbro.ToString();
                txtOmbro.Text = artista.Ombro.ToString();
                txtColarinho.Text = artista.Colarinho.ToString();
                txtEntreCavasFrente.Text = artista.EntreCavasFrente.ToString();
                txtCentroCosta.Text = artista.CentroCosta.ToString();
                txtBusto.Text = artista.Busto.ToString();
                txtAlturaBusto.Text = artista.AlturaBusto.ToString();
                txtSeparacaoBusto.Text = artista.SeparacaoBusto.ToString();
                txtCintura.Text = artista.Cintura.ToString();
                txtAltura.Text = artista.Altura.ToString();
                txtAlturaQuadril.Text = artista.AlturaQuadril.ToString();
                txtQuadril.Text = artista.Quadril.ToString();
                txtAltCintDoJoelho.Text = artista.AlturaCinturaDoJoelho.ToString();
                txtAltCintAoTornozelo.Text = artista.AlturaCinturaAoTornozelo.ToString();
                txtCompBraco.Text = artista.ComprimentoBraco.ToString();
                txtLargBraco.Text = artista.LarguraBraco.ToString();
                txtPunho.Text = artista.Punho.ToString();
                txtAltManga.Text = artista.AlturaManga.ToString();
                txtAltMangaCurta.Text = artista.AlturaMangaCurta.ToString();
                txtAltDesjDaSaia.Text = artista.AlturaDesejadaDaSaia.ToString();
            }
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
