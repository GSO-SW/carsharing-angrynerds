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
	public partial class Main : Form
	{
		public Main()
		{
			InitializeComponent();
			FormController.CurrentCustomer = new Customer();
			FormController.CurrentCustomer.IsAdmin = true;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if(FormController.CurrentCustomer == null)
			{
				MessageBox.Show("Sie sind nicht angemeldet.\nSie werden zum Hauptfenster zurückgeleitet.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				if (FormController.CurrentCustomer.IsAdmin)
				{
					new AddVehicleForm().ShowDialog();
				}
				else
				{
					MessageBox.Show("Sie sind nicht als Admin angemeldet.\nSie werden zum Hauptfenster zurückgeleitet.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			
		}
	}
}