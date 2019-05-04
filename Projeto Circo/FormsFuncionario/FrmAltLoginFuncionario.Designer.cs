namespace Projeto_Circo.FormsFuncionario
{
    partial class FrmAltLoginFuncionario
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAltLoginFuncionario));
			this.label24 = new System.Windows.Forms.Label();
			this.txtUsuario = new System.Windows.Forms.MaskedTextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtSenha = new System.Windows.Forms.MaskedTextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtSenhaNovamente = new System.Windows.Forms.MaskedTextBox();
			this.btnSair = new System.Windows.Forms.Button();
			this.btnEditar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label24
			// 
			this.label24.AutoSize = true;
			this.label24.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label24.Location = new System.Drawing.Point(32, 31);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(59, 19);
			this.label24.TabIndex = 92;
			this.label24.Text = "Usuário:";
			// 
			// txtUsuario
			// 
			this.txtUsuario.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtUsuario.Location = new System.Drawing.Point(35, 53);
			this.txtUsuario.Name = "txtUsuario";
			this.txtUsuario.Size = new System.Drawing.Size(181, 26);
			this.txtUsuario.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(32, 103);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(84, 19);
			this.label1.TabIndex = 94;
			this.label1.Text = "Nova senha:";
			// 
			// txtSenha
			// 
			this.txtSenha.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSenha.Location = new System.Drawing.Point(35, 125);
			this.txtSenha.Name = "txtSenha";
			this.txtSenha.Size = new System.Drawing.Size(181, 26);
			this.txtSenha.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(32, 170);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(153, 19);
			this.label2.TabIndex = 96;
			this.label2.Text = "Nova senha novamente:";
			// 
			// txtSenhaNovamente
			// 
			this.txtSenhaNovamente.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSenhaNovamente.Location = new System.Drawing.Point(35, 192);
			this.txtSenhaNovamente.Name = "txtSenhaNovamente";
			this.txtSenhaNovamente.Size = new System.Drawing.Size(181, 26);
			this.txtSenhaNovamente.TabIndex = 3;
			// 
			// btnSair
			// 
			this.btnSair.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSair.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSair.Location = new System.Drawing.Point(150, 239);
			this.btnSair.Name = "btnSair";
			this.btnSair.Size = new System.Drawing.Size(95, 33);
			this.btnSair.TabIndex = 5;
			this.btnSair.Text = "Sair";
			this.btnSair.UseVisualStyleBackColor = false;
			this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
			// 
			// btnEditar
			// 
			this.btnEditar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnEditar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEditar.Location = new System.Drawing.Point(24, 239);
			this.btnEditar.Name = "btnEditar";
			this.btnEditar.Size = new System.Drawing.Size(97, 33);
			this.btnEditar.TabIndex = 4;
			this.btnEditar.Text = "Editar";
			this.btnEditar.UseVisualStyleBackColor = false;
			this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
			// 
			// FrmAltLoginFuncionario
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.ClientSize = new System.Drawing.Size(275, 283);
			this.Controls.Add(this.btnSair);
			this.Controls.Add(this.btnEditar);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtSenhaNovamente);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtSenha);
			this.Controls.Add(this.label24);
			this.Controls.Add(this.txtUsuario);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FrmAltLoginFuncionario";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Alterar senha";
			this.Load += new System.EventHandler(this.FrmAltLoginFuncionario_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.MaskedTextBox txtUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtSenha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtSenhaNovamente;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnEditar;
    }
}