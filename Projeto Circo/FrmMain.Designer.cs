namespace Projeto_Circo
{
    partial class FrmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.btnFinanceiro = new System.Windows.Forms.Button();
            this.btnAdm = new System.Windows.Forms.Button();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.btnEspeta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFinanceiro
            // 
            this.btnFinanceiro.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFinanceiro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFinanceiro.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinanceiro.Image = ((System.Drawing.Image)(resources.GetObject("btnFinanceiro.Image")));
            this.btnFinanceiro.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnFinanceiro.Location = new System.Drawing.Point(312, 152);
            this.btnFinanceiro.Name = "btnFinanceiro";
            this.btnFinanceiro.Size = new System.Drawing.Size(108, 90);
            this.btnFinanceiro.TabIndex = 2;
            this.btnFinanceiro.Text = "Financeiro";
            this.btnFinanceiro.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnFinanceiro.UseVisualStyleBackColor = false;
            this.btnFinanceiro.Click += new System.EventHandler(this.btnFinanceiro_Click);
            // 
            // btnAdm
            // 
            this.btnAdm.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdm.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdm.Image = ((System.Drawing.Image)(resources.GetObject("btnAdm.Image")));
            this.btnAdm.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdm.Location = new System.Drawing.Point(451, 154);
            this.btnAdm.Name = "btnAdm";
            this.btnAdm.Size = new System.Drawing.Size(116, 90);
            this.btnAdm.TabIndex = 3;
            this.btnAdm.Text = "Administrador";
            this.btnAdm.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAdm.UseVisualStyleBackColor = false;
            this.btnAdm.Click += new System.EventHandler(this.btnAdm_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Projeto Circo";
            this.notifyIcon.Visible = true;
            // 
            // btnEspeta
            // 
            this.btnEspeta.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEspeta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEspeta.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEspeta.Image = ((System.Drawing.Image)(resources.GetObject("btnEspeta.Image")));
            this.btnEspeta.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEspeta.Location = new System.Drawing.Point(166, 152);
            this.btnEspeta.Name = "btnEspeta";
            this.btnEspeta.Size = new System.Drawing.Size(108, 90);
            this.btnEspeta.TabIndex = 1;
            this.btnEspeta.Text = "Espetáculo";
            this.btnEspeta.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEspeta.UseVisualStyleBackColor = false;
            this.btnEspeta.Click += new System.EventHandler(this.btnEspeta_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(783, 408);
            this.Controls.Add(this.btnEspeta);
            this.Controls.Add(this.btnAdm);
            this.Controls.Add(this.btnFinanceiro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Projeto Circo";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFinanceiro;
        private System.Windows.Forms.Button btnAdm;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.Button btnEspeta;
    }
}