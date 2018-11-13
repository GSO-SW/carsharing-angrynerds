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

			//Show Login View
			//Application.Run(new UserStartView(UserStartView.StartState.Login));

			FormController.CurrentCustomer = DBController.GetCustomerByEmailFromDB("admin@system.de");

			//If someone is loggin in, main shows
			if (FormController.CurrentCustomer != null)
				Application.Run(new MainView());
		}
	}
}
