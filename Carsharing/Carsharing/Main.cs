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

		private void loginButton_Click(object sender, EventArgs e)
		{
			UserLoginForm usl = new UserLoginForm();
			usl.ShowDialog();
		}

        private void userDeleteButton_Click(object sender, EventArgs e)
        {
			if (FormController.CurrentCustomer != null)
			{
				// Show MessageBox to confirm the user's intention
				if (MessageBox.Show("Wollen Sie wirklich Ihren Account löschen?\nAll Ihre Daten gehen verloren.", "Achtung!", MessageBoxButtons.YesNo) == DialogResult.Yes)
				{
					// Delete the user here, by his email-address
					// If the deletion was not successful then show an error message
					if (!DBController.DeleteUserFromDB(FormController.CurrentCustomer))
					{
						MessageBox.Show("Es ist ein Fehler beim Zugriff zur Datenbank aufgetreten.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
					else //if the deletion was successful then delete the currentCustomer
					{
						FormController.CurrentCustomer = null;
						MessageBox.Show("Ihr Account wurde erfolgreich gelöscht. Sie wurden automatisch abgemeldet.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
				}
			}
			else
			{
				MessageBox.Show("Sie müssen sich anmelden, damit Sie ihren Account löschen können.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
        }

		private void editCustomerButton_Click(object sender, EventArgs e)
		{
			if (FormController.CurrentCustomer != null)
			{
				UserRegistrationForm urf = new UserRegistrationForm(FormController.CurrentCustomer);
				urf.ShowDialog();
			}
			else
			{
				MessageBox.Show("Sie müssen sich anmelden, damit Sie ihren Account bearbeiten können.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
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

		private void mangeCustomerButton_Click(object sender, EventArgs e)
		{
			if (FormController.CurrentCustomer != null && FormController.CurrentCustomer.IsAdmin)
			{
				// vorläufig neue form, aufdauer eher im main window
				ManageUserForm muf = new ManageUserForm();
				muf.ShowDialog();
			}
			else
				MessageBox.Show("Sie müssen als Admin angemeldet sein.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
	}
}