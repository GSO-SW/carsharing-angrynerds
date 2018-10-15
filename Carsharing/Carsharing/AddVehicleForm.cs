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
	public partial class AddVehicleForm : Form
	{
		public AddVehicleForm()
		{
			InitializeComponent();
			MaximizeBox = false;
			MinimizeBox = false;
			dateTimeConstructionYear.CustomFormat = "yyyy";
			dateTimeConstructionYear.ShowUpDown = true;
		}

		private void buttonAdd_Click(object sender, EventArgs e)
		{
			double mileage = SillyConverter.SillyDouble(textMileage.Text, textMileage2.Text);
			double tankFilling = SillyConverter.SillyDouble(textTankFilling.Text, textTankFilling2.Text);
			double maxTankFilling = SillyConverter.SillyDouble(textMaxTankFilling.Text, textMaxTankFilling2.Text);
			double basicPrice = SillyConverter.SillyDouble(textBasicPrice.Text, textBasicPrice2.Text);
			double pricePerKilometre = SillyConverter.SillyDouble(textPricePerKilometre.Text, textPricePerKilometre2.Text);
			double pricePerMinute = SillyConverter.SillyDouble(textPricePerMinute.Text, textPricePerMinute2.Text);
			int power = SillyConverter.SillyInt(textPower.Text);

			Vehicle vehicle = new Vehicle(textNumberPlate.Text, mileage, dateTimeLastMaintenance.Value, tankFilling, textPosition.Text, checkAvailable.Checked, textBrand.Text, textModel.Text, power, dateTimeConstructionYear.Value.Year, textGearShift.Text, maxTankFilling, basicPrice, pricePerKilometre, pricePerMinute); ;
			DBController.AddVehicle(vehicle);
		}

		private void buttonAbort_Click(object sender, EventArgs e)
		{
			DialogResult dialogResult = MessageBox.Show("Do you want to cancel your entry?", "Warning!", MessageBoxButtons.YesNo);
			if (dialogResult == DialogResult.Yes)
			{
				Close();
			}
		}

		private void textBox_KeyPressOnlyNumber(object sender, KeyPressEventArgs e)
		{
			if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
				e.Handled = true;
		}

		private void textBox_KeyPressOnlyNumber2(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar != 8)
				if (((TextBox)sender).TextLength >= 2 || (e.KeyChar < 48 || e.KeyChar > 57))
					e.Handled = true;
		}
	}
}
