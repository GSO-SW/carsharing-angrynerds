using System;
using System.Linq;
using System.Windows.Forms;

namespace Carsharing
{
	public partial class UserRegistrationForm : Form
	{
		public UserRegistrationForm()
		{
			InitializeComponent();
		}

		private void acceptButton_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(nameTextBox.Text))
			{
				MessageBox.Show("Bitte geben Sie ihren Vornamen an.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (string.IsNullOrWhiteSpace(lastNameTextBox.Text))
			{
				MessageBox.Show("Bitte geben Sie ihren Nachnamen an.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (string.IsNullOrWhiteSpace(emailTextBox.Text) || !emailTextBox.Text.Contains("@") || !emailTextBox.Text.Contains("."))
			{
				MessageBox.Show("Bitte geben Sie eine gültige E-Mail-Adresse an.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (string.IsNullOrWhiteSpace(phoneTextBox.Text) || !phoneTextBox.Text.Any(char.IsDigit)) //nur nummern?
			{
				MessageBox.Show("Bitte geben Sie eine gültige Telefonnummer an.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if ((DateTime.Today.Date - birthDatePicker.Value.Date) < new TimeSpan(365 * 18, 6 * 18, 0, 0)) //min. Alter
			{
				MessageBox.Show("Sie müssen älter als 18 Jahre sein.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (passwordTextBox.Text.Length < 8)
			{
				MessageBox.Show("Bitte wählen Sie ein Passwort mit mindestens 8 Zeichen.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (string.IsNullOrWhiteSpace(streetTextBox.Text))
			{
				MessageBox.Show("Bitte geben Sie ihre Straße an.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (string.IsNullOrWhiteSpace(houseNumberTextBox.Text))
			{
				MessageBox.Show("Bitte geben Sie ihre Hausnummer an.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (string.IsNullOrWhiteSpace(PLZTextBox.Text) || !PLZTextBox.Text.All(char.IsDigit))
			{
				MessageBox.Show("Bitte geben Sie eine gültige Postleitzahl an.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (string.IsNullOrWhiteSpace(cityTextBox.Text))
			{
				MessageBox.Show("Bitte geben Sie ihren Wohnort an.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (string.IsNullOrWhiteSpace(countryTextBox.Text))
			{
				MessageBox.Show("Bitte geben Sie ihr Heimatland an.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			Customer c = new Customer(nameTextBox.Text, lastNameTextBox.Text, emailTextBox.Text, phoneTextBox.Text, passwordTextBox.Text, birthDatePicker.Value, streetTextBox.Text, houseNumberTextBox.Text, PLZTextBox.Text, cityTextBox.Text, countryTextBox.Text, adminCheckBox.Checked);
			switch(DBController.AddCustomerToDB(c))
			{
				case 1:
					MessageBox.Show("Es ist ein Fehler mit der Datenbank aufgetreten.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
					break;
				case 2:
					MessageBox.Show("Es besteht bereits ein Kunde mit dieser E-Mail Adresse.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
					break;
				default:
					Close();
					break;
			}
		}
		
	}
}
