using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Carsharing
{
	internal partial class MainViewAdminUsers : UserControl
	{
		internal MainViewAdminUsers()
		{
			InitializeComponent();
			UpdateTable();
		}

		private void buttonUserDelete_Click(object sender, EventArgs e)
		{
			if (listBoxUser.SelectedItem is Customer)
			{
				Customer customer = (Customer)listBoxUser.SelectedItem;

				if(customer.EmailAddress != FormController.CurrentCustomer.EmailAddress)
				{
					if (Feedback.AskCustomerDelete() == DialogResult.Yes)
					{
						if (DBController.TryDeleteUser(customer))
						{
							UpdateTable();
							Feedback.SuccessCustomersDelete();
						}
						else
						{
							Feedback.ErrorDatabaseCustomersDelete();
						}
					}
				}
				else
				{
					Feedback.ErrorCustomersDeleteHimself();
				}
			}
		}

		private void buttonUserEdit_Click(object sender, EventArgs e)
		{
			if (listBoxUser.SelectedItem is Customer)
			{
				Customer c = (Customer)listBoxUser.SelectedItem;
				if (c.EmailAddress != FormController.CurrentCustomer.EmailAddress)
				{
					new EditDataView(c).ShowDialog();
				}
				else
				{
					Feedback.ErrorCustomersEditHimself();
				}
			}
		}

		private void buttonRefresh_Click(object sender, EventArgs e)
		{
			UpdateTable();
		}

		private void listBoxUser_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (listBoxUser.SelectedItem is Customer)
			{
				Customer c = (Customer)listBoxUser.SelectedItem;

				txtBirth.Text = c.Birthday.ToShortDateString();
				txtCity.Text = c.City;
				txtCountry.Text = c.Country;
				txtEmail.Text = c.EmailAddress;
				txtHouse.Text = c.HouseNumber;
				txtLastname.Text = c.LastName;
				txtName.Text = c.Name;
				txtPhone.Text = c.PhoneNumber;
				txtPLZ.Text = c.PLZ;
				txtStreet.Text = c.Street;

				checkAdmin.Checked = c.IsAdmin;
			}
			else
			{
				Placeholer();
			}
		}

		internal void UpdateTable()
		{
			listBoxUser.Items.Clear();
			Placeholer();
			if (!DBController.TryGetAllCustomers(out List<Customer> customers))
			{
				Feedback.ErrorDatabaseConnection();
				return;
			}
			listBoxUser.Items.AddRange(customers.ToArray());
		}

		private void Placeholer()
		{
			txtBirth.Text = FormController.Placeholder;
			txtCity.Text = FormController.Placeholder;
			txtCountry.Text = FormController.Placeholder;
			txtEmail.Text = FormController.Placeholder;
			txtHouse.Text = FormController.Placeholder;
			txtLastname.Text = FormController.Placeholder;
			txtName.Text = FormController.Placeholder;
			txtPhone.Text = FormController.Placeholder;
			txtPLZ.Text = FormController.Placeholder;
			txtStreet.Text = FormController.Placeholder;

			checkAdmin.Checked = false;
		}
	}
}
