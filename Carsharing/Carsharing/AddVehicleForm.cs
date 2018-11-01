using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Carsharing
{
	public partial class AddVehicleForm : Form
	{
		public AddVehicleForm()
		{
			InitializeComponent();

			//Disables the possibility to change the window size. 
			MaximizeBox = false;
			MinimizeBox = false;

			//
			foreach (Control item in Controls)
			{
				if (item is TextBox || item is ComboBox)
					progressBar.Maximum++;
				if (item is GroupBox)
					foreach (Control item2 in ((GroupBox)item).Controls)
						if (item2 is TextBox || item2 is ComboBox)
							progressBar.Maximum++;
			}

			buttonAdd.Enabled = progressBar.Value == progressBar.Maximum;
		}

		private void AddVehicleForm_Load(object sender, EventArgs e)
		{
			//Checks wether the current user isn't logged in.
			if (FormController.CurrentCustomer == null)
			{
				MessageBox.Show("Sie sind nicht angemeldet.\nSie werden zum Hauptfenster zurückgeleitet.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
				Close();
				return;
			}

			//Checks wether the current user is admin.
			if (!FormController.CurrentCustomer.IsAdmin)
			{
				MessageBox.Show("Sie sind nicht als Admin angemeldet.\nSie werden zum Hauptfenster zurückgeleitet.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
				Close();
				return;
			}

			//Get a list with all brands and add them to the brand-combobox.
			if (DBController.GetVehicleBrands(out List<string> brands))
			{
				foreach (string item in brands)
				{
					comboBrand.Items.Add(item);
				}
			}
			else
			{
				MessageBox.Show("Bei dem Laden aller Fahrzeugmarken ist ein Fehler aufgetreten.\nSie werden zum Hauptfenster zurückgeleitet.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
				Close();
				return;
			}

			//Get a list with all gears and add them to the gear-combobox.
			if (DBController.GetVehicleGears(out List<string> gears))
			{
				foreach (string item in gears)
				{
					comboGear.Items.Add(item);
				}
			}
			else
			{
				MessageBox.Show("Bei dem Laden aller Getriebearten ist ein Fehler aufgetreten.\nSie werden zum Hauptfenster zurückgeleitet.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
				Close();
				return;
			}

			//Get a list with all fuel types and add them to the fuel-combobox.
			if (DBController.GetFuelTypes(out List<string> fuel))
			{
				foreach (string item in fuel)
				{
					comboFuel.Items.Add(item);
				}
			}
			else
			{
				MessageBox.Show("Bei dem Laden aller Kraftstoffarten ist ein Fehler aufgetreten.\nSie werden zum Hauptfenster zurückgeleitet.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
				Close();
				return;
			}

			//Add Years
			for (int i = DateTime.Today.Year; i >= 1900; i--)
			{
				comboVehicleLicenseYear.Items.Add(i);
				comboConstructionYear.Items.Add(i);
			}
		}

		private void buttonAdd_Click(object sender, EventArgs e)
		{

			#region Check
			//Checks wether any textbox or combobox is empty.
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

			//Checks wether all number entries are convertable.
			#region TryParse
			if (!Double.TryParse(textMileage.Text, out double mileage))
			{
				MessageBox.Show("Bitte überprüfen Sie ihre Eingabe beim Kilometerstand des Fahrzeuges.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (!Double.TryParse(textTankfilling.Text, out double tankFilling))
			{
				MessageBox.Show("Bitte überprüfen Sie ihre Eingabe bei der aktuellen Tankfüllung des Fahrzeuges.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (!Double.TryParse(textPower.Text, out double power))
			{
				MessageBox.Show("Bitte überprüfen Sie ihre Eingabe bei der Leistung des Fahrzeuges.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (!Double.TryParse(textMaxTankFilling.Text, out double maxTankFilling))
			{
				MessageBox.Show("Bitte überprüfen Sie ihre Eingabe beim Kilometerstand des Fahrzeuges.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (!Double.TryParse(textBasicPrice.Text, out double basicPrice))
			{
				MessageBox.Show("Bitte überprüfen Sie ihre Eingabe beim Basispreis des Fahrzeuges.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (!Double.TryParse(textPricePerKilometre.Text, out double pricePerKilometre))
			{
				MessageBox.Show("Bitte überprüfen Sie ihre Eingabe beim Preis pro Kilometer des Fahrzeuges.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (!Double.TryParse(textPricePerMinute.Text, out double pricePerMinute))
			{
				MessageBox.Show("Bitte überprüfen Sie ihre Eingabe beim Kilometerstand des Fahrzeuges.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (!Double.TryParse(textPositionX.Text, out double posX))
			{
				MessageBox.Show("Bitte überprüfen Sie ihre Eingabe der X-Koordinate des Standortes des Fahrzeuges.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (!Double.TryParse(textPositionY.Text, out double posY))
			{
				MessageBox.Show("Bitte überprüfen Sie ihre Eingabe der Y-Koordinate des Standortes des Fahrzeuges.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (!Double.TryParse(textFuelConsumption.Text, out double fuelConsumption))
			{
				MessageBox.Show("Bitte überprüfen Sie ihre Eingabe beim Kraftstoffverbrauch des Fahrzeuges.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			#endregion

			//Checks the rest. Physical laws etc.
			#region rest
			DateTime registration = new DateTime(Convert.ToInt32(comboVehicleLicenseYear.SelectedItem), DateTime.Parse("1." + comboVehicleLicenseMonth.SelectedItem + ".2000").Month, 1);
			int constructionYear = Convert.ToInt32(comboConstructionYear.SelectedItem);

			if (tankFilling > maxTankFilling)
			{
				MessageBox.Show("Die aktuelle Tankfüllung kann nicht größer sein als die maximale Tankfüllung des Fahrzeuges.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (Convert.ToInt32(comboConstructionYear.SelectedItem) > DateTime.Today.Year)
			{
				MessageBox.Show("Das Baujahr des Fahrzeuges kann nicht in der Zukunft liegen.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (registration.Year < constructionYear)
			{
				MessageBox.Show("Das Erstzulassungsjahr kann nicht vor dem Baujahr sein.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			DBController.GetVehicleNumberPlates(out List<string> numberPlates);
			foreach (string item in numberPlates)
			{
				if (textNumberPlate.Text == item)
				{
					MessageBox.Show("Das Kennzeichen des Fahrzeug existiert bereits.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
			}
			#endregion
			#endregion
			//Creates a new instance of type vehicle with all entries.
			Vehicle vehicle = new Vehicle(textNumberPlate.Text, mileage, dateTimeLastMaintenance.Value, tankFilling, new PointD(posX, posY), checkAvailable.Checked, comboBrand.Text, textModel.Text, (int)Math.Round(power), constructionYear, comboGear.Text, maxTankFilling, basicPrice, pricePerKilometre, pricePerMinute, registration, Convert.ToInt16(comboSeats.SelectedItem.ToString().Split(' ')[0]), comboFuel.SelectedItem.ToString(), fuelConsumption, checkAirConditioner.Checked, checkCruiseControl.Checked, checkRadio.Checked, checkBluetooth.Checked, checkUSB.Checked, checkCDPlayer.Checked, checkNavigationDevice.Checked, checkABS.Checked, checkESP.Checked, checkHeatedSeat.Checked, checkWinter.Checked, checkSmoker.Checked);

			//Adds the instance of type vehicle to the DB.
			if (!DBController.AddVehicle(vehicle))
			{
				MessageBox.Show("Beim Hinzufügen des Fahrzeuges ist ein Fehler unterlaufen.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			MessageBox.Show("Das Fahrzeug wurde hinzugefügt.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
			Close();
		}

		private void text_Changed(object sender, EventArgs e)
		{
			int i = 0;
			foreach (Control item in Controls)
			{
				if (item is TextBox)
					if (!string.IsNullOrWhiteSpace(((TextBox)item).Text))
						i++;
				if (item is ComboBox)
					if (!string.IsNullOrWhiteSpace(((ComboBox)item).Text))
						i++;
				if (item is GroupBox)
					foreach (Control item2 in ((GroupBox)item).Controls)
					{
						if (item2 is TextBox)
							if (!string.IsNullOrWhiteSpace(((TextBox)item2).Text))
								i++;
						if (item2 is ComboBox)
							if (!string.IsNullOrWhiteSpace(((ComboBox)item2).Text))
								i++;
					}
			}
			progressBar.Value = i;

			buttonAdd.Enabled = (progressBar.Value == progressBar.Maximum);
		}

		private void buttonAdd_EnabledChanged(object sender, EventArgs e)
		{
			if(sender is Button)
			{
				Button button = (Button)sender;
				if (button.Enabled)
					button.BackColor = Color.Green;
				else
					button.BackColor = Color.LightGray;
			}
		}
	}
}
