﻿namespace Introducao {
	partial class Form1 {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.btn_estoubem = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btn_estoubem
			// 
			this.btn_estoubem.AutoSize = true;
			this.btn_estoubem.Font = new System.Drawing.Font("Rage Italic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_estoubem.Location = new System.Drawing.Point(236, 338);
			this.btn_estoubem.Name = "btn_estoubem";
			this.btn_estoubem.Size = new System.Drawing.Size(335, 56);
			this.btn_estoubem.TabIndex = 0;
			this.btn_estoubem.Text = "estou muito que bem";
			this.btn_estoubem.UseVisualStyleBackColor = true;
			this.btn_estoubem.Click += new System.EventHandler(this.btn_estoubem_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Ravie", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(206, 397);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(381, 26);
			this.label1.TabIndex = 1;
			this.label1.Text = "boa tarde, senhor. como vai?";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Lime;
			this.button1.Font = new System.Drawing.Font("Snap ITC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(12, 59);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(170, 76);
			this.button1.TabIndex = 2;
			this.button1.Text = "kaue";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.ChangeFormTextButtonClick);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.Aqua;
			this.button2.Font = new System.Drawing.Font("Snap ITC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.Location = new System.Drawing.Point(188, 59);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(170, 76);
			this.button2.TabIndex = 3;
			this.button2.Text = "dedrey";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.ChangeFormTextButtonClick);
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.Fuchsia;
			this.button3.Font = new System.Drawing.Font("Snap ITC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.Location = new System.Drawing.Point(364, 59);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(170, 76);
			this.button3.TabIndex = 4;
			this.button3.Text = "vinizinho";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.ChangeFormTextButtonClick);
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.Color.HotPink;
			this.button4.Font = new System.Drawing.Font("Snap ITC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button4.Location = new System.Drawing.Point(540, 59);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(170, 76);
			this.button4.TabIndex = 5;
			this.button4.Text = "binca";
			this.button4.UseVisualStyleBackColor = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btn_estoubem);
			this.Cursor = System.Windows.Forms.Cursors.Default;
			this.DoubleBuffered = true;
			this.Name = "Form1";
			this.Text = "garoto de programa";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		private System.Windows.Forms.Button button3;

		private System.Windows.Forms.Button button2;

		private System.Windows.Forms.Button button1;

		private System.Windows.Forms.Label label1;

		private System.Windows.Forms.Button btn_estoubem;

		#endregion

		private System.Windows.Forms.Button button4;
	}
}

