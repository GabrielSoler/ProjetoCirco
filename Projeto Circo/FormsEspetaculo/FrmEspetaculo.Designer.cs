namespace Projeto_Circo
{
    partial class FrmEspetaculo
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEspetaculo));
			this.panel1 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.lstPec = new System.Windows.Forms.ListBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.lstCol = new System.Windows.Forms.ListBox();
			this.lstArtistas = new System.Windows.Forms.ListBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.btnExcluirLocal = new System.Windows.Forms.Button();
			this.btnInserirLocal = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.lstLocal = new System.Windows.Forms.ListBox();
			this.panel3 = new System.Windows.Forms.Panel();
			this.txtNMEspetaculo = new System.Windows.Forms.TextBox();
			this.txtDTHR = new System.Windows.Forms.MaskedTextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.lblMenu = new System.Windows.Forms.Label();
			this.btnSalvarEspetaculo = new System.Windows.Forms.Button();
			this.btnAtualizar = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.lstPec);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.lstCol);
			this.panel1.Controls.Add(this.lstArtistas);
			this.panel1.Location = new System.Drawing.Point(13, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(182, 394);
			this.panel1.TabIndex = 22;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(10, 5);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(79, 22);
			this.label2.TabIndex = 14;
			this.label2.Text = "Artistas:";
			// 
			// lstPec
			// 
			this.lstPec.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lstPec.FormattingEnabled = true;
			this.lstPec.ItemHeight = 19;
			this.lstPec.Location = new System.Drawing.Point(14, 276);
			this.lstPec.Name = "lstPec";
			this.lstPec.ScrollAlwaysVisible = true;
			this.lstPec.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
			this.lstPec.Size = new System.Drawing.Size(151, 80);
			this.lstPec.TabIndex = 10;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(10, 251);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(141, 22);
			this.label5.TabIndex = 16;
			this.label5.Text = "Codigo de peça:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(10, 128);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(82, 22);
			this.label3.TabIndex = 15;
			this.label3.Text = "Coleção:";
			// 
			// lstCol
			// 
			this.lstCol.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lstCol.FormattingEnabled = true;
			this.lstCol.ItemHeight = 19;
			this.lstCol.Location = new System.Drawing.Point(14, 153);
			this.lstCol.Name = "lstCol";
			this.lstCol.ScrollAlwaysVisible = true;
			this.lstCol.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
			this.lstCol.Size = new System.Drawing.Size(151, 80);
			this.lstCol.TabIndex = 9;
			this.lstCol.SelectedIndexChanged += new System.EventHandler(this.lstCol_SelectedIndexChanged);
			// 
			// lstArtistas
			// 
			this.lstArtistas.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lstArtistas.FormattingEnabled = true;
			this.lstArtistas.ItemHeight = 19;
			this.lstArtistas.Location = new System.Drawing.Point(14, 30);
			this.lstArtistas.Name = "lstArtistas";
			this.lstArtistas.ScrollAlwaysVisible = true;
			this.lstArtistas.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
			this.lstArtistas.Size = new System.Drawing.Size(151, 80);
			this.lstArtistas.TabIndex = 8;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel2.Controls.Add(this.btnExcluirLocal);
			this.panel2.Controls.Add(this.btnInserirLocal);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Controls.Add(this.lstLocal);
			this.panel2.Location = new System.Drawing.Point(228, 12);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(297, 111);
			this.panel2.TabIndex = 23;
			// 
			// btnExcluirLocal
			// 
			this.btnExcluirLocal.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnExcluirLocal.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnExcluirLocal.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExcluirLocal.Location = new System.Drawing.Point(7, 65);
			this.btnExcluirLocal.Name = "btnExcluirLocal";
			this.btnExcluirLocal.Size = new System.Drawing.Size(90, 23);
			this.btnExcluirLocal.TabIndex = 16;
			this.btnExcluirLocal.Text = "Excluir Local";
			this.btnExcluirLocal.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnExcluirLocal.UseVisualStyleBackColor = false;
			this.btnExcluirLocal.Click += new System.EventHandler(this.btnExcluirLocal_Click);
			// 
			// btnInserirLocal
			// 
			this.btnInserirLocal.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnInserirLocal.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnInserirLocal.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnInserirLocal.Location = new System.Drawing.Point(7, 36);
			this.btnInserirLocal.Name = "btnInserirLocal";
			this.btnInserirLocal.Size = new System.Drawing.Size(90, 23);
			this.btnInserirLocal.TabIndex = 15;
			this.btnInserirLocal.Text = "Inserir Local";
			this.btnInserirLocal.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnInserirLocal.UseVisualStyleBackColor = false;
			this.btnInserirLocal.Click += new System.EventHandler(this.btnInserirLocal_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(3, 11);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(61, 22);
			this.label1.TabIndex = 14;
			this.label1.Text = "Local:";
			// 
			// lstLocal
			// 
			this.lstLocal.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lstLocal.FormattingEnabled = true;
			this.lstLocal.ItemHeight = 19;
			this.lstLocal.Location = new System.Drawing.Point(103, 5);
			this.lstLocal.Name = "lstLocal";
			this.lstLocal.ScrollAlwaysVisible = true;
			this.lstLocal.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
			this.lstLocal.Size = new System.Drawing.Size(181, 80);
			this.lstLocal.TabIndex = 8;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel3.Controls.Add(this.txtNMEspetaculo);
			this.panel3.Controls.Add(this.txtDTHR);
			this.panel3.Controls.Add(this.label7);
			this.panel3.Controls.Add(this.label6);
			this.panel3.Location = new System.Drawing.Point(235, 162);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(193, 111);
			this.panel3.TabIndex = 24;
			// 
			// txtNMEspetaculo
			// 
			this.txtNMEspetaculo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNMEspetaculo.Location = new System.Drawing.Point(8, 37);
			this.txtNMEspetaculo.Name = "txtNMEspetaculo";
			this.txtNMEspetaculo.Size = new System.Drawing.Size(175, 26);
			this.txtNMEspetaculo.TabIndex = 19;
			// 
			// txtDTHR
			// 
			this.txtDTHR.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDTHR.Location = new System.Drawing.Point(8, 83);
			this.txtDTHR.Mask = "00/00/0000 00:00";
			this.txtDTHR.Name = "txtDTHR";
			this.txtDTHR.Size = new System.Drawing.Size(175, 26);
			this.txtDTHR.TabIndex = 20;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(4, 58);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(102, 22);
			this.label7.TabIndex = 18;
			this.label7.Text = "Data/Hora:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(4, 11);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(179, 22);
			this.label6.TabIndex = 17;
			this.label6.Text = "Nome do espetáculo:";
			// 
			// lblMenu
			// 
			this.lblMenu.AutoSize = true;
			this.lblMenu.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lblMenu.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMenu.Location = new System.Drawing.Point(241, 148);
			this.lblMenu.Name = "lblMenu";
			this.lblMenu.Size = new System.Drawing.Size(72, 26);
			this.lblMenu.TabIndex = 14;
			this.lblMenu.Text = "Menu";
			// 
			// btnSalvarEspetaculo
			// 
			this.btnSalvarEspetaculo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnSalvarEspetaculo.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSalvarEspetaculo.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSalvarEspetaculo.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvarEspetaculo.Image")));
			this.btnSalvarEspetaculo.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnSalvarEspetaculo.Location = new System.Drawing.Point(246, 295);
			this.btnSalvarEspetaculo.Name = "btnSalvarEspetaculo";
			this.btnSalvarEspetaculo.Size = new System.Drawing.Size(173, 89);
			this.btnSalvarEspetaculo.TabIndex = 17;
			this.btnSalvarEspetaculo.Text = " Salvar Espetáculo";
			this.btnSalvarEspetaculo.TextAlign = System.Drawing.ContentAlignment.TopRight;
			this.btnSalvarEspetaculo.UseVisualStyleBackColor = false;
			this.btnSalvarEspetaculo.Click += new System.EventHandler(this.btnSalvarEspetaculo_Click);
			// 
			// btnAtualizar
			// 
			this.btnAtualizar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnAtualizar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAtualizar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAtualizar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnAtualizar.Location = new System.Drawing.Point(446, 127);
			this.btnAtualizar.Name = "btnAtualizar";
			this.btnAtualizar.Size = new System.Drawing.Size(79, 29);
			this.btnAtualizar.TabIndex = 28;
			this.btnAtualizar.Text = "Atualizar";
			this.btnAtualizar.TextAlign = System.Drawing.ContentAlignment.TopRight;
			this.btnAtualizar.UseVisualStyleBackColor = false;
			this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
			// 
			// FrmEspetaculo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.ClientSize = new System.Drawing.Size(552, 419);
			this.Controls.Add(this.btnAtualizar);
			this.Controls.Add(this.btnSalvarEspetaculo);
			this.Controls.Add(this.lblMenu);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panel3);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FrmEspetaculo";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Gerar Espetáculo";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ListBox lstPec;
		private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstCol;
        private System.Windows.Forms.ListBox lstArtistas;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnExcluirLocal;
        private System.Windows.Forms.Button btnInserirLocal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstLocal;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.TextBox txtNMEspetaculo;
        private System.Windows.Forms.MaskedTextBox txtDTHR;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSalvarEspetaculo;
		private System.Windows.Forms.Button btnAtualizar;
	}
}