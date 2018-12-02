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

			if (!DBController.GetAllCustomerFromDB(out List<Customer> customers))
			{
				MessageBox.Show("Es ist ein Fehler beim Zugriff auf die Datenbank aufgetreten.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
				Close();
			}
			customerListBox.Items.AddRange(customers.ToArray());
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
					delButton.Enabled = true;
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
				updateList();
			}
		}

		private void updateList()
		{
			int i = customerListBox.SelectedIndex;
			customerListBox.SelectedIndex = -1;
			customerListBox.Items.Clear();
			if (!DBController.GetAllCustomerFromDB(out List<Customer> customers))
			{
				MessageBox.Show("Es ist ein Fehler beim Zugriff auf die Datenbank aufgetreten.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
				Close();
				return;
			}
			customerListBox.Items.AddRange(customers.ToArray());
			if (customerListBox.Items.Count > i)
			{
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
			delButton.Enabled = false;
		}

		private void delButton_Click(object sender, EventArgs e)
		{
			if (customerListBox.SelectedItem is Customer && customerListBox.SelectedItem != null)
			{
				Customer c = (Customer)customerListBox.SelectedItem;
				// Check, whether the customer has open bookings before continuing
				if (FormController.CurrentCustomer == c)
				{
					MessageBox.Show("Bitte nutzen Sie zum löschen ihres eigenen Accounts den Knopf im Hauptmenü.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				if (!DBController.CheckOpenBookings(c, out bool openBookings))
				{
					MessageBox.Show("Es ist ein Fehler beim Zugriff auf die Datenbank aufgetreten.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				if (openBookings)
				{
					MessageBox.Show("Es sind noch offene Buchungen vorhanden.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}

				// Show MessageBox to confirm the user's intention
				if (MessageBox.Show("Wollen Sie diesen Account wirklich löschen?.", "Achtung", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					// Delete the user here, by his email-address
					// If the deletion was not successful then show an error message
					if (!DBController.DeleteUserFromDB(c))
					{
						MessageBox.Show("Es ist ein Fehler beim Zugriff zur Datenbank aufgetreten.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
					else //if the deletion was successful then delete the currentCustomer
					{
						MessageBox.Show("Der Account wurde erfolgreich gelöscht.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
				}

				updateList();
			}
		}
	}
}