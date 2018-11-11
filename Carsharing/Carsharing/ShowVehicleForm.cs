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
	public partial class ShowVehicleForm : Form
	{
		public ShowVehicleForm()
		{
			InitializeComponent();

			vehicleListBox.DisplayMember = "DisplayMember";
			vehicleListBox.Items.AddRange(DBController.GetAllVehiclesFromDB().ToArray());
		}

		private void vehicleListBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (sender is ListBox)
			{
				if (((ListBox)sender).SelectedItem != null && ((ListBox)sender).SelectedItem is Vehicle)
				{
					showVehicleInfos((Vehicle)((ListBox)sender).SelectedItem);
				}
				else
					showVehicleInfos();
			}
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="v"></param>
		private void showVehicleInfos(Vehicle v = null)
		{
			if (v != null)
			{
				brandLabel.Text = v.Brand;
				modelLabel.Text = v.Model;
				mileageLabel.Text = v.NumberPlate;
				numberPlateLabel.Text = v.NumberPlate;
				constrYearLabel.Text = v.ConstructionYear.Year.ToString();
				regLabel.Text = v.Registration.Date.ToString("dd.MM.yyyy");
				gearLabel.Text = v.Gear;
				powerLabel.Text = v.Power.ToString();
				lastMaintLabel.Text = v.LastMaintenance.Date.ToString("dd.MM.yyyy");
				tankFillingLabel.Text = v.TankFilling.ToString();
				maxTankFillingLabel.Text = v.MaxTankFilling.ToString();
				coordLabel.Text = v.Position.ToString();

				bookingButton.Enabled = v.Available;
			}
			else
			{
				brandLabel.Text = "-";
				modelLabel.Text = "-";
				mileageLabel.Text = "-";
				numberPlateLabel.Text = "-";
				constrYearLabel.Text = "-";
				regLabel.Text = "-";
				gearLabel.Text = "-";
				powerLabel.Text = "-";
				lastMaintLabel.Text = "-";
				tankFillingLabel.Text = "-";
				maxTankFillingLabel.Text = "-";
				coordLabel.Text = "-";

				bookingButton.Enabled = false;
			}
		}
	}
}
