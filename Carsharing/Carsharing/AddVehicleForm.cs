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
			Vehicle vehicle = new Vehicle(textNumberPlate.Text, Convert.ToDouble(maskedTextMileage.Text), dateTimeLastMaintenance.Value, Convert.ToDouble(maskedTextTankFilling), textPosition.Text, checkAvailable.Checked, textBrand.Text, textModel.Text, Convert.ToInt32(maskedTextPower.Text), dateTimeConstructionYear.Value.Year, textGearShift.Text, Convert.ToInt32(maskedTextPower.Text), Convert.ToDouble(maskedTextBasicPrice.Text), Convert.ToDouble(maskedTextPricePerKilometre.Text), Convert.ToDouble(maskedTextPricePerMinute.Text)); ;
			DBController.AddVehicle(vehicle);
		}

		private void buttonAbort_Click(object sender, EventArgs e)
		{
			DialogResult dialogResult = MessageBox.Show("Wollen Sie ihre Eingabe wirklich verwerfen?", "Achtung!", MessageBoxButtons.YesNo);
			if (dialogResult == DialogResult.Yes)
				Close();
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
