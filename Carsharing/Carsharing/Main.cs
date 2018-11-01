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
		}

		private void userRegButton_Click(object sender, EventArgs e)
		{
			UserRegistrationForm urf = new UserRegistrationForm();
			urf.ShowDialog();
		}

        private void userDeleteButton_Click(object sender, EventArgs e)
        {
			
			if (FormController.CurrentCustomer != null)
			{
                // Check, whether the customer has open bookings before continuing
                if(DBController.CheckOpenBookings(FormController.CurrentCustomer))
                {
                    MessageBox.Show("Sie haben noch offene Buchungen, die Sie vorher beenden müssen, bevor Sie fortfahren können.", "Achtung!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

				// Show MessageBox to confirm the user's intention
				if (MessageBox.Show("Wollen Sie wirklich Ihren Account löschen?\nAll Ihre Daten gehen verloren.", "Achtung!", MessageBoxButtons.YesNo) == DialogResult.Yes)
				{
					// Delete the user here, by his email-address
					// If the deletion was not successful then show an error message
					if (!DBController.DeleteUserFromDB(FormController.CurrentCustomer))
					{
						MessageBox.Show("Es ist ein Fehler beim Zugriff zur Datenbank aufgetreten.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
			else
				MessageBox.Show("Sie müssen sich anmelden, damit Sie ihren Account löschen können.", "Fehler", MessageBoxButtons.OK,MessageBoxIcon.Error);
        }
    }
}