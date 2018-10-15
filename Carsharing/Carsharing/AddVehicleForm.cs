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
			foreach (Control item in Controls)
			{
				if (item is MaskedTextBox)
				{
					item.Text = item.Text.Replace(' ', '0');
				}
			}
			Vehicle vehicle = new Vehicle(textNumberPlate.Text, Convert.ToDouble(maskedTextMileage.Text), dateTimeLastMaintenance.Value, Convert.ToDouble(maskedTextTankFilling.Text), new Point(double.Parse(textPosition.Text.Split(' ')[0]), double.Parse(textPosition.Text.Split(' ')[1])), checkAvailable.Checked, textBrand.Text, textModel.Text, Convert.ToInt32(maskedTextPower.Text), dateTimeConstructionYear.Value.Year, textGearShift.Text, Convert.ToInt32(maskedTextPower.Text), Convert.ToDouble(maskedTextBasicPrice.Text), Convert.ToDouble(maskedTextPricePerKilometre.Text), Convert.ToDouble(maskedTextPricePerMinute.Text)); ;
			DBController.AddVehicle(vehicle);
		}

		private void buttonAbort_Click(object sender, EventArgs e)
		{
			DialogResult dialogResult = MessageBox.Show("Wollen Sie ihre Eingabe wirklich verwerfen?", "Achtung!", MessageBoxButtons.YesNo);
			if (dialogResult == DialogResult.Yes)
				Close();
		}
	}
}
