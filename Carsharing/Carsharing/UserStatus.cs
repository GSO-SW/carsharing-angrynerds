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
	public partial class UserStatus : UserControl
	{
		public UserStatus()
		{
			InitializeComponent();
		}

		private void UserStatus_Load(object sender, EventArgs e)
		{
			labelCustomer.Text = FormController.CurrentCustomer.LastName + ", " + FormController.CurrentCustomer.Name;
		}
	}
}
