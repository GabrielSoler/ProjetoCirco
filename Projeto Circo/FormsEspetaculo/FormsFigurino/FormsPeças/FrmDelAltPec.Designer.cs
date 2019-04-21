namespace Projeto_Circo.FormsFigurino
{
    partial class FrmDelAltPec
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDelAltPec));
			this.panel2 = new System.Windows.Forms.Panel();
			this.btnInserirImage = new System.Windows.Forms.Button();
			this.picFoto = new System.Windows.Forms.PictureBox();
			this.label7 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.rbtInativo = new System.Windows.Forms.RadioButton();
			this.rbtAtivo = new System.Windows.Forms.RadioButton();
			this.txtNotas = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.rbtNao = new System.Windows.Forms.RadioButton();
			this.rbtSim = new System.Windows.Forms.RadioButton();
			this.label4 = new System.Windows.Forms.Label();
			this.txtQtdComp = new System.Windows.Forms.MaskedTextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtCodPec = new System.Windows.Forms.MaskedTextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.lstColecao = new System.Windows.Forms.ListBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnSair = new System.Windows.Forms.Button();
			this.btnEditar = new System.Windows.Forms.Button();
			this.btnExcluir = new System.Windows.Forms.Button();
			this.btnCostureira = new System.Windows.Forms.Button();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picFoto)).BeginInit();
			this.panel1.SuspendLayout();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel2
			// 
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel2.Controls.Add(this.btnInserirImage);
			this.panel2.Controls.Add(this.picFoto);
			this.panel2.Controls.Add(this.label7);
			this.panel2.Location = new System.Drawing.Point(333, 12);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(239, 385);
			this.panel2.TabIndex = 15;
			// 
			// btnInserirImage
			// 
			this.btnInserirImage.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnInserirImage.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnInserirImage.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnInserirImage.Image = ((System.Drawing.Image)(resources.GetObject("btnInserirImage.Image")));
			this.btnInserirImage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnInserirImage.Location = new System.Drawing.Point(45, 309);
			this.btnInserirImage.Name = "btnInserirImage";
			this.btnInserirImage.Size = new System.Drawing.Size(152, 46);
			this.btnInserirImage.TabIndex = 9;
			this.btnInserirImage.Text = "Trocar Croqui";
			this.btnInserirImage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnInserirImage.UseVisualStyleBackColor = false;
			this.btnInserirImage.Click += new System.EventHandler(this.btnInserirImage_Click);
			// 
			// picFoto
			// 
			this.picFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.picFoto.Location = new System.Drawing.Point(45, 41);
			this.picFoto.Name = "picFoto";
			this.picFoto.Size = new System.Drawing.Size(152, 223);
			this.picFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picFoto.TabIndex = 13;
			this.picFoto.TabStop = false;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(19, 15);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(204, 21);
			this.label7.TabIndex = 12;
			this.label7.Text = "Inserir anexo dos croquis:";
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.panel3);
			this.panel1.Controls.Add(this.txtNotas);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.rbtNao);
			this.panel1.Controls.Add(this.rbtSim);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.txtQtdComp);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.txtCodPec);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.lstColecao);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(12, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(266, 385);
			this.panel1.TabIndex = 14;
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.rbtInativo);
			this.panel3.Controls.Add(this.rbtAtivo);
			this.panel3.Location = new System.Drawing.Point(17, 276);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(200, 30);
			this.panel3.TabIndex = 15;
			// 
			// rbtInativo
			// 
			this.rbtInativo.AutoSize = true;
			this.rbtInativo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbtInativo.Location = new System.Drawing.Point(123, 4);
			this.rbtInativo.Name = "rbtInativo";
			this.rbtInativo.Size = new System.Drawing.Size(68, 23);
			this.rbtInativo.TabIndex = 12;
			this.rbtInativo.TabStop = true;
			this.rbtInativo.Text = "Inativo";
			this.rbtInativo.UseVisualStyleBackColor = true;
			// 
			// rbtAtivo
			// 
			this.rbtAtivo.AutoSize = true;
			this.rbtAtivo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbtAtivo.Location = new System.Drawing.Point(14, 4);
			this.rbtAtivo.Name = "rbtAtivo";
			this.rbtAtivo.Size = new System.Drawing.Size(60, 23);
			this.rbtAtivo.TabIndex = 11;
			this.rbtAtivo.TabStop = true;
			this.rbtAtivo.Text = "Ativo";
			this.rbtAtivo.UseVisualStyleBackColor = true;
			// 
			// txtNotas
			// 
			this.txtNotas.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNotas.Location = new System.Drawing.Point(17, 325);
			this.txtNotas.Multiline = true;
			this.txtNotas.Name = "txtNotas";
			this.txtNotas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtNotas.Size = new System.Drawing.Size(215, 43);
			this.txtNotas.TabIndex = 8;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(14, 309);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(49, 19);
			this.label6.TabIndex = 10;
			this.label6.Text = "Notas:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(13, 258);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(64, 19);
			this.label5.TabIndex = 9;
			this.label5.Text = "Situação:";
			// 
			// rbtNao
			// 
			this.rbtNao.AutoSize = true;
			this.rbtNao.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbtNao.Location = new System.Drawing.Point(126, 232);
			this.rbtNao.Name = "rbtNao";
			this.rbtNao.Size = new System.Drawing.Size(54, 23);
			this.rbtNao.TabIndex = 5;
			this.rbtNao.TabStop = true;
			this.rbtNao.Text = "Não";
			this.rbtNao.UseVisualStyleBackColor = true;
			// 
			// rbtSim
			// 
			this.rbtSim.AutoSize = true;
			this.rbtSim.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbtSim.Location = new System.Drawing.Point(17, 232);
			this.rbtSim.Name = "rbtSim";
			this.rbtSim.Size = new System.Drawing.Size(50, 23);
			this.rbtSim.TabIndex = 4;
			this.rbtSim.TabStop = true;
			this.rbtSim.Text = "Sim";
			this.rbtSim.UseVisualStyleBackColor = true;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(14, 216);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(129, 19);
			this.label4.TabIndex = 6;
			this.label4.Text = "Precisa de reparos?";
			// 
			// txtQtdComp
			// 
			this.txtQtdComp.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtQtdComp.Location = new System.Drawing.Point(18, 187);
			this.txtQtdComp.Name = "txtQtdComp";
			this.txtQtdComp.Size = new System.Drawing.Size(165, 26);
			this.txtQtdComp.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(14, 169);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(185, 19);
			this.label3.TabIndex = 4;
			this.label3.Text = "Quantidade de componentes:";
			// 
			// txtCodPec
			// 
			this.txtCodPec.Enabled = false;
			this.txtCodPec.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCodPec.Location = new System.Drawing.Point(18, 143);
			this.txtCodPec.Mask = "00,00000";
			this.txtCodPec.Name = "txtCodPec";
			this.txtCodPec.Size = new System.Drawing.Size(165, 26);
			this.txtCodPec.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(14, 121);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(109, 19);
			this.label2.TabIndex = 2;
			this.label2.Text = "Código da peça:";
			// 
			// lstColecao
			// 
			this.lstColecao.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lstColecao.FormattingEnabled = true;
			this.lstColecao.ItemHeight = 19;
			this.lstColecao.Location = new System.Drawing.Point(17, 37);
			this.lstColecao.Name = "lstColecao";
			this.lstColecao.ScrollAlwaysVisible = true;
			this.lstColecao.Size = new System.Drawing.Size(209, 80);
			this.lstColecao.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(14, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(63, 19);
			this.label1.TabIndex = 0;
			this.label1.Text = "Coleção:";
			// 
			// btnSair
			// 
			this.btnSair.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSair.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
			this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSair.Location = new System.Drawing.Point(469, 411);
			this.btnSair.Name = "btnSair";
			this.btnSair.Size = new System.Drawing.Size(103, 33);
			this.btnSair.TabIndex = 18;
			this.btnSair.Text = "Sair";
			this.btnSair.UseVisualStyleBackColor = false;
			this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
			// 
			// btnEditar
			// 
			this.btnEditar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnEditar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
			this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnEditar.Location = new System.Drawing.Point(30, 411);
			this.btnEditar.Name = "btnEditar";
			this.btnEditar.Size = new System.Drawing.Size(106, 33);
			this.btnEditar.TabIndex = 17;
			this.btnEditar.Text = "Editar";
			this.btnEditar.UseVisualStyleBackColor = false;
			this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
			// 
			// btnExcluir
			// 
			this.btnExcluir.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnExcluir.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnExcluir.Location = new System.Drawing.Point(172, 411);
			this.btnExcluir.Name = "btnExcluir";
			this.btnExcluir.Size = new System.Drawing.Size(106, 33);
			this.btnExcluir.TabIndex = 19;
			this.btnExcluir.Text = "Excluir";
			this.btnExcluir.UseVisualStyleBackColor = false;
			this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
			// 
			// btnCostureira
			// 
			this.btnCostureira.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnCostureira.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnCostureira.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCostureira.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCostureira.Location = new System.Drawing.Point(333, 403);
			this.btnCostureira.Name = "btnCostureira";
			this.btnCostureira.Size = new System.Drawing.Size(103, 48);
			this.btnCostureira.TabIndex = 16;
			this.btnCostureira.Text = "Alerta Costureira";
			this.btnCostureira.UseVisualStyleBackColor = false;
			this.btnCostureira.Click += new System.EventHandler(this.btnCostureira_Click);
			// 
			// FrmDelAltPec
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.ClientSize = new System.Drawing.Size(603, 458);
			this.Controls.Add(this.btnCostureira);
			this.Controls.Add(this.btnExcluir);
			this.Controls.Add(this.btnSair);
			this.Controls.Add(this.btnEditar);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FrmDelAltPec";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Peças - Consultas";
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.picFoto)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnInserirImage;
        private System.Windows.Forms.PictureBox picFoto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtNotas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbtNao;
        private System.Windows.Forms.RadioButton rbtSim;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox txtQtdComp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txtCodPec;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstColecao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnCostureira;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.RadioButton rbtInativo;
		private System.Windows.Forms.RadioButton rbtAtivo;
	}
}