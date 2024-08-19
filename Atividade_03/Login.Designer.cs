namespace Atividade_03 {
	partial class Login {
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
			this.btn_Login = new System.Windows.Forms.Button();
			this.label_TypeData = new System.Windows.Forms.Label();
			this.txt_User = new System.Windows.Forms.TextBox();
			this.txt_Password = new System.Windows.Forms.TextBox();
			this.label_User = new System.Windows.Forms.Label();
			this.label_Password = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btn_Login
			// 
			this.btn_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_Login.Location = new System.Drawing.Point(12, 178);
			this.btn_Login.Name = "btn_Login";
			this.btn_Login.Size = new System.Drawing.Size(310, 40);
			this.btn_Login.TabIndex = 0;
			this.btn_Login.Text = "Login";
			this.btn_Login.UseVisualStyleBackColor = true;
			this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
			// 
			// label_TypeData
			// 
			this.label_TypeData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_TypeData.Location = new System.Drawing.Point(12, 9);
			this.label_TypeData.Name = "label_TypeData";
			this.label_TypeData.Size = new System.Drawing.Size(310, 29);
			this.label_TypeData.TabIndex = 1;
			this.label_TypeData.Text = "Digite os dados para entrar:";
			this.label_TypeData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txt_User
			// 
			this.txt_User.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_User.Location = new System.Drawing.Point(12, 73);
			this.txt_User.MaxLength = 50;
			this.txt_User.MinimumSize = new System.Drawing.Size(310, 40);
			this.txt_User.Name = "txt_User";
			this.txt_User.Size = new System.Drawing.Size(310, 22);
			this.txt_User.TabIndex = 2;
			this.txt_User.WordWrap = false;
			// 
			// txt_Password
			// 
			this.txt_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_Password.Location = new System.Drawing.Point(12, 122);
			this.txt_Password.MaxLength = 50;
			this.txt_Password.MinimumSize = new System.Drawing.Size(310, 40);
			this.txt_Password.Name = "txt_Password";
			this.txt_Password.PasswordChar = '*';
			this.txt_Password.Size = new System.Drawing.Size(310, 22);
			this.txt_Password.TabIndex = 3;
			this.txt_Password.UseSystemPasswordChar = true;
			this.txt_Password.WordWrap = false;
			// 
			// label_User
			// 
			this.label_User.AutoSize = true;
			this.label_User.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_User.Location = new System.Drawing.Point(12, 54);
			this.label_User.Name = "label_User";
			this.label_User.Size = new System.Drawing.Size(57, 16);
			this.label_User.TabIndex = 5;
			this.label_User.Text = "Usuário:";
			// 
			// label_Password
			// 
			this.label_Password.AutoSize = true;
			this.label_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_Password.Location = new System.Drawing.Point(12, 103);
			this.label_Password.Name = "label_Password";
			this.label_Password.Size = new System.Drawing.Size(49, 16);
			this.label_Password.TabIndex = 6;
			this.label_Password.Text = "Senha:";
			// 
			// Login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(334, 231);
			this.Controls.Add(this.label_Password);
			this.Controls.Add(this.label_User);
			this.Controls.Add(this.txt_Password);
			this.Controls.Add(this.txt_User);
			this.Controls.Add(this.label_TypeData);
			this.Controls.Add(this.btn_Login);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(350, 270);
			this.MinimumSize = new System.Drawing.Size(350, 270);
			this.Name = "Login";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Login";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btn_Login;
		private System.Windows.Forms.Label label_TypeData;
		private System.Windows.Forms.TextBox txt_User;
		private System.Windows.Forms.TextBox txt_Password;
		private System.Windows.Forms.Label label_User;
		private System.Windows.Forms.Label label_Password;
	}
}