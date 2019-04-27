namespace Projeto_Circo.FormsLogin
{
    partial class FrmLoginFinanceiro
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLoginFinanceiro));
			this.panel1 = new System.Windows.Forms.Panel();
			this.txtSenha = new System.Windows.Forms.TextBox();
			this.txtUsuario = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.lblUsuario = new System.Windows.Forms.Label();
			this.btnLogar = new System.Windows.Forms.Button();
			this.btnLimpar = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.txtSenha);
			this.panel1.Controls.Add(this.txtUsuario);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.lblUsuario);
			this.panel1.Location = new System.Drawing.Point(18, 61);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(251, 108);
			this.panel1.TabIndex = 0;
			// 
			// txtSenha
			// 
			this.txtSenha.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSenha.Location = new System.Drawing.Point(15, 74);
			this.txtSenha.Name = "txtSenha";
			this.txtSenha.Size = new System.Drawing.Size(227, 26);
			this.txtSenha.TabIndex = 3;
			// 
			// txtUsuario
			// 
			this.txtUsuario.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtUsuario.Location = new System.Drawing.Point(15, 28);
			this.txtUsuario.Name = "txtUsuario";
			this.txtUsuario.Size = new System.Drawing.Size(227, 26);
			this.txtUsuario.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(12, 54);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(49, 19);
			this.label2.TabIndex = 1;
			this.label2.Text = "Senha:";
			// 
			// lblUsuario
			// 
			this.lblUsuario.AutoSize = true;
			this.lblUsuario.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblUsuario.Location = new System.Drawing.Point(12, 7);
			this.lblUsuario.Name = "lblUsuario";
			this.lblUsuario.Size = new System.Drawing.Size(59, 19);
			this.lblUsuario.TabIndex = 0;
			this.lblUsuario.Text = "Usuario:";
			// 
			// btnLogar
			// 
			this.btnLogar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnLogar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLogar.Location = new System.Drawing.Point(43, 175);
			this.btnLogar.Name = "btnLogar";
			this.btnLogar.Size = new System.Drawing.Size(75, 30);
			this.btnLogar.TabIndex = 2;
			this.btnLogar.Text = "Entrar";
			this.btnLogar.UseVisualStyleBackColor = false;
			this.btnLogar.Click += new System.EventHandler(this.btnLogar_Click);
			// 
			// btnLimpar
			// 
			this.btnLimpar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnLimpar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLimpar.Location = new System.Drawing.Point(159, 175);
			this.btnLimpar.Name = "btnLimpar";
			this.btnLimpar.Size = new System.Drawing.Size(75, 30);
			this.btnLimpar.TabIndex = 3;
			this.btnLimpar.Text = "Limpar";
			this.btnLimpar.UseVisualStyleBackColor = false;
			this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(125, 13);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(37, 42);
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// FrmLoginFinanceiro
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.ClientSize = new System.Drawing.Size(288, 216);
			this.Controls.Add(this.btnLimpar);
			this.Controls.Add(this.btnLogar);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FrmLoginFinanceiro";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Login Financeiro";
			this.Load += new System.EventHandler(this.FrmLoginFinanceiro_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLogar;
        private System.Windows.Forms.Button btnLimpar;
    }
}