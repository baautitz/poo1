namespace Atividade_02 {
	partial class FrmPrincipal {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.btnSemTratamento = new System.Windows.Forms.Button();
			this.btnComTratamento = new System.Windows.Forms.Button();
			this.btnComTratamentoSeguro = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnSemTratamento
			// 
			this.btnSemTratamento.Location = new System.Drawing.Point(12, 12);
			this.btnSemTratamento.Name = "btnSemTratamento";
			this.btnSemTratamento.Size = new System.Drawing.Size(140, 25);
			this.btnSemTratamento.TabIndex = 0;
			this.btnSemTratamento.Text = "Sem tratamento";
			this.btnSemTratamento.UseVisualStyleBackColor = true;
			this.btnSemTratamento.Click += new System.EventHandler(this.btnSemTratamento_Click);
			// 
			// btnComTratamento
			// 
			this.btnComTratamento.Location = new System.Drawing.Point(12, 43);
			this.btnComTratamento.Name = "btnComTratamento";
			this.btnComTratamento.Size = new System.Drawing.Size(140, 25);
			this.btnComTratamento.TabIndex = 1;
			this.btnComTratamento.Text = "Com tratamento";
			this.btnComTratamento.UseVisualStyleBackColor = true;
			this.btnComTratamento.Click += new System.EventHandler(this.btnComTratamento_Click);
			// 
			// btnComTratamentoSeguro
			// 
			this.btnComTratamentoSeguro.Location = new System.Drawing.Point(12, 74);
			this.btnComTratamentoSeguro.Name = "btnComTratamentoSeguro";
			this.btnComTratamentoSeguro.Size = new System.Drawing.Size(140, 25);
			this.btnComTratamentoSeguro.TabIndex = 2;
			this.btnComTratamentoSeguro.Text = "Com tratamento Seguro";
			this.btnComTratamentoSeguro.UseVisualStyleBackColor = true;
			this.btnComTratamentoSeguro.Click += new System.EventHandler(this.btnComTratamentoSeguro_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(283, 161);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(79, 29);
			this.label1.TabIndex = 3;
			this.label1.Text = "label1";
			// 
			// FrmPrincipal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnComTratamentoSeguro);
			this.Controls.Add(this.btnComTratamento);
			this.Controls.Add(this.btnSemTratamento);
			this.Name = "FrmPrincipal";
			this.Text = "Tratamento de exceções";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnSemTratamento;
		private System.Windows.Forms.Button btnComTratamento;
		private System.Windows.Forms.Button btnComTratamentoSeguro;
		private System.Windows.Forms.Label label1;
	}
}

