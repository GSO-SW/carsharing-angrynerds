using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carsharing
{
	public partial class Main : Form
	{
		public Main()
		{
			InitializeComponent();
			DBController.ConnectToDb();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			FormController.showAddVehicleForm();
			//Vehicle v = new Vehicle("BM BM 1234", 1000.0, DateTime.Today, 10.0, String.Empty, true, "Ford", "Fiesta", 150, new DateTime(2000, 1, 1), "Schaltung", 20.0, 10.0, 10.0, 10.0);
			//DBController.AddVehicle(v);
		}
	}
}