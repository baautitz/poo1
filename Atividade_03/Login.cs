using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Atividade_03 {
	public partial class Login : Form {

		public bool UserLogged { get; set; } = false;
		public string Username { get; set; }
		public string Password { get; set; }


		public Login() {
			InitializeComponent();
		}

		private void btn_Login_Click(object sender, EventArgs e) {
			Username = txt_User.Text;
			Password = txt_Password.Text;

			string dadosConexao = $"datasource=praticaeinovacao.dev.br;username={Username};password={Password};database=praticae_poo";
			try {
				using (MySqlConnection conexao = new MySqlConnection(dadosConexao)) {
					conexao.Open();

					MySqlCommand cmd = conexao.CreateCommand();
					cmd.Connection = conexao;
					cmd.CommandText = "SELECT 1+1";

					MySqlDataReader reader = cmd.ExecuteReader();
				}

				UserLogged = true;

				Close();
			} catch (Exception) {
				MessageBox.Show("Usuário ou senha inválidos!");
			}
		}
	}
}
