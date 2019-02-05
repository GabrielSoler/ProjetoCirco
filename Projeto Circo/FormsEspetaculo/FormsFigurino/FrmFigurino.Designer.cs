namespace Projeto_Circo.FormsFigurino
{
    partial class FrmFigurino
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFigurino));
            this.btnColecao = new System.Windows.Forms.Button();
            this.btnPec = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnColecao
            // 
            this.btnColecao.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnColecao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnColecao.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnColecao.Image = ((System.Drawing.Image)(resources.GetObject("btnColecao.Image")));
            this.btnColecao.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnColecao.Location = new System.Drawing.Point(494, 56);
            this.btnColecao.Name = "btnColecao";
            this.btnColecao.Size = new System.Drawing.Size(108, 90);
            this.btnColecao.TabIndex = 1;
            this.btnColecao.Text = "Coleções";
            this.btnColecao.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnColecao.UseVisualStyleBackColor = false;
            this.btnColecao.Click += new System.EventHandler(this.btnColecao_Click);
            // 
            // btnPec
            // 
            this.btnPec.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPec.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPec.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPec.Image = ((System.Drawing.Image)(resources.GetObject("btnPec.Image")));
            this.btnPec.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPec.Location = new System.Drawing.Point(494, 172);
            this.btnPec.Name = "btnPec";
            this.btnPec.Size = new System.Drawing.Size(108, 90);
            this.btnPec.TabIndex = 2;
            this.btnPec.Text = "Peças";
            this.btnPec.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPec.UseVisualStyleBackColor = false;
            this.btnPec.Click += new System.EventHandler(this.btnPec_Click);
            // 
            // FrmFigurino
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(633, 370);
            this.Controls.Add(this.btnPec);
            this.Controls.Add(this.btnColecao);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmFigurino";
            this.Text = "Figurino";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnColecao;
        private System.Windows.Forms.Button btnPec;
    }
}