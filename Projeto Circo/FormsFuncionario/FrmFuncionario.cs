﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Circo.FormsFuncionario
{
    public partial class FrmFuncionario : Form
    {
        public FrmFuncionario()
        {
            InitializeComponent();
        }

        private void lstPesquisa_Click(object sender, EventArgs e)
        {
            FrmDelAltFuncionario Form = new FrmDelAltFuncionario();
            Form.Show();
        }

        private void btnCad_Click(object sender, EventArgs e)
        {
            FrmCadFuncionario Form = new FrmCadFuncionario();
            Form.Show();
        }

        private void btnTudo_Click(object sender, EventArgs e)
        {

        }
    }
}
