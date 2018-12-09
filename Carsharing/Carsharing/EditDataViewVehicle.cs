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
				Feedback.ErrorCustomerIsntLoggedIn();
				ParentForm.Close();
				return;
			}

			//Checks wether the current user is admin.
			if (!FormController.CurrentCustomer.IsAdmin)
			{
				Feedback.ErrorCustomerIsntAdmin();
				ParentForm.Close();
				return;
			}

			//Get a list with all brands and add them to the brand-combobox.
			if (DBController.TryGetVehicleBrands(out List<string> brands))
			{
				comboBrand.Items.AddRange(brands.ToArray());
			}
			else
			{
				Feedback.ErrorDatabaseLoadBrands();
				ParentForm.Close();
				return;
			}

			//Get a list with all gears and add them to the gear-combobox.
			if (DBController.TryGetVehicleGears(out List<string> gears))
			{
					comboGear.Items.AddRange(gears.ToArray());
			}
			else
			{
				Feedback.ErrorDatabaseLoadGears();
				ParentForm.Close();
				return;
			}

			//Get a list with all fuel types and add them to the fuel-combobox.
			if (DBController.TryGetFuelTypes(out List<string> fuel))
			{
				comboFuel.Items.AddRange(fuel.ToArray());
			}
			else
			{
				Feedback.ErrorDatabaseLoadFuels();
				ParentForm.Close();
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
					Feedback.ErrorConvertMileage();
					return;
				}

				if (!Double.TryParse(txtTankFilling.Text, out double tankFilling))
				{
					Feedback.ErrorConvertTankFilling();
					return;
				}

				if (!Double.TryParse(txtPower.Text, out double power))
				{
					Feedback.ErrorConvertPower();
					return;
				}

				if (!Double.TryParse(txtMaxTankFilling.Text, out double maxTankFilling))
				{
					Feedback.ErrorConvertMaxTankFilling();
					return;
				}

				if (!Double.TryParse(txtPrice.Text, out double basicPrice))
				{
					Feedback.ErrorConvertBasicPrice();
					return;
				}

				if (!Double.TryParse(txtPriceKilo.Text, out double pricePerKilometre))
				{
					Feedback.ErrorConvertPriceKilo();
					return;
				}

				if (!Double.TryParse(txtPriceMin.Text, out double pricePerMinute))
				{
					Feedback.ErrorConvertPriceMin();
					return;
				}

				if (!Double.TryParse(txtPosX.Text, out double posX))
				{
					Feedback.ErrorConvertLocationX();
					return;
				}

				if (!Double.TryParse(txtPosY.Text, out double posY))
				{
					Feedback.ErrorConvertLocationY();
					return;
				}

				if (!Double.TryParse(txtFuelCon.Text, out double fuelConsumption))
				{
					Feedback.ErrorConvertFuelCon();
					return;
				}

				if (!DateTime.TryParse(txtReg.Text, out DateTime registration))
				{
					Feedback.ErrorConvertRegi();
					return;
				}

				if (!Int32.TryParse(txtConstructionYear.Text, out int constructionYear))
				{
					Feedback.ErrorConvertConstructionYear();
					return;
				}

				if (!Int32.TryParse(txtSeats.Text, out int seats))
				{
					Feedback.ErrorConvertSeats();
					return;
				}

				if (tankFilling > maxTankFilling)
				{
					Feedback.ErrorPhysikTankFilling();
					return;
				}

				if (constructionYear < 1880)
				{
					Feedback.ErrorConstructionYearTooEarly();
					return;
				}

				if (constructionYear > DateTime.Today.Year)
				{
					Feedback.ErrorConstructionYearTooLate();
					return;
				}

				if (registration.Year < constructionYear)
				{
					Feedback.ErrorRegiBeforeConstruction();
					return;
				}

				if(dateTimeLastMaintenance.Value.Year < constructionYear)
				{
					Feedback.ErrorMaintanceBeforeConstruction();
					return;
				}

				if(!DBController.TryGetVehicleNumberPlates(out List<string> numberPlates))
				{
					Feedback.ErrorDatabaseLoadNumberPlates();
					return;
				}

				if (numberPlates.Contains(txtNumberplate.Text))
				{
					if(vehicleOld != null)
					{
						if (vehicleOld.NumberPlate != txtNumberplate.Text)
						{
							Feedback.ErrorNumberPlateAlreadyExist();
							return;
						}							
					}
					else
					{
						Feedback.ErrorNumberPlateAlreadyExist();
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
			if (string.IsNullOrWhiteSpace(txtNumberplate.Text))
			{
				Feedback.ErrorInvalidNumberPlate();
				return false;
			}

			if (string.IsNullOrWhiteSpace(txtMileage.Text))
			{
				Feedback.ErrorInvalidKM();
				return false;
			}

			if (string.IsNullOrWhiteSpace(txtTankFilling.Text))
			{
				Feedback.ErrorInvalidCurrentFuel();
				return false;
			}

			if (string.IsNullOrWhiteSpace(comboBrand.Text))
			{
				Feedback.ErrorInvalidBrand();
				return false;
			}

			if (string.IsNullOrWhiteSpace(txtModel.Text))
			{
				Feedback.ErrorInvalidModel();
				return false;
			}

			if (string.IsNullOrWhiteSpace(txtPower.Text))
			{
				Feedback.ErrorInvalidPower();
				return false;
			}

			if (string.IsNullOrWhiteSpace(comboGear.Text))
			{
				Feedback.ErrorInvalidShift();
				return false;
			}

			if (string.IsNullOrWhiteSpace(txtMaxTankFilling.Text))
			{
				Feedback.ErrorInvalidMaxFuel();
				return false;
			}

			if (string.IsNullOrWhiteSpace(txtPrice.Text))
			{
				Feedback.ErrorInvalidBasePrice();
				return false;
			}

			if (string.IsNullOrWhiteSpace(txtPriceKilo.Text))
			{
				Feedback.ErrorInvalidPricePerKm();
				return false;
			}

			if (string.IsNullOrWhiteSpace(txtPriceMin.Text))
			{
				Feedback.ErrorInvalidPricePerMin();
				return false;
			}

			if (string.IsNullOrWhiteSpace(txtPosX.Text))
			{
				Feedback.ErrorInvalidXCoord();
				return false;
			}

			if (string.IsNullOrWhiteSpace(txtPosY.Text))
			{
				Feedback.ErrorInvalidYCoord();
				return false;
			}
			return true;
		}
	}
}
