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
		public MainView()
		{
			InitializeComponent();
		}

		private void buttonCancel_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void buttonStatus_Click(object sender, EventArgs e)
		{
			panelSelect.Top = buttonStatus.Top;
		}

		private void buttonBooking_Click(object sender, EventArgs e)
		{
			panelSelect.Top = buttonBooking.Top;
		}

		private void buttonVehicles_Click(object sender, EventArgs e)
		{
			panelSelect.Top = buttonVehicles.Top;
		}

		private void buttonUsers_Click(object sender, EventArgs e)
		{
			panelSelect.Top = buttonUsers.Top;
		}

		private void buttonBookings_Click(object sender, EventArgs e)
		{
			panelSelect.Top = buttonBookings.Top;
		}
	}
}
