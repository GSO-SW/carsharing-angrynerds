using System;
using System.Linq;
using System.Windows.Forms;

namespace Carsharing
{
	public partial class UserRegistrationForm : Form
	{
		private bool editMode;

		/// <summary>
		/// Create a new instance of this form.
		/// </summary>
		/// <param name="editMode">Determines if a new user will be created or the current User will be edited.</param>
		public UserRegistrationForm(bool editMode = false)
		{
			InitializeComponent();
			this.editMode = editMode;
			if (editMode && FormController.CurrentCustomer != null)
			{
				this.Text = "Bearbeiten";
				this.acceptButton.Text = "Ändern";

				this.nameTextBox.Text = FormController.CurrentCustomer.Name;
				this.lastNameTextBox.Text = FormController.CurrentCustomer.LastName;
				this.emailTextBox.Text = FormController.CurrentCustomer.EmailAddress;
				this.phoneTextBox.Text = FormController.CurrentCustomer.PhoneNumber;
				this.birthDatePicker.Value = FormController.CurrentCustomer.Birthday;
				this.passwordTextBox.Text = FormController.CurrentCustomer.Password;
				this.adminCheckBox.Checked = FormController.CurrentCustomer.IsAdmin;
				this.streetTextBox.Text = FormController.CurrentCustomer.Street;
				this.houseNumberTextBox.Text = FormController.CurrentCustomer.HouseNumber;
				this.PLZTextBox.Text = FormController.CurrentCustomer.PLZ;
				this.cityTextBox.Text = FormController.CurrentCustomer.City;
				this.countryTextBox.Text = FormController.CurrentCustomer.Country;
			}
		}

		private void acceptButton_Click(object sender, EventArgs e)
		{
			if (testForInvalidValues())
			{
				Customer c = new Customer(nameTextBox.Text, lastNameTextBox.Text, emailTextBox.Text, phoneTextBox.Text, passwordTextBox.Text, birthDatePicker.Value, streetTextBox.Text, houseNumberTextBox.Text, PLZTextBox.Text, cityTextBox.Text, countryTextBox.Text, adminCheckBox.Checked);
				if (editMode)
				{
					switch (DBController.UpdateCustomerInDB(c, FormController.CurrentCustomer.EmailAddress))
					{
						case 1:
							MessageBox.Show("Es ist ein Fehler mit der Datenbank aufgetreten.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
							break;
						case 2:
							MessageBox.Show("Es besteht bereits ein Kunde mit dieser E-Mail Adresse.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
							break;
						default:
							FormController.CurrentCustomer = c;
							MessageBox.Show("Ihre Daten wurden erfolgreich bearbeitet.", "Information", MessageBoxButtons.OK,MessageBoxIcon.Information);
							Close();
							break;
					}
				}
				else
				{
					switch (DBController.AddCustomerToDB(c))
					{
						case 1:
							MessageBox.Show("Es ist ein Fehler mit der Datenbank aufgetreten.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
							break;
						case 2:
							MessageBox.Show("Es besteht bereits ein Kunde mit dieser E-Mail Adresse.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
							break;
						default:
							MessageBox.Show("Der Kunde wurde erfolgreich registiert.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
							Close();
							break;
					}
				}
			}
		}

		private bool testForInvalidValues()
		{
			if (string.IsNullOrWhiteSpace(nameTextBox.Text))
			{
				MessageBox.Show("Bitte geben Sie ihren Vornamen an.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			if (string.IsNullOrWhiteSpace(lastNameTextBox.Text))
			{
				MessageBox.Show("Bitte geben Sie ihren Nachnamen an.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			if (string.IsNullOrWhiteSpace(emailTextBox.Text) || !emailTextBox.Text.Contains("@") || !emailTextBox.Text.Contains("."))
			{
				MessageBox.Show("Bitte geben Sie eine gültige E-Mail-Adresse an.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			if (string.IsNullOrWhiteSpace(phoneTextBox.Text) || !phoneTextBox.Text.Any(char.IsDigit)) //nur nummern?
			{
				MessageBox.Show("Bitte geben Sie eine gültige Telefonnummer an.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			if ((DateTime.Today.Date - birthDatePicker.Value.Date) < new TimeSpan(365 * 18, 6 * 18, 0, 0)) //min. Alter
			{
				MessageBox.Show("Sie müssen älter als 18 Jahre sein.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			if (passwordTextBox.Text.Length < 8)
			{
				MessageBox.Show("Bitte wählen Sie ein Passwort mit mindestens 8 Zeichen.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			if (string.IsNullOrWhiteSpace(streetTextBox.Text))
			{
				MessageBox.Show("Bitte geben Sie ihre Strasse an.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			if (string.IsNullOrWhiteSpace(houseNumberTextBox.Text))
			{
				MessageBox.Show("Bitte geben Sie ihre Hausnummer an.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			if (string.IsNullOrWhiteSpace(PLZTextBox.Text) || !PLZTextBox.Text.All(char.IsDigit))
			{
				MessageBox.Show("Bitte geben Sie eine gültige Postleitzahl an.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			if (string.IsNullOrWhiteSpace(cityTextBox.Text))
			{
				MessageBox.Show("Bitte geben Sie ihren Wohnort an.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			if (string.IsNullOrWhiteSpace(countryTextBox.Text))
			{
				MessageBox.Show("Bitte geben Sie ihr Heimatland an.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			return true;
		}
	}
}
