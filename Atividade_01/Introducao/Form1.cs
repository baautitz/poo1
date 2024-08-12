using System;
using System.Windows.Forms;

namespace Introducao {
	public partial class Form1 : Form {
		public Form1() {
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e) {
			Text = @"eu sou xxxxx?";
			Cursor = Cursors.No;
			
			label1.Text = @"olázinho, como está?";
		}


		private void ChangeFormTextButtonClick(object sender, EventArgs e) {
			Text = ((Button)sender).Text;
		}

		private void btn_estoubem_Click(object sender, EventArgs e) {
			string message = @"ah que bom. quer fechar?";
			string title = @"confirmation";
			
			MessageBoxButtons buttons = MessageBoxButtons.YesNo;

			DialogResult result = MessageBox.Show(this, message, title, buttons);
			

			if (result == DialogResult.Yes) {
				MessageBox.Show(@"ta né ;-;");
				Close();
			}

			if (result == DialogResult.No) {
				MessageBox.Show(this, @"sem escolhas por aqui");
				Close();
			}
		}
	}
}
