namespace Projeto_Circo.FormsFinanceiro
{
    partial class FrmCadFinanceiro
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadFinanceiro));
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.btnSalvar = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.txtBuscarEsp = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.pnlBuscar = new System.Windows.Forms.Panel();
			this.btnTudo = new System.Windows.Forms.Button();
			this.lstPesquisa = new System.Windows.Forms.ListBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.rbtNORealizado = new System.Windows.Forms.RadioButton();
			this.rbtRealizado = new System.Windows.Forms.RadioButton();
			this.panel3 = new System.Windows.Forms.Panel();
			this.rbtAtraso = new System.Windows.Forms.RadioButton();
			this.rbtPago = new System.Windows.Forms.RadioButton();
			this.lstPresente = new System.Windows.Forms.ListBox();
			this.lstConvocado = new System.Windows.Forms.ListBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txtFormaPag = new System.Windows.Forms.TextBox();
			this.txtPrevisaoPaga = new System.Windows.Forms.MaskedTextBox();
			this.txtCacheArtista = new System.Windows.Forms.MaskedTextBox();
			this.txtTotalAReceber = new System.Windows.Forms.MaskedTextBox();
			this.txtContratante = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.pnlBuscar.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.btnCancelar);
			this.panel1.Controls.Add(this.btnSalvar);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Controls.Add(this.txtBuscarEsp);
			this.panel1.Controls.Add(this.label10);
			this.panel1.Controls.Add(this.pnlBuscar);
			this.panel1.Controls.Add(this.label9);
			this.panel1.Controls.Add(this.label8);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Controls.Add(this.panel3);
			this.panel1.Controls.Add(this.lstPresente);
			this.panel1.Controls.Add(this.lstConvocado);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.txtFormaPag);
			this.panel1.Controls.Add(this.txtPrevisaoPaga);
			this.panel1.Controls.Add(this.txtCacheArtista);
			this.panel1.Controls.Add(this.txtTotalAReceber);
			this.panel1.Controls.Add(this.txtContratante);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Location = new System.Drawing.Point(12, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(449, 430);
			this.panel1.TabIndex = 0;
			// 
			// btnCancelar
			// 
			this.btnCancelar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnCancelar.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCancelar.Location = new System.Drawing.Point(345, 330);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(90, 33);
			this.btnCancelar.TabIndex = 47;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.UseVisualStyleBackColor = false;
			this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
			// 
			// btnSalvar
			// 
			this.btnSalvar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSalvar.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSalvar.Location = new System.Drawing.Point(345, 255);
			this.btnSalvar.Name = "btnSalvar";
			this.btnSalvar.Size = new System.Drawing.Size(90, 33);
			this.btnSalvar.TabIndex = 45;
			this.btnSalvar.Text = "Salvar";
			this.btnSalvar.UseVisualStyleBackColor = false;
			this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(231, 20);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(24, 23);
			this.pictureBox1.TabIndex = 52;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// txtBuscarEsp
			// 
			this.txtBuscarEsp.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtBuscarEsp.Location = new System.Drawing.Point(261, 20);
			this.txtBuscarEsp.Name = "txtBuscarEsp";
			this.txtBuscarEsp.Size = new System.Drawing.Size(169, 26);
			this.txtBuscarEsp.TabIndex = 43;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(228, 3);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(78, 19);
			this.label10.TabIndex = 51;
			this.label10.Text = "Espetáculo:";
			// 
			// pnlBuscar
			// 
			this.pnlBuscar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.pnlBuscar.Controls.Add(this.btnTudo);
			this.pnlBuscar.Controls.Add(this.lstPesquisa);
			this.pnlBuscar.Location = new System.Drawing.Point(232, 46);
			this.pnlBuscar.Name = "pnlBuscar";
			this.pnlBuscar.Size = new System.Drawing.Size(206, 157);
			this.pnlBuscar.TabIndex = 44;
			// 
			// btnTudo
			// 
			this.btnTudo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnTudo.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnTudo.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnTudo.Image = global::Projeto_Circo.Properties.Resources.mostrarBitmap;
			this.btnTudo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnTudo.Location = new System.Drawing.Point(25, 119);
			this.btnTudo.Name = "btnTudo";
			this.btnTudo.Size = new System.Drawing.Size(149, 33);
			this.btnTudo.TabIndex = 2;
			this.btnTudo.Text = "Exibir Todos";
			this.btnTudo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnTudo.UseVisualStyleBackColor = false;
			this.btnTudo.Click += new System.EventHandler(this.btnTudo_Click);
			// 
			// lstPesquisa
			// 
			this.lstPesquisa.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lstPesquisa.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lstPesquisa.ForeColor = System.Drawing.Color.Goldenrod;
			this.lstPesquisa.FormattingEnabled = true;
			this.lstPesquisa.ItemHeight = 17;
			this.lstPesquisa.Location = new System.Drawing.Point(9, 7);
			this.lstPesquisa.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
			this.lstPesquisa.Name = "lstPesquisa";
			this.lstPesquisa.ScrollAlwaysVisible = true;
			this.lstPesquisa.Size = new System.Drawing.Size(194, 106);
			this.lstPesquisa.TabIndex = 1;
			this.lstPesquisa.Click += new System.EventHandler(this.lstPesquisa_Click);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(177, 224);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(78, 19);
			this.label9.TabIndex = 50;
			this.label9.Text = "Espetáculo:";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(10, 224);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(49, 19);
			this.label8.TabIndex = 49;
			this.label8.Text = "Status:";
			// 
			// panel2
			// 
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel2.Controls.Add(this.rbtNORealizado);
			this.panel2.Controls.Add(this.rbtRealizado);
			this.panel2.Location = new System.Drawing.Point(181, 242);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(132, 52);
			this.panel2.TabIndex = 40;
			// 
			// rbtNORealizado
			// 
			this.rbtNORealizado.AutoSize = true;
			this.rbtNORealizado.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbtNORealizado.Location = new System.Drawing.Point(12, 28);
			this.rbtNORealizado.Name = "rbtNORealizado";
			this.rbtNORealizado.Size = new System.Drawing.Size(112, 23);
			this.rbtNORealizado.TabIndex = 2;
			this.rbtNORealizado.TabStop = true;
			this.rbtNORealizado.Text = "Não realizado";
			this.rbtNORealizado.UseVisualStyleBackColor = true;
			// 
			// rbtRealizado
			// 
			this.rbtRealizado.AutoSize = true;
			this.rbtRealizado.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbtRealizado.Location = new System.Drawing.Point(12, 3);
			this.rbtRealizado.Name = "rbtRealizado";
			this.rbtRealizado.Size = new System.Drawing.Size(86, 23);
			this.rbtRealizado.TabIndex = 1;
			this.rbtRealizado.TabStop = true;
			this.rbtRealizado.Text = "Realizado";
			this.rbtRealizado.UseVisualStyleBackColor = true;
			// 
			// panel3
			// 
			this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel3.Controls.Add(this.rbtAtraso);
			this.panel3.Controls.Add(this.rbtPago);
			this.panel3.Location = new System.Drawing.Point(14, 242);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(132, 52);
			this.panel3.TabIndex = 38;
			// 
			// rbtAtraso
			// 
			this.rbtAtraso.AutoSize = true;
			this.rbtAtraso.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbtAtraso.Location = new System.Drawing.Point(13, 28);
			this.rbtAtraso.Name = "rbtAtraso";
			this.rbtAtraso.Size = new System.Drawing.Size(88, 23);
			this.rbtAtraso.TabIndex = 2;
			this.rbtAtraso.TabStop = true;
			this.rbtAtraso.Text = "Em atraso";
			this.rbtAtraso.UseVisualStyleBackColor = true;
			// 
			// rbtPago
			// 
			this.rbtPago.AutoSize = true;
			this.rbtPago.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbtPago.Location = new System.Drawing.Point(13, 3);
			this.rbtPago.Name = "rbtPago";
			this.rbtPago.Size = new System.Drawing.Size(58, 23);
			this.rbtPago.TabIndex = 1;
			this.rbtPago.TabStop = true;
			this.rbtPago.Text = "Pago";
			this.rbtPago.UseVisualStyleBackColor = true;
			// 
			// lstPresente
			// 
			this.lstPresente.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lstPresente.FormattingEnabled = true;
			this.lstPresente.ItemHeight = 15;
			this.lstPresente.Location = new System.Drawing.Point(176, 319);
			this.lstPresente.Name = "lstPresente";
			this.lstPresente.ScrollAlwaysVisible = true;
			this.lstPresente.Size = new System.Drawing.Size(137, 94);
			this.lstPresente.TabIndex = 42;
			this.lstPresente.Click += new System.EventHandler(this.lstPresente_Click);
			// 
			// lstConvocado
			// 
			this.lstConvocado.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lstConvocado.FormattingEnabled = true;
			this.lstConvocado.ItemHeight = 15;
			this.lstConvocado.Location = new System.Drawing.Point(14, 319);
			this.lstConvocado.Name = "lstConvocado";
			this.lstConvocado.ScrollAlwaysVisible = true;
			this.lstConvocado.Size = new System.Drawing.Size(137, 94);
			this.lstConvocado.TabIndex = 41;
			this.lstConvocado.Click += new System.EventHandler(this.lstConvocado_Click);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(172, 297);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(107, 19);
			this.label7.TabIndex = 48;
			this.label7.Text = "Artista presente:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(10, 297);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(123, 19);
			this.label6.TabIndex = 46;
			this.label6.Text = "Artista convocado:";
			// 
			// txtFormaPag
			// 
			this.txtFormaPag.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtFormaPag.Location = new System.Drawing.Point(14, 199);
			this.txtFormaPag.Name = "txtFormaPag";
			this.txtFormaPag.Size = new System.Drawing.Size(169, 26);
			this.txtFormaPag.TabIndex = 36;
			// 
			// txtPrevisaoPaga
			// 
			this.txtPrevisaoPaga.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPrevisaoPaga.Location = new System.Drawing.Point(14, 154);
			this.txtPrevisaoPaga.Mask = "00/00/0000";
			this.txtPrevisaoPaga.Name = "txtPrevisaoPaga";
			this.txtPrevisaoPaga.Size = new System.Drawing.Size(169, 26);
			this.txtPrevisaoPaga.TabIndex = 33;
			// 
			// txtCacheArtista
			// 
			this.txtCacheArtista.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCacheArtista.Location = new System.Drawing.Point(14, 109);
			this.txtCacheArtista.Mask = "$ ####,##";
			this.txtCacheArtista.Name = "txtCacheArtista";
			this.txtCacheArtista.Size = new System.Drawing.Size(169, 26);
			this.txtCacheArtista.TabIndex = 32;
			// 
			// txtTotalAReceber
			// 
			this.txtTotalAReceber.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTotalAReceber.Location = new System.Drawing.Point(14, 68);
			this.txtTotalAReceber.Mask = "$ #####,##";
			this.txtTotalAReceber.Name = "txtTotalAReceber";
			this.txtTotalAReceber.Size = new System.Drawing.Size(169, 26);
			this.txtTotalAReceber.TabIndex = 30;
			// 
			// txtContratante
			// 
			this.txtContratante.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtContratante.Location = new System.Drawing.Point(14, 23);
			this.txtContratante.Name = "txtContratante";
			this.txtContratante.Size = new System.Drawing.Size(169, 26);
			this.txtContratante.TabIndex = 29;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(10, 179);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(141, 19);
			this.label5.TabIndex = 39;
			this.label5.Text = "Forma de pagamento:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(10, 132);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(134, 19);
			this.label4.TabIndex = 37;
			this.label4.Text = "Previsão pagamento:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(10, 93);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(91, 19);
			this.label3.TabIndex = 35;
			this.label3.Text = "Cache artista:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(10, 46);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(103, 19);
			this.label1.TabIndex = 34;
			this.label1.Text = "Total a receber:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(10, 6);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(83, 19);
			this.label2.TabIndex = 31;
			this.label2.Text = "Contratante:";
			// 
			// FrmCadFinanceiro
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.ClientSize = new System.Drawing.Size(473, 454);
			this.Controls.Add(this.panel1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FrmCadFinanceiro";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Pagamento espetáculo";
			this.Load += new System.EventHandler(this.FrmCadFinanceiro_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.pnlBuscar.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.ResumeLayout(false);

        }

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.Button btnSalvar;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.TextBox txtBuscarEsp;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Panel pnlBuscar;
		private System.Windows.Forms.Button btnTudo;
		private System.Windows.Forms.ListBox lstPesquisa;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.RadioButton rbtNORealizado;
		private System.Windows.Forms.RadioButton rbtRealizado;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.RadioButton rbtAtraso;
		private System.Windows.Forms.RadioButton rbtPago;
		private System.Windows.Forms.ListBox lstPresente;
		private System.Windows.Forms.ListBox lstConvocado;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtFormaPag;
		private System.Windows.Forms.MaskedTextBox txtPrevisaoPaga;
		private System.Windows.Forms.MaskedTextBox txtCacheArtista;
		private System.Windows.Forms.MaskedTextBox txtTotalAReceber;
		private System.Windows.Forms.TextBox txtContratante;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
	}
}