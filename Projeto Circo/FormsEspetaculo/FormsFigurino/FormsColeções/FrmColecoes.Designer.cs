namespace Projeto_Circo.FormsFigurino
{
    partial class FrmColecoes
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmColecoes));
			this.btnCad = new System.Windows.Forms.Button();
			this.pnlBuscar = new System.Windows.Forms.Panel();
			this.txtPesquisa = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.lstPesquisa = new System.Windows.Forms.ListBox();
			this.btnTudos = new System.Windows.Forms.Button();
			this.pnlBuscar.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnCad
			// 
			this.btnCad.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnCad.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnCad.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCad.Image = ((System.Drawing.Image)(resources.GetObject("btnCad.Image")));
			this.btnCad.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnCad.Location = new System.Drawing.Point(307, 303);
			this.btnCad.Name = "btnCad";
			this.btnCad.Size = new System.Drawing.Size(118, 93);
			this.btnCad.TabIndex = 31;
			this.btnCad.Text = "Cadastrar";
			this.btnCad.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnCad.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnCad.UseVisualStyleBackColor = false;
			this.btnCad.Click += new System.EventHandler(this.btnCad_Click);
			// 
			// pnlBuscar
			// 
			this.pnlBuscar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.pnlBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlBuscar.BackgroundImage")));
			this.pnlBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.pnlBuscar.Controls.Add(this.txtPesquisa);
			this.pnlBuscar.Controls.Add(this.label1);
			this.pnlBuscar.Controls.Add(this.lstPesquisa);
			this.pnlBuscar.Location = new System.Drawing.Point(161, 37);
			this.pnlBuscar.Name = "pnlBuscar";
			this.pnlBuscar.Size = new System.Drawing.Size(264, 248);
			this.pnlBuscar.TabIndex = 30;
			// 
			// txtPesquisa
			// 
			this.txtPesquisa.Location = new System.Drawing.Point(99, 72);
			this.txtPesquisa.Name = "txtPesquisa";
			this.txtPesquisa.Size = new System.Drawing.Size(129, 20);
			this.txtPesquisa.TabIndex = 33;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(39, 73);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(54, 19);
			this.label1.TabIndex = 32;
			this.label1.Text = "Buscar:";
			// 
			// lstPesquisa
			// 
			this.lstPesquisa.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lstPesquisa.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lstPesquisa.FormattingEnabled = true;
			this.lstPesquisa.ItemHeight = 17;
			this.lstPesquisa.Location = new System.Drawing.Point(34, 98);
			this.lstPesquisa.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
			this.lstPesquisa.Name = "lstPesquisa";
			this.lstPesquisa.ScrollAlwaysVisible = true;
			this.lstPesquisa.Size = new System.Drawing.Size(194, 72);
			this.lstPesquisa.TabIndex = 7;
			this.lstPesquisa.Click += new System.EventHandler(this.lstPesquisa_Click);
			// 
			// btnTudos
			// 
			this.btnTudos.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnTudos.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnTudos.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnTudos.Image = ((System.Drawing.Image)(resources.GetObject("btnTudos.Image")));
			this.btnTudos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnTudos.Location = new System.Drawing.Point(161, 301);
			this.btnTudos.Name = "btnTudos";
			this.btnTudos.Size = new System.Drawing.Size(118, 95);
			this.btnTudos.TabIndex = 20;
			this.btnTudos.Text = "Exibir Todos";
			this.btnTudos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnTudos.UseVisualStyleBackColor = false;
			this.btnTudos.Click += new System.EventHandler(this.btnTudos_Click);
			// 
			// FrmColecoes
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.ClientSize = new System.Drawing.Size(595, 450);
			this.Controls.Add(this.btnTudos);
			this.Controls.Add(this.btnCad);
			this.Controls.Add(this.pnlBuscar);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FrmColecoes";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Coleções";
			this.pnlBuscar.ResumeLayout(false);
			this.pnlBuscar.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCad;
        private System.Windows.Forms.Panel pnlBuscar;
        private System.Windows.Forms.ListBox lstPesquisa;
        private System.Windows.Forms.Button btnTudos;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Label label1;
    }
}