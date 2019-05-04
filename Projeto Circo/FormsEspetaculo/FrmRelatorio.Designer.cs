namespace Projeto_Circo
{
    partial class FrmRelatorio
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRelatorio));
			this.panel3 = new System.Windows.Forms.Panel();
			this.btnData = new System.Windows.Forms.Button();
			this.monthCalendar = new System.Windows.Forms.MonthCalendar();
			this.exibirCalender = new System.Windows.Forms.Button();
			this.txtBuscaDt = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.btnBuscar = new System.Windows.Forms.Button();
			this.btnTudo = new System.Windows.Forms.Button();
			this.txtBuscar = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.lstBuscar = new System.Windows.Forms.ListBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.txtNMEsp = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.lstLocal = new System.Windows.Forms.ListBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtDtEsp = new System.Windows.Forms.MaskedTextBox();
			this.lstArt = new System.Windows.Forms.ListBox();
			this.lstCol = new System.Windows.Forms.ListBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.lstPec = new System.Windows.Forms.ListBox();
			this.label2 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel3.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel3.Controls.Add(this.btnData);
			this.panel3.Controls.Add(this.monthCalendar);
			this.panel3.Controls.Add(this.exibirCalender);
			this.panel3.Controls.Add(this.txtBuscaDt);
			this.panel3.Controls.Add(this.label8);
			this.panel3.Controls.Add(this.btnBuscar);
			this.panel3.Controls.Add(this.btnTudo);
			this.panel3.Controls.Add(this.txtBuscar);
			this.panel3.Controls.Add(this.label7);
			this.panel3.Controls.Add(this.lstBuscar);
			this.panel3.Location = new System.Drawing.Point(12, 12);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(249, 397);
			this.panel3.TabIndex = 1;
			// 
			// btnData
			// 
			this.btnData.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnData.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnData.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnData.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnData.Location = new System.Drawing.Point(176, 179);
			this.btnData.Name = "btnData";
			this.btnData.Size = new System.Drawing.Size(55, 24);
			this.btnData.TabIndex = 27;
			this.btnData.Text = "Buscar";
			this.btnData.UseVisualStyleBackColor = false;
			this.btnData.Click += new System.EventHandler(this.btnData_Click);
			// 
			// monthCalendar
			// 
			this.monthCalendar.BackColor = System.Drawing.SystemColors.HotTrack;
			this.monthCalendar.Location = new System.Drawing.Point(9, 230);
			this.monthCalendar.Name = "monthCalendar";
			this.monthCalendar.TabIndex = 26;
			this.monthCalendar.Visible = false;
			this.monthCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar_DateChanged);
			// 
			// exibirCalender
			// 
			this.exibirCalender.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.exibirCalender.Cursor = System.Windows.Forms.Cursors.Hand;
			this.exibirCalender.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.exibirCalender.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.exibirCalender.Location = new System.Drawing.Point(14, 204);
			this.exibirCalender.Name = "exibirCalender";
			this.exibirCalender.Size = new System.Drawing.Size(111, 24);
			this.exibirCalender.TabIndex = 24;
			this.exibirCalender.Text = "Exibir Calendário";
			this.exibirCalender.UseVisualStyleBackColor = false;
			this.exibirCalender.Click += new System.EventHandler(this.exibirCalender_Click);
			// 
			// txtBuscaDt
			// 
			this.txtBuscaDt.Location = new System.Drawing.Point(62, 181);
			this.txtBuscaDt.Name = "txtBuscaDt";
			this.txtBuscaDt.Size = new System.Drawing.Size(108, 20);
			this.txtBuscaDt.TabIndex = 22;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label8.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(10, 179);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(55, 22);
			this.label8.TabIndex = 23;
			this.label8.Text = "Data:";
			// 
			// btnBuscar
			// 
			this.btnBuscar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnBuscar.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnBuscar.Location = new System.Drawing.Point(189, 9);
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.Size = new System.Drawing.Size(55, 24);
			this.btnBuscar.TabIndex = 21;
			this.btnBuscar.Text = "Buscar";
			this.btnBuscar.UseVisualStyleBackColor = false;
			this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
			// 
			// btnTudo
			// 
			this.btnTudo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnTudo.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnTudo.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnTudo.Image = global::Projeto_Circo.Properties.Resources.mostrarBitmap;
			this.btnTudo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnTudo.Location = new System.Drawing.Point(50, 143);
			this.btnTudo.Name = "btnTudo";
			this.btnTudo.Size = new System.Drawing.Size(149, 33);
			this.btnTudo.TabIndex = 20;
			this.btnTudo.Text = "Exibir Todos";
			this.btnTudo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnTudo.UseVisualStyleBackColor = false;
			this.btnTudo.Click += new System.EventHandler(this.btnTudo_Click);
			// 
			// txtBuscar
			// 
			this.txtBuscar.Location = new System.Drawing.Point(80, 13);
			this.txtBuscar.Name = "txtBuscar";
			this.txtBuscar.Size = new System.Drawing.Size(108, 20);
			this.txtBuscar.TabIndex = 1;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(10, 11);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(73, 22);
			this.label7.TabIndex = 2;
			this.label7.Text = "Buscar:";
			// 
			// lstBuscar
			// 
			this.lstBuscar.ColumnWidth = 1;
			this.lstBuscar.FormattingEnabled = true;
			this.lstBuscar.Location = new System.Drawing.Point(14, 39);
			this.lstBuscar.Name = "lstBuscar";
			this.lstBuscar.ScrollAlwaysVisible = true;
			this.lstBuscar.Size = new System.Drawing.Size(222, 95);
			this.lstBuscar.TabIndex = 8;
			this.lstBuscar.Click += new System.EventHandler(this.lstBuscar_Click);
			this.lstBuscar.SelectedIndexChanged += new System.EventHandler(this.lstBuscar_SelectedIndexChanged);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel2.Controls.Add(this.txtNMEsp);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Controls.Add(this.label4);
			this.panel2.Controls.Add(this.lstLocal);
			this.panel2.Controls.Add(this.label6);
			this.panel2.Controls.Add(this.txtDtEsp);
			this.panel2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.panel2.Location = new System.Drawing.Point(267, 12);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(193, 236);
			this.panel2.TabIndex = 5;
			// 
			// txtNMEsp
			// 
			this.txtNMEsp.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNMEsp.Location = new System.Drawing.Point(13, 38);
			this.txtNMEsp.Name = "txtNMEsp";
			this.txtNMEsp.Size = new System.Drawing.Size(163, 26);
			this.txtNMEsp.TabIndex = 18;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.White;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label1.Location = new System.Drawing.Point(12, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(158, 22);
			this.label1.TabIndex = 19;
			this.label1.Text = "Nome Espetáculo:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(12, 65);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(55, 22);
			this.label4.TabIndex = 2;
			this.label4.Text = "Data:";
			// 
			// lstLocal
			// 
			this.lstLocal.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lstLocal.FormattingEnabled = true;
			this.lstLocal.ItemHeight = 19;
			this.lstLocal.Location = new System.Drawing.Point(16, 140);
			this.lstLocal.Name = "lstLocal";
			this.lstLocal.ScrollAlwaysVisible = true;
			this.lstLocal.Size = new System.Drawing.Size(160, 80);
			this.lstLocal.TabIndex = 7;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(12, 115);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(61, 22);
			this.label6.TabIndex = 17;
			this.label6.Text = "Local:";
			// 
			// txtDtEsp
			// 
			this.txtDtEsp.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDtEsp.Location = new System.Drawing.Point(16, 90);
			this.txtDtEsp.Mask = "00/00/0000";
			this.txtDtEsp.Name = "txtDtEsp";
			this.txtDtEsp.Size = new System.Drawing.Size(160, 26);
			this.txtDtEsp.TabIndex = 6;
			// 
			// lstArt
			// 
			this.lstArt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lstArt.FormattingEnabled = true;
			this.lstArt.ItemHeight = 19;
			this.lstArt.Location = new System.Drawing.Point(13, 38);
			this.lstArt.Name = "lstArt";
			this.lstArt.ScrollAlwaysVisible = true;
			this.lstArt.Size = new System.Drawing.Size(151, 80);
			this.lstArt.TabIndex = 3;
			// 
			// lstCol
			// 
			this.lstCol.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lstCol.FormattingEnabled = true;
			this.lstCol.ItemHeight = 19;
			this.lstCol.Location = new System.Drawing.Point(13, 161);
			this.lstCol.Name = "lstCol";
			this.lstCol.ScrollAlwaysVisible = true;
			this.lstCol.Size = new System.Drawing.Size(151, 80);
			this.lstCol.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(9, 136);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(82, 22);
			this.label3.TabIndex = 15;
			this.label3.Text = "Coleção:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(9, 259);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(141, 22);
			this.label5.TabIndex = 16;
			this.label5.Text = "Codigo de peça:";
			// 
			// lstPec
			// 
			this.lstPec.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lstPec.FormattingEnabled = true;
			this.lstPec.ItemHeight = 19;
			this.lstPec.Location = new System.Drawing.Point(13, 284);
			this.lstPec.Name = "lstPec";
			this.lstPec.ScrollAlwaysVisible = true;
			this.lstPec.Size = new System.Drawing.Size(151, 80);
			this.lstPec.TabIndex = 5;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(9, 13);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(79, 22);
			this.label2.TabIndex = 14;
			this.label2.Text = "Artistas:";
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
			this.panel1.Controls.Add(this.lstArt);
			this.panel1.Location = new System.Drawing.Point(482, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(182, 391);
			this.panel1.TabIndex = 2;
			// 
			// FrmRelatorio
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.ClientSize = new System.Drawing.Size(693, 421);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel1);
			this.DoubleBuffered = true;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimizeBox = false;
			this.Name = "FrmRelatorio";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Relatório";
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox lstBuscar;
        private System.Windows.Forms.Button btnTudo;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.TextBox txtNMEsp;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ListBox lstLocal;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.MaskedTextBox txtDtEsp;
		private System.Windows.Forms.ListBox lstArt;
		private System.Windows.Forms.ListBox lstCol;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ListBox lstPec;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnBuscar;
		private System.Windows.Forms.Button exibirCalender;
		private System.Windows.Forms.TextBox txtBuscaDt;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.MonthCalendar monthCalendar;
		private System.Windows.Forms.Button btnData;
	}
}