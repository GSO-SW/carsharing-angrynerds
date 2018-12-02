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
	public partial class MainViewAdminUsers : UserControl
	{
		public MainViewAdminUsers()
		{
			InitializeComponent();
			UpdateTable();
		}

		private void buttonUserDelete_Click(object sender, EventArgs e)
		{
			if (listUser.SelectedItem is Customer)
			{
				Customer customer = (Customer)listUser.SelectedItem;

				if(customer.EmailAddress != FormController.CurrentCustomer.EmailAddress)
				{
					if (Feedback.AskCustomerDelete() == DialogResult.Yes)
					{
						if (DBController.DeleteUserFromDB(customer))
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
			if (listUser.SelectedItem is Customer)
			{
				Customer c = (Customer)listUser.SelectedItem;
				if(c.EmailAddress != FormController.CurrentCustomer.EmailAddress)
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

		private void listUser_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (listUser.SelectedItem is Customer)
			{
				Customer c = (Customer)listUser.SelectedItem;

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

		public void UpdateTable()
		{
			listUser.Items.Clear();
			Placeholer();
			if (!DBController.GetCustomers(out List<Customer> customers))
			{
				Feedback.ErrorDatabaseConnection();
				return;
			}
			listUser.Items.AddRange(customers.ToArray());
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
