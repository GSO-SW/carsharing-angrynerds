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
	internal partial class MainViewUserBooking : UserControl
	{
		internal MainViewUserBooking()
		{
			InitializeComponent();

            UpdateForm();
		}

		private void MainViewUserBooking_Load(object sender, EventArgs e)
		{
			UpdateTable();
		}

		private void buttonRefresh_Click(object sender, EventArgs e)
		{
			UpdateTable();
		}

		private void listVehicle_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (listVehicle.SelectedItem is Vehicle vehicle)
			{
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
				txtPower.Text = vehicle.Power.ToString() + " kW";
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

		private void buttonBookingAdd_Click(object sender, EventArgs e)
		{
			//check, if the customer or the vehicle has open bookings
			if (DBController.CheckOpenBookingsCustomer(FormController.CurrentCustomer, out bool cresult) && !cresult)
			{
				if (listVehicle.SelectedItem != null && listVehicle.SelectedItem is Vehicle v && DBController.CheckOpenBookingVehicle(v, out bool vresult) && !vresult && v.Available)
				{
					Booking b = new Booking(FormController.CurrentCustomer, v, DateTime.Now, new DateTime(0), v.Mileage, 0, true);
					if (DBController.AddBookingToDB(b))
					{
						MessageBox.Show("Buchung erfolgreich.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
					else
					{
						MessageBox.Show("Buchung nicht erfolgreich. Bitte versuchen Sie es noch einmal.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
				else
				{
					MessageBox.Show("Buchung nicht erfolgreich, da das Fahrzeug nicht verfügbar ist.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			else
			{
				MessageBox.Show("Buchung nicht erfolgreich, da Sie bereits eine offene Buchung haben.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

        internal void UpdateForm()
        {
            listVehicle.DisplayMember = "DisplayMember";
            UpdateTable();
        }
	}
}
