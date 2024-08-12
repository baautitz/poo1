using System;
using System.Windows.Forms;

namespace Atividade_02 {
	public partial class FrmPrincipal : Form {
		public FrmPrincipal() {
			InitializeComponent();
		}

		private void btnSemTratamento_Click(object sender, EventArgs e) {
			int[] numeros = { 1, 2, 3 };

			MessageBox.Show(Convert.ToString(numeros[10]));

			MessageBox.Show("Segunda mensagem ");
		}

		private void btnComTratamento_Click(object sender, EventArgs e) {
			try {
				int[] numeros = { 1, 2, 3 };

				MessageBox.Show(Convert.ToString(numeros[10]));

			} catch (Exception exception) {
				MessageBox.Show($"Resultasdo: {exception.Message}");
			}

			MessageBox.Show("Segunda mensagem ");
		}

		private void btnComTratamentoSeguro_Click(object sender, EventArgs e) {
			try {
				int[] numeros = { 1, 2, 3 };

				MessageBox.Show(Convert.ToString(numeros[10]));

			} catch (Exception exception) {
				MessageBox.Show($"Resultasdo: {exception.Message}");
			} finally {
				MessageBox.Show("Segunda mensagem ");
			}
		}
	}
}
