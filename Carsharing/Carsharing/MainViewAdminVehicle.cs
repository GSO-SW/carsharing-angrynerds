using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carsharing
{
	public partial class MainViewAdminVehicle : UserControl
	{
		public MainViewAdminVehicle()
		{
			InitializeComponent();
		}

		private void AdminVehicles_Load(object sender, EventArgs e)
		{
			foreach (Vehicle vehicle in DBController.GetAllVehiclesFromDB())
			{
				dataGridView1.Rows.Add(vehicle.NumberPlate, vehicle.Brand, vehicle.Model, vehicle.Available);
			}
		}
	}
}
