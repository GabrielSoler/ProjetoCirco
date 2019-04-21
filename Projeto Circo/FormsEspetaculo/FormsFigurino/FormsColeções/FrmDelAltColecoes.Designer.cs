namespace Projeto_Circo.FormsFigurino
{
    partial class FrmDelAltColecoes
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDelAltColecoes));
			this.btnCancelar = new System.Windows.Forms.Button();
			this.btnEditar = new System.Windows.Forms.Button();
			this.rbtInativo = new System.Windows.Forms.RadioButton();
			this.rbtAtivo = new System.Windows.Forms.RadioButton();
			this.txtTeciAvi = new System.Windows.Forms.TextBox();
			this.txtNotas = new System.Windows.Forms.TextBox();
			this.txtQtdPecUnic = new System.Windows.Forms.MaskedTextBox();
			this.txtDataCria = new System.Windows.Forms.MaskedTextBox();
			this.txtNomeCole = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label24 = new System.Windows.Forms.Label();
			this.txtCostuResp = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// btnCancelar
			// 
			this.btnCancelar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnCancelar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCancelar.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
			this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnCancelar.Location = new System.Drawing.Point(135, 380);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(88, 58);
			this.btnCancelar.TabIndex = 10;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnCancelar.UseVisualStyleBackColor = false;
			this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
			// 
			// btnEditar
			// 
			this.btnEditar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnEditar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
			this.btnEditar.Location = new System.Drawing.Point(32, 380);
			this.btnEditar.Name = "btnEditar";
			this.btnEditar.Size = new System.Drawing.Size(88, 58);
			this.btnEditar.TabIndex = 9;
			this.btnEditar.Text = "Editar";
			this.btnEditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnEditar.UseVisualStyleBackColor = false;
			this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
			// 
			// rbtInativo
			// 
			this.rbtInativo.AutoSize = true;
			this.rbtInativo.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbtInativo.Location = new System.Drawing.Point(113, 208);
			this.rbtInativo.Name = "rbtInativo";
			this.rbtInativo.Size = new System.Drawing.Size(66, 21);
			this.rbtInativo.TabIndex = 6;
			this.rbtInativo.TabStop = true;
			this.rbtInativo.Text = "Inativo";
			this.rbtInativo.UseVisualStyleBackColor = true;
			// 
			// rbtAtivo
			// 
			this.rbtAtivo.AutoSize = true;
			this.rbtAtivo.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbtAtivo.Location = new System.Drawing.Point(22, 208);
			this.rbtAtivo.Name = "rbtAtivo";
			this.rbtAtivo.Size = new System.Drawing.Size(58, 21);
			this.rbtAtivo.TabIndex = 5;
			this.rbtAtivo.TabStop = true;
			this.rbtAtivo.Text = "Ativo";
			this.rbtAtivo.UseVisualStyleBackColor = true;
			// 
			// txtTeciAvi
			// 
			this.txtTeciAvi.Location = new System.Drawing.Point(21, 163);
			this.txtTeciAvi.Name = "txtTeciAvi";
			this.txtTeciAvi.Size = new System.Drawing.Size(190, 20);
			this.txtTeciAvi.TabIndex = 4;
			// 
			// txtNotas
			// 
			this.txtNotas.Location = new System.Drawing.Point(21, 295);
			this.txtNotas.Multiline = true;
			this.txtNotas.Name = "txtNotas";
			this.txtNotas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtNotas.Size = new System.Drawing.Size(218, 60);
			this.txtNotas.TabIndex = 8;
			// 
			// txtQtdPecUnic
			// 
			this.txtQtdPecUnic.Location = new System.Drawing.Point(21, 250);
			this.txtQtdPecUnic.Name = "txtQtdPecUnic";
			this.txtQtdPecUnic.Size = new System.Drawing.Size(190, 20);
			this.txtQtdPecUnic.TabIndex = 7;
			// 
			// txtDataCria
			// 
			this.txtDataCria.Location = new System.Drawing.Point(21, 76);
			this.txtDataCria.Mask = "00/00/0000";
			this.txtDataCria.Name = "txtDataCria";
			this.txtDataCria.Size = new System.Drawing.Size(126, 20);
			this.txtDataCria.TabIndex = 2;
			// 
			// txtNomeCole
			// 
			this.txtNomeCole.Location = new System.Drawing.Point(21, 31);
			this.txtNomeCole.Name = "txtNomeCole";
			this.txtNomeCole.Size = new System.Drawing.Size(190, 20);
			this.txtNomeCole.TabIndex = 1;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(18, 273);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(58, 21);
			this.label6.TabIndex = 90;
			this.label6.Text = "Notas:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(17, 186);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(78, 21);
			this.label5.TabIndex = 89;
			this.label5.Text = "Situação:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(17, 141);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(175, 21);
			this.label4.TabIndex = 87;
			this.label4.Text = "Tecidos e aviamentos:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(17, 228);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(222, 21);
			this.label3.TabIndex = 88;
			this.label3.Text = "Quantidade de peças unicas:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(17, 95);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(206, 21);
			this.label2.TabIndex = 86;
			this.label2.Text = "Costureiro(a) responsável:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(17, 54);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(130, 21);
			this.label1.TabIndex = 85;
			this.label1.Text = "Data de criação:";
			// 
			// label24
			// 
			this.label24.AutoSize = true;
			this.label24.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label24.Location = new System.Drawing.Point(17, 9);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(145, 21);
			this.label24.TabIndex = 84;
			this.label24.Text = "Nome da coleção:";
			// 
			// txtCostuResp
			// 
			this.txtCostuResp.Location = new System.Drawing.Point(21, 118);
			this.txtCostuResp.Name = "txtCostuResp";
			this.txtCostuResp.Size = new System.Drawing.Size(190, 20);
			this.txtCostuResp.TabIndex = 3;
			// 
			// FrmDelAltColecoes
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.ClientSize = new System.Drawing.Size(287, 450);
			this.Controls.Add(this.txtCostuResp);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnEditar);
			this.Controls.Add(this.rbtInativo);
			this.Controls.Add(this.rbtAtivo);
			this.Controls.Add(this.txtTeciAvi);
			this.Controls.Add(this.txtNotas);
			this.Controls.Add(this.txtQtdPecUnic);
			this.Controls.Add(this.txtDataCria);
			this.Controls.Add(this.txtNomeCole);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label24);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FrmDelAltColecoes";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Coleção - Consulta";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.RadioButton rbtInativo;
        private System.Windows.Forms.RadioButton rbtAtivo;
        private System.Windows.Forms.TextBox txtTeciAvi;
        private System.Windows.Forms.TextBox txtNotas;
        private System.Windows.Forms.MaskedTextBox txtQtdPecUnic;
        private System.Windows.Forms.MaskedTextBox txtDataCria;
        private System.Windows.Forms.TextBox txtNomeCole;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txtCostuResp;
    }
}