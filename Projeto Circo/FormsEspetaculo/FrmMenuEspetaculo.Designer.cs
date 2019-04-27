namespace Projeto_Circo
{
    partial class FrmMenu
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnRelatorio = new System.Windows.Forms.Button();
			this.btnEspetaculo = new System.Windows.Forms.Button();
			this.btnFigurino = new System.Windows.Forms.Button();
			this.btnArtista = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.btnRelatorio);
			this.panel1.Controls.Add(this.btnEspetaculo);
			this.panel1.Controls.Add(this.btnFigurino);
			this.panel1.Controls.Add(this.btnArtista);
			this.panel1.Location = new System.Drawing.Point(605, 30);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(135, 389);
			this.panel1.TabIndex = 0;
			// 
			// btnRelatorio
			// 
			this.btnRelatorio.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnRelatorio.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnRelatorio.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRelatorio.Image = ((System.Drawing.Image)(resources.GetObject("btnRelatorio.Image")));
			this.btnRelatorio.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnRelatorio.Location = new System.Drawing.Point(12, 285);
			this.btnRelatorio.Name = "btnRelatorio";
			this.btnRelatorio.Size = new System.Drawing.Size(108, 90);
			this.btnRelatorio.TabIndex = 3;
			this.btnRelatorio.Text = "Relatórios";
			this.btnRelatorio.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnRelatorio.UseVisualStyleBackColor = false;
			this.btnRelatorio.Click += new System.EventHandler(this.btnRelatorio_Click);
			// 
			// btnEspetaculo
			// 
			this.btnEspetaculo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnEspetaculo.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnEspetaculo.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEspetaculo.Image = ((System.Drawing.Image)(resources.GetObject("btnEspetaculo.Image")));
			this.btnEspetaculo.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnEspetaculo.Location = new System.Drawing.Point(12, 199);
			this.btnEspetaculo.Name = "btnEspetaculo";
			this.btnEspetaculo.Size = new System.Drawing.Size(108, 80);
			this.btnEspetaculo.TabIndex = 2;
			this.btnEspetaculo.Text = "Espetáculo";
			this.btnEspetaculo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnEspetaculo.UseVisualStyleBackColor = false;
			this.btnEspetaculo.Click += new System.EventHandler(this.btnEspetaculo_Click);
			// 
			// btnFigurino
			// 
			this.btnFigurino.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnFigurino.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnFigurino.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnFigurino.Image = ((System.Drawing.Image)(resources.GetObject("btnFigurino.Image")));
			this.btnFigurino.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnFigurino.Location = new System.Drawing.Point(12, 103);
			this.btnFigurino.Name = "btnFigurino";
			this.btnFigurino.Size = new System.Drawing.Size(108, 90);
			this.btnFigurino.TabIndex = 1;
			this.btnFigurino.Text = "Figurino";
			this.btnFigurino.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnFigurino.UseVisualStyleBackColor = false;
			this.btnFigurino.Click += new System.EventHandler(this.btnFigurino_Click);
			// 
			// btnArtista
			// 
			this.btnArtista.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnArtista.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnArtista.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnArtista.Image = ((System.Drawing.Image)(resources.GetObject("btnArtista.Image")));
			this.btnArtista.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnArtista.Location = new System.Drawing.Point(12, 7);
			this.btnArtista.Name = "btnArtista";
			this.btnArtista.Size = new System.Drawing.Size(108, 90);
			this.btnArtista.TabIndex = 0;
			this.btnArtista.Text = "Artistas";
			this.btnArtista.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnArtista.UseVisualStyleBackColor = false;
			this.btnArtista.Click += new System.EventHandler(this.btnArtista_Click);
			// 
			// FrmMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.ClientSize = new System.Drawing.Size(755, 450);
			this.Controls.Add(this.panel1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FrmMenu";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Projeto Circo";
			this.Load += new System.EventHandler(this.FrmMenu_Load);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRelatorio;
        private System.Windows.Forms.Button btnEspetaculo;
        private System.Windows.Forms.Button btnFigurino;
        private System.Windows.Forms.Button btnArtista;
    }
}

