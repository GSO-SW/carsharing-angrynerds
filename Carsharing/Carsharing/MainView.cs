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
	public partial class MainView : Form
	{
		private Button[] selectableButtons;

		public MainView()
		{
			InitializeComponent();
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
					button.BackColor = Color.Transparent;
			}

			panelSelect.Top = clickedButton.Top;

			((UserControl)clickedButton.Tag).BringToFront();
		}
	}
}
