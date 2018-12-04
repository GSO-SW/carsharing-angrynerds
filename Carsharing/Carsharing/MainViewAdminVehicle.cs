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
	internal partial class MainViewAdminVehicle : UserControl
	{
		internal MainViewAdminVehicle()
		{
			InitializeComponent();
			listVehicle.DrawMode = DrawMode.OwnerDrawFixed;
		}

		private void AdminVehicles_Load(object sender, EventArgs e)
		{
			UpdateTable();
		}

		private void buttonAddVehicle_Click(object sender, EventArgs e)
		{
			new EditDataView().ShowDialog();
		}

		private void buttonVehicleEdit_Click(object sender, EventArgs e)
		{
			if (listVehicle.SelectedItem is Vehicle vehicle)
			{
				if(DBController.CheckOpenBookingVehicle(vehicle, out bool result))
				{
					if (!result)
					{
						new EditDataView(vehicle).ShowDialog();
					}
				}
			}
		}

		private void buttonVehicleDelete_Click(object sender, EventArgs e)
		{
			if (listVehicle.SelectedItem != null)
			{
				//Meldung: Möchten Sie das Fahrzeug mit dem Kennzeichen: " " wirklich löschen?
			}
			else
			{
				//Meldung: Kein Fahrzeug ausgewählt
			}
		}

		private void buttonRefresh_Click(object sender, EventArgs e)
		{
			UpdateTable();
		}

		private void listVehicle_DrawItem(object sender, DrawItemEventArgs e)
		{
			e.DrawBackground();
			Brush brush = SystemBrushes.ControlText;
			Font font = e.Font;

			if (e.Index >= 0 && e.Index - 1 <= listVehicle.Items.Count)
				if (listVehicle.Items[e.Index] is Vehicle)
					if (!((Vehicle)listVehicle.Items[e.Index]).Available)
					{
						brush = Brushes.Red;
					}
			e.Graphics.DrawString(listVehicle.Items[e.Index].ToString(), font, brush, e.Bounds);
		}

		private void listVehicle_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (listVehicle.SelectedItem is Vehicle)
			{
				Vehicle vehicle = (Vehicle)listVehicle.SelectedItem;

				txtBrand.Text = vehicle.Brand;
				txtConstructionYear.Text = vehicle.ConstructionYear.ToString();
				txtPosY.Text = vehicle.Position.Y.ToString();
				txtPosX.Text = vehicle.Position.X.ToString();
				txtFuelCon.Text = vehicle.FuelConsumption.ToString() + " E/100km";
				txtGear.Text = vehicle.Gear;
				txtLastMaint.Text = vehicle.LastMaintenance.ToLongDateString();
				txtMaxTankFilling.Text = vehicle.MaxTankFilling.ToString() + " l";
				txtMileage.Text = vehicle.Mileage.ToString();
				txtModel.Text = vehicle.Model;
				txtNumberplate.Text = vehicle.NumberPlate;
				txtPower.Text = vehicle.Power.ToString() + " kw";
				txtReg.Text = vehicle.Registration.Month + ", " + vehicle.Registration.Year;
				txtSeats.Text = vehicle.Seats.ToString();
				txtTankFilling.Text = vehicle.TankFilling.ToString() + " l";
				txtFuel.Text = vehicle.FuelType;
				txtPrice.Text = vehicle.BasicPrice.ToString() + " €";
				txtPriceKilo.Text = vehicle.PricePerKilometre.ToString() + " €";
				txtPriceMin.Text = vehicle.PricePerMinute.ToString() + " €";
				checkABS.Checked = vehicle.ABS;
				checkAirConditioner.Checked = vehicle.AirConditioner;
				checkBluetooth.Checked = vehicle.Bluetooth;
				checkCDPlayer.Checked = vehicle.CDPlayer;
				checkCruiseControl.Checked = vehicle.CruiseControl;
				checkESP.Checked = vehicle.ESP;
				checkHeatedSeat.Checked = vehicle.SeatHeating;
				checkNavigationDevice.Checked = vehicle.Navi;
				checkRadio.Checked = vehicle.Radio;
				checkSmoker.Checked = vehicle.Smoker;
				checkUSB.Checked = vehicle.USB;
				checkWinter.Checked = vehicle.WinterTire;
			}
			else
			{
				Placeholer();
			}
		}

		internal void UpdateTable()
		{
			listVehicle.Items.Clear();
			Placeholer();
			if (!DBController.GetAllVehiclesFromDB(out List<Vehicle> vehicles))
			{
				Feedback.ErrorDatabaseConnection();
				return;
			}
			listVehicle.Items.AddRange(vehicles.ToArray());
		}

		private void Placeholer()
		{
			txtBrand.Text = FormController.Placeholder;
			txtConstructionYear.Text = FormController.Placeholder;
			txtPosY.Text = FormController.Placeholder;
			txtPosX.Text = FormController.Placeholder;
			txtFuelCon.Text = FormController.Placeholder;
			txtGear.Text = FormController.Placeholder;
			txtLastMaint.Text = FormController.Placeholder;
			txtMaxTankFilling.Text = FormController.Placeholder;
			txtMileage.Text = FormController.Placeholder;
			txtModel.Text = FormController.Placeholder;
			txtNumberplate.Text = FormController.Placeholder;
			txtPower.Text = FormController.Placeholder;
			txtReg.Text = FormController.Placeholder;
			txtSeats.Text = FormController.Placeholder;
			txtTankFilling.Text = FormController.Placeholder;
			txtFuel.Text = FormController.Placeholder;
			txtPrice.Text = FormController.Placeholder;
			txtPriceKilo.Text = FormController.Placeholder;
			txtPriceMin.Text = FormController.Placeholder;
			checkABS.Checked = false;
			checkAirConditioner.Checked = false;
			checkBluetooth.Checked = false;
			checkCDPlayer.Checked = false;
			checkCruiseControl.Checked = false;
			checkESP.Checked = false;
			checkHeatedSeat.Checked = false;
			checkNavigationDevice.Checked = false;
			checkRadio.Checked = false;
			checkSmoker.Checked = false;
			checkUSB.Checked = false;
			checkWinter.Checked = false;
		}
	}
}
