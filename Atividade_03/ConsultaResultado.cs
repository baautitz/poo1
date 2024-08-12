using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Atividade_03 {
	public partial class ConsultaResultado : Form {

		private string _user;
		private string _password;

		public ConsultaResultado(string user, string password) {
			_user = user;
			_password = password;
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e) {
			string dadosConexao = $"datasource=praticaeinovacao.dev.br;username={_user};password={_password};database=praticae_poo";

			using (MySqlConnection conexao = new MySqlConnection(dadosConexao)) {
				conexao.Open();

				MySqlCommand cmd = conexao.CreateCommand();
				cmd.Connection = conexao;
				cmd.CommandText = "SELECT empresa_codigo, nomeempresa, cnpjempresa, logradouro, cep, numero, complemento FROM EMPRESA";

				MySqlDataReader reader = cmd.ExecuteReader();

				while (reader.Read()) {
					textBox1.AppendText(
						$"{reader.GetInt32(0)} " +
						$"{reader.GetString(1)} " +
						$"{reader.GetString(2)} " +
						$"{reader.GetString(3)} " +
						$"{reader.GetString(4)} " +
						$"{reader.GetString(5)} " +
						$"{reader.GetString(6)} " +
						$"{Environment.NewLine}"
					);
				}
				textBox1.AppendText($"{Environment.NewLine}");

				Console.WriteLine("Excutando consulta...");
			}

		}
	}
}
