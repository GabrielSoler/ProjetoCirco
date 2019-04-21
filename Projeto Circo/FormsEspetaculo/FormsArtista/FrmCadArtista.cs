using System;
using System.Windows.Forms;

namespace Projeto_Circo.FormsArtista
{
	public  partial class FrmCadArtista : Form
    {

		ProjetoCircoEntities db = new ProjetoCircoEntities();
		
		public FrmCadArtista()
        {
            InitializeComponent();
            rbtMasc.Checked = true;
         
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

            Artistas artista = new Artistas();

            if (LoadArtista(artista))
            {
                LimparArtista();
				db.Artistas.Add(artista);
				db.SaveChanges();
                MessageBox.Show("Usuário salvo com sucesso!","Mensagem do sistema");
            }
            
        }

        public bool LoadArtista(Artistas artista)
        {
            if (txtNomeArt.Text != string.Empty && txtCpf.MaskFull && txtDataNasc.MaskFull) {
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
                artista.CaminhoFotoArtista = picFoto.ImageLocation;
                
                //////////////Carregar MEDIDAS///////////////////////////////////
                if (txtOmbroAOmbro.MaskFull)
                {
					artista.OmbroAOmbro = decimal.TryParse(txtOmbroAOmbro.Text, out var tempVal) ? tempVal : (decimal?)null;
				}
                if (txtOmbro.MaskFull)
                {
					artista.Ombro = decimal.TryParse(txtOmbro.Text, out var tempVal) ? tempVal : (decimal?)null;
				}
				if (txtColarinho.MaskFull)
                {
					artista.Colarinho = decimal.TryParse(txtColarinho.Text, out var tempVal) ? tempVal : (decimal?)null;
				}
				if (txtEntreCavasFrente.MaskFull)
                {
					artista.EntreCavasFrente = decimal.TryParse(txtEntreCavasFrente.Text, out var tempVal) ? tempVal : (decimal?)null;
				}
				if (txtCentroCosta.MaskFull)
                {
					artista.CentroCosta = decimal.TryParse(txtCentroCosta.Text, out var tempVal) ? tempVal : (decimal?)null;
				}
				if (txtBusto.MaskFull)
                {
					artista.Busto = decimal.TryParse(txtBusto.Text, out var tempVal) ? tempVal : (decimal?)null;
				}
				if (txtAlturaBusto.MaskFull)
                {
					artista.AlturaBusto = decimal.TryParse(txtAlturaBusto.Text, out var tempVal) ? tempVal : (decimal?)null;
				}
				if (txtEntreCavasFrente.MaskFull)
                {
					artista.EntreCavasFrente = decimal.TryParse(txtEntreCavasFrente.Text, out var tempVal) ? tempVal : (decimal?)null;
				}
				if (txtSeparacaoBusto.MaskFull)
                {
					artista.SeparacaoBusto = decimal.TryParse(txtSeparacaoBusto.Text, out var tempVal) ? tempVal : (decimal?)null;
				}
				if (txtCintura.MaskFull)
                {
					artista.Cintura = decimal.TryParse(txtCintura.Text, out var tempVal) ? tempVal : (decimal?)null;
				}
				if (txtAltura.MaskFull)
                {
					artista.Altura = decimal.TryParse(txtAltura.Text, out var tempVal) ? tempVal : (decimal?)null;
				}
				if (txtAlturaQuadril.MaskFull)
                {
					artista.AlturaQuadril = decimal.TryParse(txtAlturaQuadril.Text, out var tempVal) ? tempVal : (decimal?)null;

				}
				if (txtQuadril.MaskFull)
                {
					artista.Quadril = decimal.TryParse(txtQuadril.Text, out var tempVal) ? tempVal : (decimal?)null;
				}
				if (txtAltCintDoJoelho.MaskFull)
                {
					artista.AlturaCinturaDoJoelho = decimal.TryParse(txtAltCintDoJoelho.Text, out var tempVal) ? tempVal : (decimal?)null;
				}
				if (txtAltCintAoTornozelo.MaskFull)
                {
					artista.AlturaCinturaAoTornozelo = decimal.TryParse(txtAltCintAoTornozelo.Text, out var tempVal) ? tempVal : (decimal?)null;
				}
				if (txtCompBraco.MaskFull)
                {
					artista.ComprimentoBraco = decimal.TryParse(txtCompBraco.Text, out var tempVal) ? tempVal : (decimal?)null;
				}
				if (txtLargBraco.MaskFull)
                {
					artista.LarguraBraco = decimal.TryParse(txtLargBraco.Text, out var tempVal) ? tempVal : (decimal?)null;
				}
				if (txtPunho.MaskFull)
                {
					artista.Punho = decimal.TryParse(txtPunho.Text, out var tempVal) ? tempVal : (decimal?)null;
				}
				if (txtAltManga.MaskFull)
                {
					artista.AlturaManga = decimal.TryParse(txtAltManga.Text, out var tempVal) ? tempVal : (decimal?)null;
				}
				if (txtAltMangaCurta.MaskFull)
                {
					artista.AlturaMangaCurta = decimal.TryParse(txtAltMangaCurta.Text, out var tempVal) ? tempVal : (decimal?)null;
				}
				if (txtAltDesjDaSaia.MaskFull)
                {
					artista.AlturaDesejadaDaSaia = decimal.TryParse(txtAltDesjDaSaia.Text, out var tempVal) ? tempVal : (decimal?)null;
				}
				return true;
            }
            else if(!txtDataNasc.MaskFull)
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

        public void LimparArtista()
        {
            //////////////LIMPAR DADOS PESSOAIS///////////////////////////////////
            txtNomeArt.Text = string.Empty;
            txtFunc.Text = string.Empty;
            txtDataNasc.Text = string.Empty;
            txtCpf.Text = string.Empty;
            txtTel.Text = string.Empty;
            txtEmail.Text = string.Empty;
           

            rbtMasc.Checked = true;
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

        private void rbtMasc_KeyDown(object sender, KeyEventArgs e)
        {
            if ((Keys)e.KeyValue == Keys.Enter)
            {
                e.Handled = true;
                rbtMasc.Checked = false;
                rbtFem.Checked = true;
            }
        }

        
    }
}
