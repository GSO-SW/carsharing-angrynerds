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
	public partial class AccountLogin : UserControl
	{
		public AccountLogin()
		{
			InitializeComponent();
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
					FormController.StartView.Close();
				}
			}
			if (pwIncorrect)
				MessageBox.Show("Der angegebene Nutzer konnte nicht gefunden werden oder das eingegebene Passwort ist nicht richtig.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		private void buttonRegister_Click(object sender, EventArgs e)
		{
			FormController.StartView.State = UserStartView.StartState.Registration;
		}

		public void Renew()
		{
			foreach (Control item in Controls)
			{
				if (item is CustomControl.WatermarkTextBox)
					((CustomControl.WatermarkTextBox)item).ResetToWatermark();
			}
		}
	}
}
