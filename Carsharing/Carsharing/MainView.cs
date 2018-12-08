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
	internal partial class MainView : Form
	{
		private Button[] selectableButtons;

		internal MainView()
		{
			InitializeComponent();
			DoubleBuffered = true;

			FormController.MainView = this;
		}

		private void MainView_Load(object sender, EventArgs e)
		{
			if (FormController.CurrentCustomer.IsAdmin) //admin
			{
				selectableButtons = new Button[] { buttonStatus, buttonBooking, buttonVehicles, buttonUsers, buttonBookings };
			}
			else //user
			{
				selectableButtons = new Button[] { buttonStatus, buttonBooking };
				buttonVehicles.Visible = false;
				buttonUsers.Visible = false;
				buttonBookings.Visible = false;
			}
		}

		private void buttonCancel_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void buttonStatus_Click(object sender, EventArgs e)
		{
			Button clickedButton = (Button)sender;

			foreach (Button button in selectableButtons)
			{
				if (button == clickedButton)
					button.BackColor = Color.FromArgb(255, 40, 72);
				else
					button.BackColor = Color.FromArgb(255, 61, 90);
			}

			panelSelect.Top = clickedButton.Top;

			((UserControl)clickedButton.Tag).BringToFront();
            // Updates form after switching between them
            if (((UserControl)clickedButton.Tag) is MainViewUserStatus)
                ((MainViewUserStatus)clickedButton.Tag).UpdateForm();

            if (((UserControl)clickedButton.Tag) is MainViewUserBooking)
                ((MainViewUserBooking)clickedButton.Tag).UpdateForm();

            if (((UserControl)clickedButton.Tag) is MainViewAdminVehicle)
                ((MainViewAdminVehicle)clickedButton.Tag).UpdateTable();

            if (((UserControl)clickedButton.Tag) is MainViewAdminUsers)
                ((MainViewAdminUsers)clickedButton.Tag).UpdateTable();

        }

		internal void UpdateVehicleList()
		{
			adminVehicles1.UpdateTable();
			userBooking1.UpdateTable();
		}

		internal void UpdateCustomersList()
		{
			adminUsers1.UpdateTable();
		}
	}
}
