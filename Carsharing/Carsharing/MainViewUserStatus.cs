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
	public partial class MainViewUserStatus : UserControl
	{
		public MainViewUserStatus()
		{
			InitializeComponent();
		}

		private void buttonUserEdit_Click(object sender, EventArgs e)
		{
			new EditDataView(FormController.CurrentCustomer).ShowDialog();
		}

		private void buttonUserDelete_Click(object sender, EventArgs e)
		{
			if (Feedback.AskOwnCustomerDelete() == DialogResult.Yes)
			{
				if (DBController.DeleteUserFromDB(FormController.CurrentCustomer))
				{
					Feedback.SuccessOwnCustomerDelete();
					FormController.MainView.Close();
				}
				else
				{
					Feedback.ErrorDatabaseCustomersDelete();
				}
			}
		}
	}
}
