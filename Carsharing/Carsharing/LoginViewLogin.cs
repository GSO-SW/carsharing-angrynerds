using System;
using System.Windows.Forms;

namespace Carsharing
{
	internal partial class LoginViewLogin : UserControl
	{
		internal LoginViewLogin()
		{
			InitializeComponent();
		}

		private void buttonLogin_Click(object sender, EventArgs e)
		{
			login();
		}

		private void buttonRegister_Click(object sender, EventArgs e)
		{
			FormController.StartView.State = LoginView.StartState.Registration;
		}

		private void txt_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				login();
				e.Handled = true;
			}
			else if (e.KeyCode == Keys.Escape)
			{
				FormController.StartView.Close();
				e.Handled = true;
			}
		}
		
		private void LoginViewLogin_Load(object sender, EventArgs e)
		{
			ActiveControl = buttonLogin;
		}

		internal void Renew()
		{
			foreach (Control item in Controls)
			{
				if (item is CustomControl.WatermarkTextBox)
					((CustomControl.WatermarkTextBox)item).ResetToWatermark();
			}
		}

		private void login()
		{
			if (!DBController.ConnectionAvailable())
			{
				MessageBox.Show("Es konnte keine Verbindung zur Datenbank hergestellt werden.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (DBController.GetCustomerByEmailFromDB(txtEmail.Text, out Customer c))
			{

			}

			if (c != null)
			{
				if (SecurePasswordHasher.Verify(txtPassword.Text, c.PasswordHash))
				{
					FormController.CurrentCustomer = c;
					c = null;
					//MessageBox.Show("Sie wurden erfolgreich angemeldet.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
					FormController.StartView.Close();
					System.Media.SystemSounds.Asterisk.Play();
					return;
				}
			}
			MessageBox.Show("Die von dir eingegebene E-Mail-Adresse und/oder das von dir eingegebene Passwort kann keinem Konto zugeordnet werden.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
	}
}
