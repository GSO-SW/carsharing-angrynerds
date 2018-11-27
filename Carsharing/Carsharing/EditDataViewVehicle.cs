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
	public partial class EditDataViewVehicle : UserControl
	{
		public EditDataViewVehicle()
		{
			InitializeComponent();
			buttonAccept.Text = "Fahrzeug hinzufügen";
		}

		private void EditDataViewVehicle_Load(object sender, EventArgs e)
		{
			if (DBController.GetVehicleBrands(out List<string> brands))
			{
				comboBrand.Items.AddRange(brands.ToArray());
			}

			if (DBController.GetFuelTypes(out List<string> fuel))
			{
				comboFuel.Items.AddRange(fuel.ToArray());
			}

			if (DBController.GetVehicleGears(out List<string> gears))
			{
				comboGear.Items.AddRange(gears.ToArray());
			}
		}

		//public EditDataViewVehicle(Vehicle vehicle)
		//{
		//	InitializeComponent();
		//	buttonAccept.Text = "Fahrzeug bearbeiten";
		//}
	}
}
