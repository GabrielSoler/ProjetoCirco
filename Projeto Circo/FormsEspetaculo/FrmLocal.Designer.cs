namespace Projeto_Circo.FormsEspetaculo
{
	partial class FrmLocal
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLocal));
			this.btnSair = new System.Windows.Forms.Button();
			this.btnInserir = new System.Windows.Forms.Button();
			this.label24 = new System.Windows.Forms.Label();
			this.txtEspetaculo = new System.Windows.Forms.MaskedTextBox();
			this.SuspendLayout();
			// 
			// btnSair
			// 
			this.btnSair.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSair.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSair.Location = new System.Drawing.Point(128, 72);
			this.btnSair.Name = "btnSair";
			this.btnSair.Size = new System.Drawing.Size(68, 33);
			this.btnSair.TabIndex = 101;
			this.btnSair.Text = "Sair";
			this.btnSair.UseVisualStyleBackColor = false;
			this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
			// 
			// btnInserir
			// 
			this.btnInserir.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnInserir.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnInserir.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnInserir.Location = new System.Drawing.Point(15, 72);
			this.btnInserir.Name = "btnInserir";
			this.btnInserir.Size = new System.Drawing.Size(70, 33);
			this.btnInserir.TabIndex = 100;
			this.btnInserir.Text = "Inserir";
			this.btnInserir.UseVisualStyleBackColor = false;
			this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
			// 
			// label24
			// 
			this.label24.AutoSize = true;
			this.label24.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label24.Location = new System.Drawing.Point(12, 9);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(171, 19);
			this.label24.TabIndex = 102;
			this.label24.Text = "Adicionar local espetáculo:";
			// 
			// txtEspetaculo
			// 
			this.txtEspetaculo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtEspetaculo.Location = new System.Drawing.Point(15, 31);
			this.txtEspetaculo.Name = "txtEspetaculo";
			this.txtEspetaculo.Size = new System.Drawing.Size(181, 26);
			this.txtEspetaculo.TabIndex = 97;
			// 
			// FrmLocal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.ClientSize = new System.Drawing.Size(213, 117);
			this.Controls.Add(this.btnSair);
			this.Controls.Add(this.btnInserir);
			this.Controls.Add(this.label24);
			this.Controls.Add(this.txtEspetaculo);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FrmLocal";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Adicionar local ";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnSair;
		private System.Windows.Forms.Button btnInserir;
		private System.Windows.Forms.Label label24;
		private System.Windows.Forms.MaskedTextBox txtEspetaculo;
	}
}