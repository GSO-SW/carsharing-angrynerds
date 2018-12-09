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
				Feedback.ErrorInvalidName();
				return false;
			}
			if (string.IsNullOrWhiteSpace(txtLastName.TextWithoutWatermark))
			{
				Feedback.ErrorInvaliLastdName();
				return false;
			}
			if (string.IsNullOrWhiteSpace(txtEmail.TextWithoutWatermark) || !txtEmail.TextWithoutWatermark.Contains("@") || !txtEmail.TextWithoutWatermark.Contains("."))
			{
				Feedback.ErrorInvaliEmail();
				return false;
			}
			if (string.IsNullOrWhiteSpace(txtPhoneNumber.TextWithoutWatermark) || !txtPhoneNumber.TextWithoutWatermark.Any(char.IsDigit))
			{
				Feedback.ErrorInvalidTel();
				return false;
			}
			if (!DateTime.TryParse(txtBirthDate.TextWithoutWatermark, out DateTime birthDate))
			{
				Feedback.ErrorInvalidDate();
				return false;
			}
			if ((DateTime.Today.Date - birthDate.Date) < new TimeSpan(365 * 18, 6 * 18, 0, 0))//min. Alter
			{
				Feedback.ErrorInvalidAge();
				return false;
			}
			if (string.IsNullOrWhiteSpace(txtStreet.TextWithoutWatermark))
			{
				Feedback.ErrorInvalidStreet();
				return false;
			}
			if (string.IsNullOrWhiteSpace(txtHouseNumber.TextWithoutWatermark))
			{
				Feedback.ErrorInvalidHouseNumber();
				return false;
			}
			if (string.IsNullOrWhiteSpace(txtPlz.TextWithoutWatermark) || !txtPlz.TextWithoutWatermark.All(char.IsDigit))
			{
				Feedback.ErrorInvalidPLZ();
				return false;
			}
			if (string.IsNullOrWhiteSpace(txtCity.TextWithoutWatermark))
			{
				Feedback.ErrorInvalidCity();
				return false;
			}
			if (string.IsNullOrWhiteSpace(txtCountry.TextWithoutWatermark))
			{
				Feedback.ErrorInvalidCountry();
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
						Feedback.ErrorAlreadyExistingEmail();
						return false;
					}
				}
			}
			return true;
		}
	}
}
