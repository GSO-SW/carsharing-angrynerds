using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Carsharing
{
	internal partial class EditDataViewVehicle : UserControl
	{
		private Vehicle vehicleOld;

		internal EditDataViewVehicle()
		{
			InitializeComponent();
			buttonAccept.Text = "Fahrzeug hinzufügen";

			vehicleOld = null;
		}

		internal EditDataViewVehicle(Vehicle v)
		{
			InitializeComponent();
			buttonAccept.Text = "Fahrzeug bearbeiten";

			if (v != null)
			{
				vehicleOld = v;

				txtConstructionYear.Text = v.ConstructionYear.ToString();
				txtFuelCon.Text = v.FuelConsumption.ToString();
				txtMaxTankFilling.Text = v.MaxTankFilling.ToString();
				txtMileage.Text = v.Mileage.ToString();
				txtModel.Text = v.Model;
				txtNumberplate.Text = v.NumberPlate;
				txtPosX.Text = v.Position.X.ToString();
				txtPosY.Text = v.Position.Y.ToString();
				txtPower.Text = v.Power.ToString();
				txtPrice.Text = v.BasicPrice.ToString();
				txtPriceKilo.Text = v.PricePerKilometre.ToString();
				txtPriceMin.Text = v.PricePerMinute.ToString();
				txtReg.Text = v.Registration.ToShortDateString();
				txtSeats.Text = v.Seats.ToString();
				txtTankFilling.Text = v.TankFilling.ToString();

				checkABS.Checked = v.ABS;
				checkAirConditioner.Checked = v.AirConditioner;
				checkAvailable.Checked = v.Available;
				checkBluetooth.Checked = v.Bluetooth;
				checkCDPlayer.Checked = v.CDPlayer;
				checkCruiseControl.Checked = v.CruiseControl;
				checkESP.Checked = v.ESP;
				checkHeatedSeat.Checked = v.SeatHeating;
				checkNavigationDevice.Checked = v.Navi;
				checkRadio.Checked = v.Radio;
				checkSmoker.Checked = v.Smoker;
				checkUSB.Checked = v.USB;
				checkWinter.Checked = v.WinterTire;
			}
			else
			{
				ParentForm.Close();
			}
		}

		private void EditDataViewVehicle_Load(object sender, EventArgs e)
		{
			//Checks wether the current user isn't logged in.
			if (FormController.CurrentCustomer == null)
			{
				MessageBox.Show("Sie sind nicht angemeldet.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
				((EditDataView)Parent).Close();
				return;
			}

			//Checks wether the current user is admin.
			if (!FormController.CurrentCustomer.IsAdmin)
			{
				MessageBox.Show("Sie sind nicht als Admin angemeldet.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
				((EditDataView)Parent).Close();
				return;
			}

			//Get a list with all brands and add them to the brand-combobox.
			if (DBController.TryGetVehicleBrands(out List<string> brands))
			{
				comboBrand.Items.AddRange(brands.ToArray());
			}
			else
			{
				MessageBox.Show("Bei dem Laden aller Fahrzeugmarken ist ein Fehler aufgetreten.\nSie werden zum Hauptfenster zurückgeleitet.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
				((EditDataView)Parent).Close();
				return;
			}

			//Get a list with all gears and add them to the gear-combobox.
			if (DBController.TryGetVehicleGears(out List<string> gears))
			{
					comboGear.Items.AddRange(gears.ToArray());
			}
			else
			{
				MessageBox.Show("Bei dem Laden aller Getriebearten ist ein Fehler aufgetreten.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
				((EditDataView)Parent).Close();
				return;
			}

			//Get a list with all fuel types and add them to the fuel-combobox.
			if (DBController.TryGetFuelTypes(out List<string> fuel))
			{
				comboFuel.Items.AddRange(fuel.ToArray());
			}
			else
			{
				MessageBox.Show("Bei dem Laden aller Kraftstoffarten ist ein Fehler aufgetreten.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
				((EditDataView)Parent).Close();
				FormController.MainView.UpdateVehicleList();
				return;
			}

			if(vehicleOld != null)
			{
				comboBrand.SelectedItem = vehicleOld.Brand;
				comboFuel.SelectedItem = vehicleOld.FuelType;
				comboGear.SelectedItem = vehicleOld.Gear;
			}
		}

		private void buttonAccept_Click(object sender, EventArgs e)
		{
			if (test())
			{
				#region check
				if (!Double.TryParse(txtMileage.Text, out double mileage))
				{
					MessageBox.Show("Bitte überprüfen Sie ihre Eingabe beim Kilometerstand des Fahrzeuges.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}

				if (!Double.TryParse(txtTankFilling.Text, out double tankFilling))
				{
					MessageBox.Show("Bitte überprüfen Sie ihre Eingabe bei der aktuellen Tankfüllung des Fahrzeuges.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}

				if (!Double.TryParse(txtPower.Text, out double power))
				{
					MessageBox.Show("Bitte überprüfen Sie ihre Eingabe bei der Leistung des Fahrzeuges.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}

				if (!Double.TryParse(txtMaxTankFilling.Text, out double maxTankFilling))
				{
					MessageBox.Show("Bitte überprüfen Sie ihre Eingabe beim Kilometerstand des Fahrzeuges.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}

				if (!Double.TryParse(txtPrice.Text, out double basicPrice))
				{
					MessageBox.Show("Bitte überprüfen Sie ihre Eingabe beim Basispreis des Fahrzeuges.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}

				if (!Double.TryParse(txtPriceKilo.Text, out double pricePerKilometre))
				{
					MessageBox.Show("Bitte überprüfen Sie ihre Eingabe beim Preis pro Kilometer des Fahrzeuges.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}

				if (!Double.TryParse(txtPriceMin.Text, out double pricePerMinute))
				{
					MessageBox.Show("Bitte überprüfen Sie ihre Eingabe beim Preis pro Minute des Fahrzeuges.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}

				if (!Double.TryParse(txtPosX.Text, out double posX))
				{
					MessageBox.Show("Bitte überprüfen Sie ihre Eingabe der X-Koordinate des Standortes des Fahrzeuges.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}

				if (!Double.TryParse(txtPosY.Text, out double posY))
				{
					MessageBox.Show("Bitte überprüfen Sie ihre Eingabe der Y-Koordinate des Standortes des Fahrzeuges.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}

				if (!Double.TryParse(txtFuelCon.Text, out double fuelConsumption))
				{
					MessageBox.Show("Bitte überprüfen Sie ihre Eingabe beim Kraftstoffverbrauch des Fahrzeuges.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}

				if (!DateTime.TryParse(txtReg.Text, out DateTime registration))
				{
					MessageBox.Show("Bitte überprüfen Sie ihre Eingabe bei der Erstzulassung des Fahrzeuges.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}

				if (!Int32.TryParse(txtConstructionYear.Text, out int constructionYear))
				{
					MessageBox.Show("Bitte überprüfen Sie ihre Eingabe beim Baujahr des Fahrzeuges.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}

				if (!Int32.TryParse(txtSeats.Text, out int seats))
				{
					MessageBox.Show("Bitte überprüfen Sie ihre Eingabe beim der Sitzeanzahl des Fahrzeuges.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}

				if (tankFilling > maxTankFilling)
				{
					MessageBox.Show("Die aktuelle Tankfüllung kann nicht größer sein als die maximale Tankfüllung des Fahrzeuges.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}

				if (constructionYear < 1880)
				{
					MessageBox.Show("Bitte überprüfen Sie ihre Eingabe beim Baujahr des Fahrzeuges.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}

				if (constructionYear > DateTime.Today.Year)
				{
					MessageBox.Show("Das Baujahr des Fahrzeuges kann nicht in der Zukunft liegen.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}

				if (registration.Year < constructionYear)
				{
					MessageBox.Show("Das Erstzulassungsjahr kann nicht vor dem Baujahr sein.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}

				if(dateTimeLastMaintenance.Value.Year < constructionYear)
				{
					MessageBox.Show("Die letzte Wartung kann nicht vor dem Baujahr sein.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}

				if(!DBController.TryGetVehicleNumberPlates(out List<string> numberPlates))
				{
					MessageBox.Show("Bei dem Laden aller Kennzeichen ist ein Fehler aufgetreten.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}

				if (numberPlates.Contains(txtNumberplate.Text))
				{
					if(vehicleOld != null)
					{
						if (vehicleOld.NumberPlate != txtNumberplate.Text)
						{
							MessageBox.Show("Das Kennzeichen des Fahrzeug existiert bereits.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
							return;
						}							
					}
					else
					{
						MessageBox.Show("Das Kennzeichen des Fahrzeug existiert bereits.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
						return;
					}
				}
				#endregion

				Vehicle vehicle = new Vehicle(txtNumberplate.Text, mileage, dateTimeLastMaintenance.Value, tankFilling, new PointD(posX, posY), checkAvailable.Checked, comboBrand.Text, txtModel.Text, (int)Math.Round(power), constructionYear, comboGear.Text, maxTankFilling, basicPrice, pricePerKilometre, pricePerMinute, registration, seats, comboFuel.SelectedItem.ToString(), fuelConsumption, checkAirConditioner.Checked, checkCruiseControl.Checked, checkRadio.Checked, checkBluetooth.Checked, checkUSB.Checked, checkCDPlayer.Checked, checkNavigationDevice.Checked, checkABS.Checked, checkESP.Checked, checkHeatedSeat.Checked, checkWinter.Checked, checkSmoker.Checked);

				if (vehicleOld == null)
				{
					if (!DBController.TryAddVehicle(vehicle))
					{
						Feedback.ErrorDatabaseVehicleAdd();
						return;
					}
					Feedback.SuccessVehicleAdd();
				}
				else
				{
					if (!DBController.TryUpdateVehicleInDB(vehicle, vehicleOld))
					{
						Feedback.ErrorDatabaseVehicleEdit();
						return;
					}

					if (!DBController.TryCheckVehicleTypeIsNeeded(vehicleOld))
					{
						Feedback.ErrorDatabaseVehicleTypeDelete();
					}

					Feedback.SuccessVehicleEdit();
				}
				((EditDataView)Parent).Close();
				FormController.MainView.UpdateVehicleList();
			}
		}

		private bool test()
		{
			if (String.IsNullOrWhiteSpace(txtNumberplate.Text))
			{
				MessageBox.Show("Bitte geben Sie das Kennzeichen des Fahrzeuges an.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}

			if (String.IsNullOrWhiteSpace(txtMileage.Text))
			{
				MessageBox.Show("Bitte geben Sie den aktuellen Kilometerstand des Fahrzeuges an, dieser kann auch 0 sein.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}

			if (String.IsNullOrWhiteSpace(txtTankFilling.Text))
			{
				MessageBox.Show("Bitte geben Sie die Tankfüllung des Fahrzeuges an, diese kann auch 0 sein.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}

			if (String.IsNullOrWhiteSpace(comboBrand.Text))
			{
				MessageBox.Show("Bitte geben Sie die Marke des Fahrzeuges an.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}

			if (String.IsNullOrWhiteSpace(txtModel.Text))
			{
				MessageBox.Show("Bitte geben Sie das Modell des Fahrzeuges an.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}

			if (String.IsNullOrWhiteSpace(txtPower.Text))
			{
				MessageBox.Show("Bitte geben Sie die Leistung des Fahrzeuges an.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}

			if (String.IsNullOrWhiteSpace(comboGear.Text))
			{
				MessageBox.Show("Bitte geben Sie die Schaltart des Fahrzeuges an.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}

			if (String.IsNullOrWhiteSpace(txtMaxTankFilling.Text))
			{
				MessageBox.Show("Bitte geben Sie die maximale Tankfüllung des Fahrzeuges an.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}

			if (String.IsNullOrWhiteSpace(txtPrice.Text))
			{
				MessageBox.Show("Bitte geben Sie den Basispreises des Fahrzeuges an.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}

			if (String.IsNullOrWhiteSpace(txtPriceKilo.Text))
			{
				MessageBox.Show("Bitte geben Sie den Preis pro Kilometer des Fahrzeuges an.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}

			if (String.IsNullOrWhiteSpace(txtPriceMin.Text))
			{
				MessageBox.Show("Bitte geben Sie den Preis pro Minute des Fahrzeuges an.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}

			if (String.IsNullOrWhiteSpace(txtPosX.Text))
			{
				MessageBox.Show("Bitte geben Sie die X-Koordinate des Fahrzeuges an.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}

			if (String.IsNullOrWhiteSpace(txtPosY.Text))
			{
				MessageBox.Show("Bitte geben Sie die Y-Koordinate des Fahrzeuges an.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			return true;
		}
	}
}
