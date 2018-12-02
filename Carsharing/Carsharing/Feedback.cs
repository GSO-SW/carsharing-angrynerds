﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carsharing
{
	internal static class Feedback
	{
		private static string titleError = "Fehler";
		private static string titleCare = "Achtung";
		private static string titleInformation = "Information";

		internal static void ErrorDatabaseConnection()
		{
			MessageBox.Show("Bei der Verbindung zur Datenbank ist ein Fehler aufgetreten.", titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		internal static void ErrorDatabaseCustomersDelete()
		{
			MessageBox.Show("Bei dem Versuch den Nutzer zu Löschen ist ein Fehler ausgetreten", titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		internal static void ErrorDatabaseCustomersEdit()
		{
			MessageBox.Show("Bei dem Versuch den Nutzer zu Bearbeiten ist ein Fehler ausgetreten", titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		internal static void ErrorCustomersDeleteHimself()
		{
			MessageBox.Show("Sie können sich nicht selbst auf diese Art löschen.\nSie müssen dies unter dem Menü 'Status' tun.", titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		internal static void ErrorCustomersEditHimself()
		{
			MessageBox.Show("Sie können sich nicht selbst auf diese Art bearbeiten.\nSie müssen dies unter dem Menü 'Status' tun.", titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		internal static DialogResult AskCustomerDelete()
		{
			DialogResult dialogResult = MessageBox.Show("Wollen Sie wirklich diesen Account löschen?", titleCare, MessageBoxButtons.YesNo);
			return dialogResult;
		}

		internal static void SuccessCustomersDelete()
		{
			MessageBox.Show("Der Account wurde erfolgreich gelöscht.", titleInformation, MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		internal static void SuccessCustomersEdit()
		{
			MessageBox.Show("Der Account wurde erfolgreich bearbeitet.", titleInformation, MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
	}
}