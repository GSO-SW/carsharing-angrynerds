using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carsharing
{
	public static class FormController
	{
		public static void showAddVehicleForm()
		{
			AddVehicleForm addVehicleForm = new AddVehicleForm();
			addVehicleForm.ShowDialog();
		}
	}
}
