using System;
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
        }

      

        private void FrmEmail_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 2;
            dataGridView1.Columns[0].Name = "Nome";
            dataGridView1.Columns[1].Name = "Email";
            dataGridView1.Rows.Add("Gabriel","Gabriel@email.com");
        }

        private void btnGmail_Click_1(object sender, EventArgs e)
        {
            webBrowser1.Url = new Uri("https://google.com/gmail/");
        }

        private void btnOutlook_Click_1(object sender, EventArgs e)
        {
            webBrowser1.Url = new Uri("https://outlook.live.com/owa/");
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
