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
	public partial class UserRegistrationForm : Form
	{
		public UserRegistrationForm()
		{
			InitializeComponent();
		}

		private void acceptButton_Click(object sender, EventArgs e)
		{
			if (nameTextBox.Text == string.Empty)
			{
				MessageBox.Show("Bitte geben Sie ihren Vornamen an.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (lastNameTextBox.Text == string.Empty)
			{
				MessageBox.Show("Bitte geben Sie ihren Nachnamen an.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (emailTextBox.Text == string.Empty || !emailTextBox.Text.Contains("@") || !emailTextBox.Text.Contains("."))
			{
				MessageBox.Show("Bitte geben Sie eine gültige E-Mail-Adresse an.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (phoneTextBox.Text == string.Empty || !phoneTextBox.Text.Any(char.IsDigit)) //nur nummern?
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
			if (streetTextBox.Text == string.Empty)
			{
				MessageBox.Show("Bitte geben Sie ihre Straße an.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (houseNumberTextBox.Text == string.Empty)
			{
				MessageBox.Show("Bitte geben Sie ihre Hausnummer an.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (PLZTextBox.Text == string.Empty || !PLZTextBox.Text.All(char.IsDigit))
			{
				MessageBox.Show("Bitte geben Sie eine gültige Postleitzahl an.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (cityTextBox.Text == string.Empty)
			{
				MessageBox.Show("Bitte geben Sie ihren Wohnort an.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (countryTextBox.Text == string.Empty)
			{
				MessageBox.Show("Bitte geben Sie ihr Heimatland an.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			Customer c = new Customer(nameTextBox.Text, lastNameTextBox.Text, emailTextBox.Text, phoneTextBox.Text, passwordTextBox.Text, birthDatePicker.Value, streetTextBox.Text, houseNumberTextBox.Text, PLZTextBox.Text, cityTextBox.Text, countryTextBox.Text, adminCheckBox.Checked);
			DBController.AddCustomerToDB(c);
			Close();
		}
	}
}
