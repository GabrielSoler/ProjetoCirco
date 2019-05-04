namespace Projeto_Circo.FormsFinanceiro
{
    partial class FrmFinanceiro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFinanceiro));
			this.pnlBuscar = new System.Windows.Forms.Panel();
			this.lstPesquisa = new System.Windows.Forms.ListBox();
			this.btnTudo = new System.Windows.Forms.Button();
			this.btnCad = new System.Windows.Forms.Button();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripTextBoxPesquisa = new System.Windows.Forms.ToolStripTextBox();
			this.btnBusca = new System.Windows.Forms.ToolStripButton();
			this.pnlBuscar.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlBuscar
			// 
			this.pnlBuscar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.pnlBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlBuscar.BackgroundImage")));
			this.pnlBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.pnlBuscar.Controls.Add(this.lstPesquisa);
			this.pnlBuscar.Location = new System.Drawing.Point(12, 27);
			this.pnlBuscar.Name = "pnlBuscar";
			this.pnlBuscar.Size = new System.Drawing.Size(330, 247);
			this.pnlBuscar.TabIndex = 3;
			// 
			// lstPesquisa
			// 
			this.lstPesquisa.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lstPesquisa.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lstPesquisa.FormattingEnabled = true;
			this.lstPesquisa.ItemHeight = 17;
			this.lstPesquisa.Location = new System.Drawing.Point(68, 71);
			this.lstPesquisa.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
			this.lstPesquisa.Name = "lstPesquisa";
			this.lstPesquisa.ScrollAlwaysVisible = true;
			this.lstPesquisa.Size = new System.Drawing.Size(177, 89);
			this.lstPesquisa.TabIndex = 2;
			this.lstPesquisa.Click += new System.EventHandler(this.lstPesquisa_Click);
			// 
			// btnTudo
			// 
			this.btnTudo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnTudo.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnTudo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnTudo.Image = ((System.Drawing.Image)(resources.GetObject("btnTudo.Image")));
			this.btnTudo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnTudo.Location = new System.Drawing.Point(35, 280);
			this.btnTudo.Name = "btnTudo";
			this.btnTudo.Size = new System.Drawing.Size(118, 95);
			this.btnTudo.TabIndex = 2;
			this.btnTudo.Text = "Exibir Todos";
			this.btnTudo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnTudo.UseVisualStyleBackColor = false;
			this.btnTudo.Click += new System.EventHandler(this.btnTudo_Click);
			// 
			// btnCad
			// 
			this.btnCad.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnCad.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnCad.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCad.Image = ((System.Drawing.Image)(resources.GetObject("btnCad.Image")));
			this.btnCad.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnCad.Location = new System.Drawing.Point(192, 280);
			this.btnCad.Name = "btnCad";
			this.btnCad.Size = new System.Drawing.Size(118, 93);
			this.btnCad.TabIndex = 1;
			this.btnCad.Text = "Cadastrar";
			this.btnCad.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnCad.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnCad.UseVisualStyleBackColor = false;
			this.btnCad.Click += new System.EventHandler(this.btnCad_Click);
			// 
			// toolStrip1
			// 
			this.toolStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBoxPesquisa,
            this.btnBusca});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(344, 25);
			this.toolStrip1.TabIndex = 28;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// toolStripTextBoxPesquisa
			// 
			this.toolStripTextBoxPesquisa.Name = "toolStripTextBoxPesquisa";
			this.toolStripTextBoxPesquisa.Size = new System.Drawing.Size(100, 25);
			this.toolStripTextBoxPesquisa.Text = "Buscar financeiro";
			// 
			// btnBusca
			// 
			this.btnBusca.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btnBusca.Image = ((System.Drawing.Image)(resources.GetObject("btnBusca.Image")));
			this.btnBusca.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnBusca.Name = "btnBusca";
			this.btnBusca.Size = new System.Drawing.Size(23, 22);
			this.btnBusca.Text = "toolStripButton1";
			this.btnBusca.Click += new System.EventHandler(this.btnBusca_Click);
			// 
			// FrmFinanceiro
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.ClientSize = new System.Drawing.Size(344, 380);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.pnlBuscar);
			this.Controls.Add(this.btnTudo);
			this.Controls.Add(this.btnCad);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FrmFinanceiro";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Financeiro";
			this.Load += new System.EventHandler(this.FrmFinanceiro_Load);
			this.pnlBuscar.ResumeLayout(false);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlBuscar;
        private System.Windows.Forms.ListBox lstPesquisa;
        private System.Windows.Forms.Button btnTudo;
        private System.Windows.Forms.Button btnCad;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripTextBox toolStripTextBoxPesquisa;
		private System.Windows.Forms.ToolStripButton btnBusca;
	}
}