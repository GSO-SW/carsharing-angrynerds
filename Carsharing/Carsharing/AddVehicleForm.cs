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
			dateTimeConstructionYear.Format = DateTimePickerFormat.Custom;
			dateTimeConstructionYear.CustomFormat = "yyyy";
			dateTimeConstructionYear.ShowUpDown = true;

			foreach (string item in DBController.GetVehicleBrands())
			{
				comboBrand.Items.Add(item);
			}

			foreach (string item in DBController.GetVehicleGears())
			{
				comboGear.Items.Add(item);
			}
		}

		private void buttonAdd_Click(object sender, EventArgs e)
		{
			//Überprüft, ob die Eingaben korrekt sind.
			//Sollte ein Fehler bei der Eingabe vorliegen, so wird eine Fehlermeldung angezeigt und der Vorgang (Bestätigung) wird abgebrochen.
			#region Check
			#region IsNullOrWhiteSpace
			if (String.IsNullOrWhiteSpace(textNumberPlate.Text))
			{
				MessageBox.Show("Bitte geben Sie das Kennzeichen des Fahrzeuges an.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (String.IsNullOrWhiteSpace(textMileage.Text))
			{
				MessageBox.Show("Bitte geben Sie den aktuellen Kilometerstand des Fahrzeuges an, dieser kann auch 0 sein.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (String.IsNullOrWhiteSpace(textTankfilling.Text))
			{
				MessageBox.Show("Bitte geben Sie die Tankfüllung des Fahrzeuges an, diese kann auch 0 sein.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (String.IsNullOrWhiteSpace(textPositionX.Text))
			{
				MessageBox.Show("Bitte geben Sie eine Position des Fahrzeuges an.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (String.IsNullOrWhiteSpace(comboBrand.Text))
			{
				MessageBox.Show("Bitte geben Sie die Marke des Fahrzeuges an.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (String.IsNullOrWhiteSpace(textModel.Text))
			{
				MessageBox.Show("Bitte geben Sie das Modell des Fahrzeuges an.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (String.IsNullOrWhiteSpace(textPower.Text))
			{
				MessageBox.Show("Bitte geben Sie die Leistung des Fahrzeuges an.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (String.IsNullOrWhiteSpace(comboGear.Text))
			{
				MessageBox.Show("Bitte geben Sie die Schaltart des Fahrzeuges an.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (String.IsNullOrWhiteSpace(textMaxTankFilling.Text))
			{
				MessageBox.Show("Bitte geben Sie die maximale Tankfüllung des Fahrzeuges an.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (String.IsNullOrWhiteSpace(textBasicPrice.Text))
			{
				MessageBox.Show("Bitte geben Sie den Basispreises des Fahrzeuges an.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (String.IsNullOrWhiteSpace(textPricePerKilometre.Text))
			{
				MessageBox.Show("Bitte geben Sie den Preis pro Kilometer des Fahrzeuges an.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (String.IsNullOrWhiteSpace(textPricePerMinute.Text))
			{
				MessageBox.Show("Bitte geben Sie den Preis pro Minute des Fahrzeuges an.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (String.IsNullOrWhiteSpace(textPositionX.Text))
			{
				MessageBox.Show("Bitte geben Sie die X-Koordinate des Fahrzeuges an.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (String.IsNullOrWhiteSpace(textPositionY.Text))
			{
				MessageBox.Show("Bitte geben Sie die Y-Koordinate des Fahrzeuges an.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			#endregion

			#region TryParse
			double mileage, tankFilling, power, maxTankFilling, basicPrice, pricePerKilometre, pricePerMinute, posX, posY;
			if (!Double.TryParse(textMileage.Text, out mileage))
			{
				MessageBox.Show("Bitte überprüfen Sie ihre Eingabe beim Kilometerstand des Fahrzeuges.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (!Double.TryParse(textTankfilling.Text, out tankFilling))
			{
				MessageBox.Show("Bitte überprüfen Sie ihre Eingabe bei der aktuellen Tankfüllung des Fahrzeuges.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (!Double.TryParse(textPower.Text, out power))
			{
				MessageBox.Show("Bitte überprüfen Sie ihre Eingabe bei der Leistung des Fahrzeuges.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (!Double.TryParse(textMaxTankFilling.Text, out maxTankFilling))
			{
				MessageBox.Show("Bitte überprüfen Sie ihre Eingabe beim Kilometerstand des Fahrzeuges.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (!Double.TryParse(textBasicPrice.Text, out basicPrice))
			{
				MessageBox.Show("Bitte überprüfen Sie ihre Eingabe beim Basispreis des Fahrzeuges.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (!Double.TryParse(textPricePerKilometre.Text, out pricePerKilometre))
			{
				MessageBox.Show("Bitte überprüfen Sie ihre Eingabe beim Preis pro Kilometer des Fahrzeuges.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (!Double.TryParse(textPricePerMinute.Text, out pricePerMinute))
			{
				MessageBox.Show("Bitte überprüfen Sie ihre Eingabe beim Kilometerstand des Fahrzeuges.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (!Double.TryParse(textPositionX.Text, out posX))
			{
				MessageBox.Show("Bitte überprüfen Sie ihre Eingabe der X-Koordinate des Standortes des Fahrzeuges.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (!Double.TryParse(textPositionY.Text, out posY))
			{
				MessageBox.Show("Bitte überprüfen Sie ihre Eingabe der Y-Koordinate des Standortes des Fahrzeuges.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			#endregion

			#region rest
			if (tankFilling > maxTankFilling)
			{
				MessageBox.Show("Die aktuelle Tankfüllung kann nicht größer sein als die maximale Tankfüllung des Fahrzeuges.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (dateTimeConstructionYear.Value.Year > DateTime.Today.Year)
			{
				MessageBox.Show("Das Baujahr des Fahrzeuges kann nicht in der Zukunft liegen.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			#endregion
			#endregion

			Vehicle vehicle = new Vehicle(textNumberPlate.Text, mileage, dateTimeLastMaintenance.Value, tankFilling, new PointD(posX, posY), checkAvailable.Checked, comboBrand.Text, textModel.Text, (int)Math.Round(power), dateTimeConstructionYear.Value.Year, comboGear.Text, maxTankFilling, basicPrice, pricePerKilometre, pricePerMinute);
			DBController.AddVehicle(vehicle);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			foreach (Control item in Controls)
			{
				if (item is TextBox)
					if (!String.IsNullOrWhiteSpace(((TextBox)item).Text))
					{
						DialogResult dialogResult = MessageBox.Show("Wollen Sie ihre Eingabe wirklich verwerfen?", "Achtung!", MessageBoxButtons.YesNo);
						if (dialogResult == DialogResult.Yes)
							Close();
							return;
					}
			}
			Close();
		}
	}
}
