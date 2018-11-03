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
	public partial class UserLoginView : Form
	{
		public UserLoginView()
		{
			InitializeComponent();
			txtEmail_Leave(null, null);
			txtPassword_Leave(null, null);

			ActiveControl = labelName;
		}

		private void buttonCancel_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void txtEmail_Enter(object sender, EventArgs e)
		{
			if(txtEmail.Text == "E-Mail Adresse")
			{
				txtEmail.ForeColor = Color.FromArgb(0, 0, 0);
				txtEmail.Text = null;
			}
		}

		private void txtEmail_Leave(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txtEmail.Text))
			{
				txtEmail.ForeColor = Color.FromArgb(73, 73, 73); 
				txtEmail.Text = "E-Mail Adresse";
			}
		}

		private void txtPassword_Enter(object sender, EventArgs e)
		{
			txtPassword.UseSystemPasswordChar = true;
			if (txtPassword.Text == "Passwort")
			{
				txtPassword.ForeColor = Color.FromArgb(0, 0, 0);
				txtPassword.Text = null;
			}
		}

		private void txtPassword_Leave(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txtPassword.Text))
			{
				txtPassword.UseSystemPasswordChar = false;
				txtPassword.ForeColor = Color.FromArgb(73, 73, 73);
				txtPassword.Text = "Passwort";
			}
		}

		private void buttonLogin_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txtEmail.Text) || !txtEmail.Text.Contains("@") || !txtEmail.Text.Contains("."))
			{
				MessageBox.Show("Bitte geben Sie eine gültige E-Mail-Adresse an.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (!DBController.ConnectionAvailable())
			{
				MessageBox.Show("Es konnte keine Verbindung zur Datenbank hergestellt werden.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			Customer c = DBController.GetCustomerByEmailFromDB(txtEmail.Text);
			bool pwIncorrect = true;
			if (c != null)
			{
				if (c.Password == txtPassword.Text)
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
	}
}
