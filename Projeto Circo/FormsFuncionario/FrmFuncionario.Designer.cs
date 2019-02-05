namespace Projeto_Circo.FormsFuncionario
{
    partial class FrmFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFuncionario));
            this.pnlBuscar = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstPesquisa = new System.Windows.Forms.ListBox();
            this.btnTudo = new System.Windows.Forms.Button();
            this.btnCad = new System.Windows.Forms.Button();
            this.pnlBuscar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBuscar
            // 
            this.pnlBuscar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlBuscar.BackgroundImage")));
            this.pnlBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlBuscar.Controls.Add(this.textBox1);
            this.pnlBuscar.Controls.Add(this.label1);
            this.pnlBuscar.Controls.Add(this.lstPesquisa);
            this.pnlBuscar.Location = new System.Drawing.Point(23, 12);
            this.pnlBuscar.Name = "pnlBuscar";
            this.pnlBuscar.Size = new System.Drawing.Size(318, 241);
            this.pnlBuscar.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(135, 67);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(112, 20);
            this.textBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 19);
            this.label1.TabIndex = 32;
            this.label1.Text = "Buscar:";
            // 
            // lstPesquisa
            // 
            this.lstPesquisa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lstPesquisa.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstPesquisa.FormattingEnabled = true;
            this.lstPesquisa.ItemHeight = 17;
            this.lstPesquisa.Items.AddRange(new object[] {
            "Abre alterar deleta temp"});
            this.lstPesquisa.Location = new System.Drawing.Point(70, 93);
            this.lstPesquisa.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.lstPesquisa.Name = "lstPesquisa";
            this.lstPesquisa.ScrollAlwaysVisible = true;
            this.lstPesquisa.Size = new System.Drawing.Size(177, 72);
            this.lstPesquisa.TabIndex = 4;
            this.lstPesquisa.Click += new System.EventHandler(this.lstPesquisa_Click);
            // 
            // btnTudo
            // 
            this.btnTudo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTudo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTudo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTudo.Image = ((System.Drawing.Image)(resources.GetObject("btnTudo.Image")));
            this.btnTudo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTudo.Location = new System.Drawing.Point(47, 259);
            this.btnTudo.Name = "btnTudo";
            this.btnTudo.Size = new System.Drawing.Size(118, 95);
            this.btnTudo.TabIndex = 2;
            this.btnTudo.Text = "Exibir Todos";
            this.btnTudo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTudo.UseVisualStyleBackColor = false;
            // 
            // btnCad
            // 
            this.btnCad.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCad.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCad.Image = ((System.Drawing.Image)(resources.GetObject("btnCad.Image")));
            this.btnCad.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCad.Location = new System.Drawing.Point(200, 259);
            this.btnCad.Name = "btnCad";
            this.btnCad.Size = new System.Drawing.Size(118, 93);
            this.btnCad.TabIndex = 1;
            this.btnCad.Text = "Cadastrar";
            this.btnCad.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCad.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCad.UseVisualStyleBackColor = false;
            this.btnCad.Click += new System.EventHandler(this.btnCad_Click);
            // 
            // FrmFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(402, 375);
            this.Controls.Add(this.pnlBuscar);
            this.Controls.Add(this.btnTudo);
            this.Controls.Add(this.btnCad);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmFuncionario";
            this.Text = "Funcionários";
            this.pnlBuscar.ResumeLayout(false);
            this.pnlBuscar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBuscar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstPesquisa;
        private System.Windows.Forms.Button btnTudo;
        private System.Windows.Forms.Button btnCad;
    }
}