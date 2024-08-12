using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade_03 {
	internal static class Program {
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() {
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			Login login = new Login();

			Application.Run(login);

			if (login.UserLogged) {
				Application.Run(new ConsultaResultado(login.Username, login.Password));
			}
		}
	}
}
