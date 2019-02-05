namespace Projeto_Circo.FormsFigurino.FormsPeças
{
    partial class FrmEmail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEmail));
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOutlook = new System.Windows.Forms.Button();
            this.btnGmail = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView.Location = new System.Drawing.Point(489, 384);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 50;
            this.dataGridView.Size = new System.Drawing.Size(271, 80);
            this.dataGridView.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(390, 384);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 19);
            this.label2.TabIndex = 29;
            this.label2.Text = "Costureiro(a):";
            // 
            // btnOutlook
            // 
            this.btnOutlook.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOutlook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOutlook.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOutlook.Image = ((System.Drawing.Image)(resources.GetObject("btnOutlook.Image")));
            this.btnOutlook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOutlook.Location = new System.Drawing.Point(29, 423);
            this.btnOutlook.Name = "btnOutlook";
            this.btnOutlook.Size = new System.Drawing.Size(106, 33);
            this.btnOutlook.TabIndex = 28;
            this.btnOutlook.Text = "Outlook";
            this.btnOutlook.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOutlook.UseVisualStyleBackColor = false;
            this.btnOutlook.Click += new System.EventHandler(this.btnOutlook_Click_1);
            // 
            // btnGmail
            // 
            this.btnGmail.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGmail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGmail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGmail.Image = ((System.Drawing.Image)(resources.GetObject("btnGmail.Image")));
            this.btnGmail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGmail.Location = new System.Drawing.Point(29, 384);
            this.btnGmail.Name = "btnGmail";
            this.btnGmail.Size = new System.Drawing.Size(98, 33);
            this.btnGmail.TabIndex = 27;
            this.btnGmail.Text = "Gmail";
            this.btnGmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGmail.UseVisualStyleBackColor = false;
            this.btnGmail.Click += new System.EventHandler(this.btnGmail_Click_1);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(204, 423);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(103, 33);
            this.btnSair.TabIndex = 26;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // webBrowser
            // 
            this.webBrowser.Dock = System.Windows.Forms.DockStyle.Top;
            this.webBrowser.Location = new System.Drawing.Point(0, 0);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(800, 338);
            this.webBrowser.TabIndex = 32;
            // 
            // FrmEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 482);
            this.Controls.Add(this.webBrowser);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnOutlook);
            this.Controls.Add(this.btnGmail);
            this.Controls.Add(this.btnSair);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmEmail";
            this.Text = "Enviar email";
            this.Load += new System.EventHandler(this.FrmEmail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOutlook;
        private System.Windows.Forms.Button btnGmail;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.WebBrowser webBrowser;
    }
}