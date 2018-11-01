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
		List<Customer> customers;

		public ManageUserForm()
		{
			InitializeComponent();
			DoubleBuffered = true;

			customerListBox.Items.AddRange(DBController.GetAllCustomerFromDB().ToArray());
			customerListBox.DisplayMember = "EmailAddress";
		}

		private void customerListBox_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
	}
}
