namespace Projeto_Circo
{
    partial class FrmMenuADM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuADM));
            this.btnFuncionario = new System.Windows.Forms.Button();
            this.btnFinanceiro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFuncionario
            // 
            this.btnFuncionario.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFuncionario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFuncionario.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFuncionario.Image = ((System.Drawing.Image)(resources.GetObject("btnFuncionario.Image")));
            this.btnFuncionario.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFuncionario.Location = new System.Drawing.Point(72, 64);
            this.btnFuncionario.Name = "btnFuncionario";
            this.btnFuncionario.Size = new System.Drawing.Size(116, 90);
            this.btnFuncionario.TabIndex = 4;
            this.btnFuncionario.Text = "Funcionário";
            this.btnFuncionario.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnFuncionario.UseVisualStyleBackColor = false;
            this.btnFuncionario.Click += new System.EventHandler(this.btnFuncionario_Click);
            // 
            // btnFinanceiro
            // 
            this.btnFinanceiro.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFinanceiro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFinanceiro.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinanceiro.Image = ((System.Drawing.Image)(resources.GetObject("btnFinanceiro.Image")));
            this.btnFinanceiro.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFinanceiro.Location = new System.Drawing.Point(239, 64);
            this.btnFinanceiro.Name = "btnFinanceiro";
            this.btnFinanceiro.Size = new System.Drawing.Size(116, 90);
            this.btnFinanceiro.TabIndex = 5;
            this.btnFinanceiro.Text = "Financeiro";
            this.btnFinanceiro.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnFinanceiro.UseVisualStyleBackColor = false;
            this.btnFinanceiro.Click += new System.EventHandler(this.btnFinanceiro_Click);
            // 
            // FrmMenuADM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(425, 199);
            this.Controls.Add(this.btnFinanceiro);
            this.Controls.Add(this.btnFuncionario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMenuADM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrador";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFuncionario;
        private System.Windows.Forms.Button btnFinanceiro;
    }
}