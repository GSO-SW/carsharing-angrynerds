using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carsharing
{
	public partial class AccountRegistration : UserControl
	{
		public AccountRegistration()
		{
			InitializeComponent();
		}

		private void buttonRegistration_Click(object sender, EventArgs e)
		{
			if (testForInvalidValues())
			{
				Customer c = new Customer(txtName.TextWithoutWatermark, txtLastName.TextWithoutWatermark, txtEmail.TextWithoutWatermark, txtPhoneNumber.TextWithoutWatermark, txtPassword.TextWithoutWatermark, DateTime.Parse(txtBirthDate.TextWithoutWatermark), txtStreet.TextWithoutWatermark, txtHouseNumber.TextWithoutWatermark, txtPlz.TextWithoutWatermark, txtCity.TextWithoutWatermark, txtCountry.TextWithoutWatermark, false);

				switch (DBController.AddCustomerToDB(c))
				{
					case 1:
						MessageBox.Show("Es ist ein Fehler mit der Datenbank aufgetreten.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
						break;
					case 2:
						MessageBox.Show("Es besteht bereits ein Kunde mit dieser E-Mail Adresse.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
						break;
					default:
						MessageBox.Show("Sie wurden erfolgreich registriert.\nSie können sich nun anmelden.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
						FormController.StartView.State = UserStartView.StartState.Login;
						break;
				}
			}
		}

		private void buttonCancel_Click(object sender, EventArgs e)
		{
			foreach (Control item in Controls)
			{
				if (item is CustomControl.WatermarkTextBox)
					if (!string.IsNullOrWhiteSpace(((CustomControl.WatermarkTextBox)item).TextWithoutWatermark))
					{
						if (DialogResult.Yes != MessageBox.Show("Möchten Sie Ihre Eingabe verwerfen?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
							return;
						break;
					}										
			}
			FormController.StartView.State = UserStartView.StartState.Login;
		}

		private bool testForInvalidValues()
		{
			if (string.IsNullOrWhiteSpace(txtName.TextWithoutWatermark))
			{
				MessageBox.Show("Bitte geben Sie ihren Vornamen an.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			if (string.IsNullOrWhiteSpace(txtLastName.TextWithoutWatermark))
			{
				MessageBox.Show("Bitte geben Sie ihren Nachnamen an.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			if (string.IsNullOrWhiteSpace(txtEmail.TextWithoutWatermark) || !txtEmail.TextWithoutWatermark.Contains("@") || !txtEmail.TextWithoutWatermark.Contains("."))
			{
				MessageBox.Show("Bitte geben Sie eine gültige E-Mail-Adresse an.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			if (txtPassword.TextWithoutWatermark != txtPassword2.TextWithoutWatermark)
			{
				MessageBox.Show("Die Passwörter stimmen nicht überein.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			if (txtPassword.TextWithoutWatermark.Length < 8)
			{
				MessageBox.Show("Bitte wählen Sie ein Passwort mit mindestens 8 Zeichen.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			if (string.IsNullOrWhiteSpace(txtPhoneNumber.TextWithoutWatermark) || !txtPhoneNumber.TextWithoutWatermark.Any(char.IsDigit)) //nur nummern?
			{
				MessageBox.Show("Bitte geben Sie eine gültige Telefonnummer an.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			if (!DateTime.TryParse(txtBirthDate.TextWithoutWatermark, out DateTime birthDate)) 
			{
				MessageBox.Show("Bitte geben sie ein gültiges Geburtsdatum ein.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			if ((DateTime.Today.Date - birthDate.Date) < new TimeSpan(365 * 18, 6 * 18, 0, 0))//min. Alter
			{
				MessageBox.Show("Sie müssen älter als 18 Jahre sein.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			if (string.IsNullOrWhiteSpace(txtStreet.TextWithoutWatermark))
			{
				MessageBox.Show("Bitte geben Sie ihre Straße an.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			if (string.IsNullOrWhiteSpace(txtHouseNumber.TextWithoutWatermark))
			{
				MessageBox.Show("Bitte geben Sie ihre Hausnummer an.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			if (string.IsNullOrWhiteSpace(txtPlz.TextWithoutWatermark) || !txtPlz.TextWithoutWatermark.All(char.IsDigit))
			{
				MessageBox.Show("Bitte geben Sie eine gültige Postleitzahl an.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			if (string.IsNullOrWhiteSpace(txtCity.TextWithoutWatermark))
			{
				MessageBox.Show("Bitte geben Sie ihren Wohnort an.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			if (string.IsNullOrWhiteSpace(txtCountry.TextWithoutWatermark))
			{
				MessageBox.Show("Bitte geben Sie ihr Heimatland an.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			return true;
		}

		public void Renew()
		{
			foreach (Control item in Controls)
			{
				if (item is CustomControl.WatermarkTextBox)
					((CustomControl.WatermarkTextBox)item).ResetToWatermark();
			}
		}
	}
}
