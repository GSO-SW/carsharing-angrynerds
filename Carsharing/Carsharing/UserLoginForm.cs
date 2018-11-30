using System;
using System.Windows.Forms;

namespace Carsharing
{
	public partial class UserLoginForm : Form
	{
		/// <summary>
		/// Initialize new instance of this form.
		/// </summary>
		public UserLoginForm()
		{
			InitializeComponent();
		}

		private void loginButton_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(emailTextBox.Text) || !emailTextBox.Text.Contains("@") || !emailTextBox.Text.Contains("."))
			{
				MessageBox.Show("Bitte geben Sie eine gültige E-Mail-Adresse an.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (DBController.GetCustomerByEmailFromDB(emailTextBox.Text, out Customer c))
			{
				bool pwIncorrect = true;
				if (c != null)
				{
					if (SecurePasswordHasher.Verify(passwordTextBox.Text, c.PasswordHash))
					{
						FormController.CurrentCustomer = c;
						c = null;
						pwIncorrect = false;
						MessageBox.Show("Sie wurden erfolgreich angemeldet.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
						Close();
					}
				}
				if (pwIncorrect)
					MessageBox.Show("Der angegebene Nutzer konnte nicht gefunden werden oder das eingegebene Passwort ist nicht richtig.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				MessageBox.Show("Es ist ein Fehler beim Zugriff auf die Datenbank aufgetreten.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
