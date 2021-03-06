﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Circo.FormsFigurino.FormsPeças
{
    public partial class FrmEmail : Form
    {
        public FrmEmail()
        {
            InitializeComponent();
			webBrowser.Url = new Uri("https://google.com/gmail/");
		}

      

        private void FrmEmail_Load(object sender, EventArgs e)
        {

			ProjetoCircoEntities db = new ProjetoCircoEntities();


			var consulta = from p in db.Funcionario select new { p.NMFuncionario, p.Email,p.Cargo};

			consulta = consulta.Where(x => x.Cargo.Contains("Costureira") || x.Cargo.Contains("Costureiro"));

			dataGridView.DataSource = consulta.ToList();


		}

		private void btnGmail_Click_1(object sender, EventArgs e)
        {
            webBrowser.Url = new Uri("https://google.com/gmail/");
        }

        private void btnOutlook_Click_1(object sender, EventArgs e)
        {
            webBrowser.Url = new Uri("https://outlook.live.com/owa/");
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

	
	}
}
