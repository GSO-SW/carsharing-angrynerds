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
	public partial class ManageUserForm : Form
	{
		public ManageUserForm()
		{
			InitializeComponent();

			customerListBox.Items.AddRange(DBController.GetAllCustomerFromDB().ToArray());
		}

		private void customerListBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (sender is ListBox)
			{
				if (((ListBox)sender).SelectedItem != null && ((ListBox)sender).SelectedItem is Customer)
				{
					Customer c = (Customer)((ListBox)sender).SelectedItem;

					nameLabel.Text = c.Name;
					lnameLabel.Text = c.LastName;
					emailLabel.Text = c.EmailAddress;
					telLabel.Text = c.PhoneNumber;
					birthDatePicker.Value = c.Birthday;
					streetLabel.Text = c.Street;
					houseNumberLabel.Text = c.HouseNumber;
					PLZlabel.Text = c.PLZ;
					cityLabel.Text = c.City;
					countryLabel.Text = c.Country;

					editButton.Enabled = true;
					//delButton.Enabled = true;
				}
				else
				{
					clearInformation();
				}
			}
		}

		private void editButton_Click(object sender, EventArgs e)
		{
			if (customerListBox.SelectedItem is Customer && customerListBox.SelectedItem != null)
			{
				UserRegistrationForm urf = new UserRegistrationForm((Customer)customerListBox.SelectedItem);
				urf.ShowDialog();

				int i = customerListBox.SelectedIndex;
				customerListBox.SelectedIndex = -1;
				customerListBox.Items.Clear();
				customerListBox.Items.AddRange(DBController.GetAllCustomerFromDB().ToArray());
				customerListBox.SelectedIndex = i;
			}
		}

		private void clearInformation()
		{
			nameLabel.Text = "";
			lnameLabel.Text = "";
			emailLabel.Text = "";
			telLabel.Text = "";
			birthDatePicker.Value = DateTime.Today;
			streetLabel.Text = "";
			houseNumberLabel.Text = "";
			PLZlabel.Text = "";
			cityLabel.Text = "";
			countryLabel.Text = "";

			editButton.Enabled = false;
			//delButton.Enabled = false;
		}
	}
}