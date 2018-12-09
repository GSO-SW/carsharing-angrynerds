using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Carsharing
{
	internal partial class EditDataViewUser : UserControl
	{
		private Customer customerOld;

		internal EditDataViewUser(Customer c)
		{
			InitializeComponent();

			if (c != null)
			{
				customerOld = c;

				txtBirthDate.Text = c.Birthday.ToShortDateString();
				txtCity.Text = c.City;
				txtCountry.Text = c.Country;
				txtEmail.Text = c.EmailAddress;
				txtHouseNumber.Text = c.HouseNumber;
				txtLastName.Text = c.LastName;
				txtName.Text = c.Name;
				txtPhoneNumber.Text = c.PhoneNumber;
				txtPlz.Text = c.PLZ;
				txtStreet.Text = c.Street;

				checkAdmin.Checked = c.IsAdmin;
			}
			else
			{
				ParentForm.Close();
			}
		}

		private void buttonAccept_Click(object sender, EventArgs e)
		{
			if (testForInvalidValues())
			{
				Customer c = new Customer();

				c.Name = txtName.TextWithoutWatermark;
				c.LastName = txtLastName.TextWithoutWatermark;
				c.EmailAddress = txtEmail.TextWithoutWatermark;
				c.PhoneNumber = txtPhoneNumber.TextWithoutWatermark;
				c.PasswordHash = customerOld.PasswordHash;
				c.Birthday = DateTime.Parse(txtBirthDate.TextWithoutWatermark);
				c.Street = txtStreet.TextWithoutWatermark;
				c.HouseNumber = txtHouseNumber.TextWithoutWatermark;
				c.PLZ = txtPlz.TextWithoutWatermark;
				c.City = txtCity.TextWithoutWatermark;
				c.Country = txtCountry.TextWithoutWatermark;
				c.IsAdmin = checkAdmin.Checked;

				if (DBController.UpdateCustomerInDB(c, customerOld.EmailAddress) == 0)
				{
					FormController.MainView.UpdateCustomersList();
					Feedback.SuccessCustomersEdit();

					if (FormController.CurrentCustomer.EmailAddress == customerOld.EmailAddress)
					{
						FormController.CurrentCustomer = c;
					}
				}
				else
				{
					Feedback.ErrorDatabaseCustomersEdit();
				}

				ParentForm.Close();
			}
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
			if (!DBController.GetCustomers(out List<Customer> customers))
			{
				Feedback.ErrorDatabaseConnection();
				return false;
			}

			if (txtEmail.TextWithoutWatermark != customerOld.EmailAddress)
			{
				foreach (Customer c in customers)
				{
					if (txtEmail.TextWithoutWatermark == c.EmailAddress)
					{
						MessageBox.Show("Diese Email existiert bereits in der Datenbank.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
						return false;
					}
				}
			}
			return true;
		}
	}
}
