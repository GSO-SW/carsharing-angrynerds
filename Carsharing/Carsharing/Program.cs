using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carsharing
{
	static class Program
	{
		/// <summary>
		/// Der Haupteinstiegspunkt für die Anwendung.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			if (DBController.ConnectionAvailable())
			{
				//Show Login View
//				DBController.GetCustomerByEmailFromDB("admin@system.de", out Customer c);
//				FormController.CurrentCustomer = c;

				Application.Run(new LoginView(LoginView.StartState.Login));
				//If someone is loggin in, main shows
				if (FormController.CurrentCustomer != null)
					Application.Run(new MainView());
			}
			else
			{
				MessageBox.Show("Es konnte keine Verbindung zur Datenbank hergestellt werden.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
