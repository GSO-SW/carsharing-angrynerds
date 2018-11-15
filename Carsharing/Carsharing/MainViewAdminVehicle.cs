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
			
			foreach (Vehicle item in DBController.GetAllVehiclesFromDB())
			{
				int rowIndex = dataGridView1.Rows.Add();

				DataGridViewRow d = dataGridView1.Rows[rowIndex];

				d.Cells["numberPlate"].Value = item.NumberPlate;
				d.Cells["mileage"].Value = item.Mileage;
				d.Cells["lastMaintenance"].Value = item.LastMaintenance.ToShortDateString();
				d.Cells["tankFilling"].Value = item.TankFilling + " l";
				d.Cells["position"].Value = item.Position;
				d.Cells["available"].Value = item.Available;
				d.Cells["brand"].Value = item.Brand;
				d.Cells["model"].Value = item.Model;
				d.Cells["power"].Value = item.Power + " kw";
				d.Cells["constructionYear"].Value = item.ConstructionYear.Year;
				d.Cells["gearShift"].Value = item.Gear;
				d.Cells["maxTankFilling"].Value = item.MaxTankFilling + " l";
				d.Cells["basicPrice"].Value = item.BasicPrice;
				d.Cells["pricePerKilometre"].Value = item.PricePerKilometre;
				d.Cells["pricePerMinute"].Value = item.PricePerMinute;
				d.Cells["registration"].Value = item.Registration;
				d.Cells["seats"].Value = item.Seats;
				d.Cells["fuelType"].Value = item.FuelType;
				d.Cells["fuelComsumption"].Value = item.FuelConsumption + " Einheit(en) / 100km";
				d.Cells["airConditioner"].Value = item.AirConditioner;
				d.Cells["cruiseControl"].Value = item.CruiseControl;
				d.Cells["radio"].Value = item.Radio;
				d.Cells["bluetooth"].Value = item.Bluetooth;
				d.Cells["usb"].Value = item.USB;
				d.Cells["cdPlayer"].Value = item.CDPlayer;
				d.Cells["navi"].Value = item.Navi;
				d.Cells["abs"].Value = item.ABS;
				d.Cells["esp"].Value = item.ESP;
				d.Cells["seatHeating"].Value = item.SeatHeating;
				d.Cells["winterTire"].Value = item.WinterTire;
				d.Cells["smoker"].Value = item.Smoker;
			}
		}

		private void buttonAddVehicle_Click(object sender, EventArgs e)
		{
			new AddVehicleForm().ShowDialog();
		}
	}
}
