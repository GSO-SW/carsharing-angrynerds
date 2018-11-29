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

			//vehicleListBox.DisplayMember = "DisplayMember";
			//vehicleListBox.Items.AddRange(DBController.GetAllVehiclesFromDB().ToArray());
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
				mileageLabel.Text = v.Mileage.ToString() + " km";
				numberPlateLabel.Text = v.NumberPlate;
				constrYearLabel.Text = v.ConstructionYear.ToString();
				regLabel.Text = v.Registration.Date.ToString("dd.MM.yyyy");
				gearLabel.Text = v.Gear;
				powerLabel.Text = v.Power.ToString() + " kW";
				lastMaintLabel.Text = v.LastMaintenance.Date.ToString("dd.MM.yyyy");
				tankFillingLabel.Text = v.TankFilling.ToString() + " l";
				maxTankFillingLabel.Text = v.MaxTankFilling.ToString() + " l";
				coordLabel.Text = v.Position.ToString();

				numberOfSeatsLabel.Text = v.Seats.ToString();
				fuelLabel.Text = v.FuelType;
				fuelConsupLabel.Text = v.FuelConsumption.ToString() + " l/100 km";
				klimaLabel.Text = convertBoolToYesNo(v.AirConditioner);
				tempoLabel.Text = convertBoolToYesNo(v.CruiseControl);
				radioLabel.Text = convertBoolToYesNo(v.Radio);
				bluetoothLabel.Text = convertBoolToYesNo(v.Bluetooth);
				usbLabel.Text = convertBoolToYesNo(v.USB);
				cdLabel.Text = convertBoolToYesNo(v.CDPlayer);
				naviLabel.Text = convertBoolToYesNo(v.Navi);
				absLabel.Text = convertBoolToYesNo(v.ABS);
				espLabel.Text = convertBoolToYesNo(v.ESP);
				seatHeatingLabel.Text = convertBoolToYesNo(v.SeatHeating);
				winterLabel.Text = convertBoolToYesNo(v.WinterTire);
				smokerLabel.Text = convertBoolToYesNo(v.Smoker);
				basepriceLabel.Text = v.BasicPrice + " €";
				pricePerkmLabel.Text = v.PricePerKilometre + " €";
				pricePerMinLabel.Text = v.PricePerMinute + " €";
				availableLabel.Text = convertBoolToYesNo(v.Available);
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
				numberOfSeatsLabel.Text = "-";
				fuelLabel.Text = "-";
				fuelConsupLabel.Text = "-";
				klimaLabel.Text = "-";
				tempoLabel.Text = "-";
				radioLabel.Text = "-";
				bluetoothLabel.Text = "-";
				usbLabel.Text = "-";
				cdLabel.Text = "-";
				naviLabel.Text = "-";
				absLabel.Text = "-";
				espLabel.Text = "-";
				seatHeatingLabel.Text = "-";
				winterLabel.Text = "-";
				smokerLabel.Text = "-";
				basepriceLabel.Text = "-";
				pricePerkmLabel.Text = "-";
				pricePerMinLabel.Text = "-";
				availableLabel.Text = "-";

				bookingButton.Enabled = false;
			}
		}

		private string convertBoolToYesNo(bool b)
		{
			if (b)
				return "Ja";
			else
				return "Nein";
		}
	}
}
