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

		public void UpdateTable()
		{
			DBController.GetCustomers(out List<Customer> c);
			dataGridView1.DataSource = c;
		}

		private void buttonUserDelete_Click(object sender, EventArgs e)
		{
			DialogResult dialog = MessageBox.Show("Möchten Sie diesen Account wirklich löschen?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if(dialog == DialogResult.Yes)
			{
				int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
				DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
				string email = Convert.ToString(selectedRow.Cells[2].Value);
				DBController.DeleteUserFromDB(DBController.GetCustomerByEmailFromDB(email));
				UpdateTable();
			}
		}
	}
}
