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

		}

		private void buttonRefresh_Click(object sender, EventArgs e)
		{
			UpdateTable();
		}

		public void UpdateTable()
		{
			listVehicle.Items.Clear();
			if(!DBController.GetAllVehiclesFromDB(out List<Vehicle> vehicles))
			{
				MessageBox.Show("Bei der Verbindung zur Datenbank ist ein Fehler aufgetreten.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			listVehicle.Items.AddRange(vehicles.ToArray());
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
		}

		private void listVehicle_DrawItem(object sender, DrawItemEventArgs e)
		{
			e.DrawBackground();
			Brush brush = SystemBrushes.ControlText;
			Font font = e.Font;

			if(e.Index >= 0 && e.Index - 1 <= listVehicle.Items.Count)
			if (listVehicle.Items[e.Index] is Vehicle)
				if (!((Vehicle)listVehicle.Items[e.Index]).Available)
				{
					brush = Brushes.Red;
				}
			e.Graphics.DrawString(listVehicle.Items[e.Index].ToString(), font, brush, e.Bounds);
		}
	}
}
