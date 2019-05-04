namespace Projeto_Circo.FormsFuncionario
{
    partial class FrmCadFuncionario
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadFuncionario));
			this.label1 = new System.Windows.Forms.Label();
			this.txtRG = new System.Windows.Forms.MaskedTextBox();
			this.btnSair = new System.Windows.Forms.Button();
			this.btnSalvar = new System.Windows.Forms.Button();
			this.label23 = new System.Windows.Forms.Label();
			this.btnInserirFoto = new System.Windows.Forms.Button();
			this.label27 = new System.Windows.Forms.Label();
			this.txtEmail = new System.Windows.Forms.MaskedTextBox();
			this.label26 = new System.Windows.Forms.Label();
			this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
			this.picFoto = new System.Windows.Forms.PictureBox();
			this.label25 = new System.Windows.Forms.Label();
			this.rbtMasculino = new System.Windows.Forms.RadioButton();
			this.rbtFeminino = new System.Windows.Forms.RadioButton();
			this.label20 = new System.Windows.Forms.Label();
			this.label22 = new System.Windows.Forms.Label();
			this.label24 = new System.Windows.Forms.Label();
			this.txtCPF = new System.Windows.Forms.MaskedTextBox();
			this.txtDataNasc = new System.Windows.Forms.MaskedTextBox();
			this.txtCargo = new System.Windows.Forms.MaskedTextBox();
			this.txtNome = new System.Windows.Forms.MaskedTextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.txtSenhaNovamente = new System.Windows.Forms.MaskedTextBox();
			this.txtUsuario = new System.Windows.Forms.MaskedTextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtSenha = new System.Windows.Forms.MaskedTextBox();
			((System.ComponentModel.ISupportInitialize)(this.picFoto)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(26, 214);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(33, 19);
			this.label1.TabIndex = 155;
			this.label1.Text = "RG:";
			// 
			// txtRG
			// 
			this.txtRG.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtRG.Location = new System.Drawing.Point(32, 233);
			this.txtRG.Mask = "00,000,000-0";
			this.txtRG.Name = "txtRG";
			this.txtRG.Size = new System.Drawing.Size(181, 26);
			this.txtRG.TabIndex = 5;
			// 
			// btnSair
			// 
			this.btnSair.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSair.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSair.Location = new System.Drawing.Point(244, 420);
			this.btnSair.Name = "btnSair";
			this.btnSair.Size = new System.Drawing.Size(95, 33);
			this.btnSair.TabIndex = 13;
			this.btnSair.Text = "Sair";
			this.btnSair.UseVisualStyleBackColor = false;
			this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
			// 
			// btnSalvar
			// 
			this.btnSalvar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSalvar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSalvar.Location = new System.Drawing.Point(114, 420);
			this.btnSalvar.Name = "btnSalvar";
			this.btnSalvar.Size = new System.Drawing.Size(97, 33);
			this.btnSalvar.TabIndex = 12;
			this.btnSalvar.Text = "Salvar";
			this.btnSalvar.UseVisualStyleBackColor = false;
			this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
			// 
			// label23
			// 
			this.label23.AutoSize = true;
			this.label23.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label23.Location = new System.Drawing.Point(27, 73);
			this.label23.Name = "label23";
			this.label23.Size = new System.Drawing.Size(50, 19);
			this.label23.TabIndex = 141;
			this.label23.Text = "Cargo:";
			// 
			// btnInserirFoto
			// 
			this.btnInserirFoto.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnInserirFoto.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnInserirFoto.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnInserirFoto.Location = new System.Drawing.Point(323, 190);
			this.btnInserirFoto.Name = "btnInserirFoto";
			this.btnInserirFoto.Size = new System.Drawing.Size(90, 33);
			this.btnInserirFoto.TabIndex = 10;
			this.btnInserirFoto.Text = "Inserir foto";
			this.btnInserirFoto.UseVisualStyleBackColor = false;
			this.btnInserirFoto.Click += new System.EventHandler(this.btnInserirFoto_Click);
			// 
			// label27
			// 
			this.label27.AutoSize = true;
			this.label27.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label27.Location = new System.Drawing.Point(29, 348);
			this.label27.Name = "label27";
			this.label27.Size = new System.Drawing.Size(45, 19);
			this.label27.TabIndex = 148;
			this.label27.Text = "Email:";
			// 
			// txtEmail
			// 
			this.txtEmail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtEmail.Location = new System.Drawing.Point(32, 367);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(181, 26);
			this.txtEmail.TabIndex = 9;
			// 
			// label26
			// 
			this.label26.AutoSize = true;
			this.label26.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label26.Location = new System.Drawing.Point(26, 298);
			this.label26.Name = "label26";
			this.label26.Size = new System.Drawing.Size(63, 19);
			this.label26.TabIndex = 147;
			this.label26.Text = "Telefone:";
			// 
			// txtTelefone
			// 
			this.txtTelefone.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTelefone.Location = new System.Drawing.Point(30, 320);
			this.txtTelefone.Name = "txtTelefone";
			this.txtTelefone.Size = new System.Drawing.Size(181, 26);
			this.txtTelefone.TabIndex = 8;
			// 
			// picFoto
			// 
			this.picFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.picFoto.Location = new System.Drawing.Point(281, 12);
			this.picFoto.Name = "picFoto";
			this.picFoto.Size = new System.Drawing.Size(171, 172);
			this.picFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picFoto.TabIndex = 145;
			this.picFoto.TabStop = false;
			// 
			// label25
			// 
			this.label25.AutoSize = true;
			this.label25.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label25.Location = new System.Drawing.Point(28, 256);
			this.label25.Name = "label25";
			this.label25.Size = new System.Drawing.Size(43, 19);
			this.label25.TabIndex = 144;
			this.label25.Text = "Sexo:";
			// 
			// rbtMasculino
			// 
			this.rbtMasculino.AutoSize = true;
			this.rbtMasculino.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbtMasculino.Location = new System.Drawing.Point(126, 272);
			this.rbtMasculino.Name = "rbtMasculino";
			this.rbtMasculino.Size = new System.Drawing.Size(89, 23);
			this.rbtMasculino.TabIndex = 7;
			this.rbtMasculino.TabStop = true;
			this.rbtMasculino.Text = "Masculino";
			this.rbtMasculino.UseVisualStyleBackColor = true;
			// 
			// rbtFeminino
			// 
			this.rbtFeminino.AutoSize = true;
			this.rbtFeminino.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbtFeminino.Location = new System.Drawing.Point(38, 272);
			this.rbtFeminino.Name = "rbtFeminino";
			this.rbtFeminino.Size = new System.Drawing.Size(82, 23);
			this.rbtFeminino.TabIndex = 6;
			this.rbtFeminino.TabStop = true;
			this.rbtFeminino.Text = "Feminino";
			this.rbtFeminino.UseVisualStyleBackColor = true;
			// 
			// label20
			// 
			this.label20.AutoSize = true;
			this.label20.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label20.Location = new System.Drawing.Point(26, 169);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(41, 19);
			this.label20.TabIndex = 143;
			this.label20.Text = "CPF:";
			// 
			// label22
			// 
			this.label22.AutoSize = true;
			this.label22.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label22.Location = new System.Drawing.Point(27, 122);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(131, 19);
			this.label22.TabIndex = 142;
			this.label22.Text = "Data de nascimento:";
			// 
			// label24
			// 
			this.label24.AutoSize = true;
			this.label24.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label24.Location = new System.Drawing.Point(27, 22);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(140, 19);
			this.label24.TabIndex = 140;
			this.label24.Text = "Nome do funcionário:";
			// 
			// txtCPF
			// 
			this.txtCPF.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCPF.Location = new System.Drawing.Point(31, 188);
			this.txtCPF.Mask = "000,000,000-00";
			this.txtCPF.Name = "txtCPF";
			this.txtCPF.Size = new System.Drawing.Size(181, 26);
			this.txtCPF.TabIndex = 4;
			// 
			// txtDataNasc
			// 
			this.txtDataNasc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDataNasc.Location = new System.Drawing.Point(30, 142);
			this.txtDataNasc.Mask = "00/00/0000";
			this.txtDataNasc.Name = "txtDataNasc";
			this.txtDataNasc.Size = new System.Drawing.Size(181, 26);
			this.txtDataNasc.TabIndex = 3;
			// 
			// txtCargo
			// 
			this.txtCargo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCargo.Location = new System.Drawing.Point(30, 93);
			this.txtCargo.Name = "txtCargo";
			this.txtCargo.Size = new System.Drawing.Size(181, 26);
			this.txtCargo.TabIndex = 2;
			// 
			// txtNome
			// 
			this.txtNome.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNome.Location = new System.Drawing.Point(30, 44);
			this.txtNome.Name = "txtNome";
			this.txtNome.Size = new System.Drawing.Size(181, 26);
			this.txtNome.TabIndex = 1;
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.txtSenhaNovamente);
			this.panel1.Controls.Add(this.txtUsuario);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.txtSenha);
			this.panel1.Location = new System.Drawing.Point(281, 233);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(171, 165);
			this.panel1.TabIndex = 11;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(18, 106);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(118, 19);
			this.label2.TabIndex = 173;
			this.label2.Text = "Senha novamente:";
			// 
			// txtSenhaNovamente
			// 
			this.txtSenhaNovamente.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSenhaNovamente.Location = new System.Drawing.Point(18, 128);
			this.txtSenhaNovamente.Name = "txtSenhaNovamente";
			this.txtSenhaNovamente.Size = new System.Drawing.Size(118, 26);
			this.txtSenhaNovamente.TabIndex = 3;
			// 
			// txtUsuario
			// 
			this.txtUsuario.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtUsuario.Location = new System.Drawing.Point(18, 30);
			this.txtUsuario.Name = "txtUsuario";
			this.txtUsuario.Size = new System.Drawing.Size(118, 26);
			this.txtUsuario.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(14, 54);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(53, 19);
			this.label3.TabIndex = 171;
			this.label3.Text = " Senha:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(14, 9);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(59, 19);
			this.label4.TabIndex = 169;
			this.label4.Text = "Usuário:";
			// 
			// txtSenha
			// 
			this.txtSenha.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSenha.Location = new System.Drawing.Point(18, 76);
			this.txtSenha.Name = "txtSenha";
			this.txtSenha.Size = new System.Drawing.Size(118, 26);
			this.txtSenha.TabIndex = 2;
			// 
			// FrmCadFuncionario
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.ClientSize = new System.Drawing.Size(488, 461);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtRG);
			this.Controls.Add(this.btnSair);
			this.Controls.Add(this.btnSalvar);
			this.Controls.Add(this.label23);
			this.Controls.Add(this.btnInserirFoto);
			this.Controls.Add(this.label27);
			this.Controls.Add(this.txtEmail);
			this.Controls.Add(this.label26);
			this.Controls.Add(this.txtTelefone);
			this.Controls.Add(this.picFoto);
			this.Controls.Add(this.label25);
			this.Controls.Add(this.rbtMasculino);
			this.Controls.Add(this.rbtFeminino);
			this.Controls.Add(this.label20);
			this.Controls.Add(this.label22);
			this.Controls.Add(this.label24);
			this.Controls.Add(this.txtCPF);
			this.Controls.Add(this.txtDataNasc);
			this.Controls.Add(this.txtCargo);
			this.Controls.Add(this.txtNome);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FrmCadFuncionario";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ADM - Cadastro de funcionário";
			this.Load += new System.EventHandler(this.FrmCadFuncionario_Load);
			((System.ComponentModel.ISupportInitialize)(this.picFoto)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtRG;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Button btnInserirFoto;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.MaskedTextBox txtEmail;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.PictureBox picFoto;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.RadioButton rbtMasculino;
        private System.Windows.Forms.RadioButton rbtFeminino;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.MaskedTextBox txtCPF;
        private System.Windows.Forms.MaskedTextBox txtDataNasc;
        private System.Windows.Forms.MaskedTextBox txtCargo;
        private System.Windows.Forms.MaskedTextBox txtNome;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtSenhaNovamente;
        private System.Windows.Forms.MaskedTextBox txtUsuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox txtSenha;
	}
}