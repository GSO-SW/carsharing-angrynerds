using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carsharing
{
	internal static class Feedback
	{
		private readonly static string titleError = "Fehler";
		private readonly static string titleCare = "Achtung";
		private readonly static string titleInformation = "Information";

		internal static void ErrorDatabaseConnection()
		{
			MessageBox.Show("Bei der Verbindung zur Datenbank ist ein Fehler aufgetreten.", titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		internal static void ErrorNoSelectedItem()
		{
			MessageBox.Show("Sie haben keine Auswahl getroffen.", titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		internal static void ErrorNoValidSelectedItem()
		{
			MessageBox.Show("Sie haben keine gültige Auswahl getroffen.", titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		internal static void ErrorDatabaseCustomersDelete()
		{
			MessageBox.Show("Bei dem Versuch den Nutzer zu Löschen ist ein Fehler ausgetreten.", titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		internal static void ErrorDatabaseCustomersEdit()
		{
			MessageBox.Show("Bei dem Versuch den Nutzer zu Bearbeiten ist ein Fehler ausgetreten.", titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		internal static void ErrorCustomersDeleteHimself()
		{
			MessageBox.Show("Sie können sich nicht selbst auf diese Art löschen.\nSie müssen dies unter dem Menü 'Status' tun.", titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		internal static void ErrorCustomersEditHimself()
		{
			MessageBox.Show("Sie können sich nicht selbst auf diese Art bearbeiten.\nSie müssen dies unter dem Menü 'Status' tun.", titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		internal static void ErrorDatabaseVehicleAdd()
		{
			MessageBox.Show("Beim Hinzufügen des Fahrzeuges ist ein Fehler unterlaufen.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		internal static void ErrorDatabaseVehicleEdit()
		{
			MessageBox.Show("Beim Bearbeiten des Fahrzeuges ist ein Fehler unterlaufen.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

        internal static void ErrorDatabaseVehicleDelete()
		{
			MessageBox.Show("Bei dem Versuch das Fahrzeug zu Löschen ist ein Fehler aufgetreten.", titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		internal static void ErrorDatabaseBookedVehicleDelete()
		{
			MessageBox.Show("Sie können dieses Fahrzeug nicht löschen, da dies gebucht ist.", titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

        internal static void ErrorDatabaseBookedVehicleEdit()
        {
            MessageBox.Show("Sie können dieses Fahrzeug nicht bearbeiten, da dies gebucht ist.", titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        internal static void ErrorDatabaseVehicleTypeDelete()
		{
			MessageBox.Show("Bei dem Versuch den Fahrzeugtyp zu Löschen ist ein Fehler aufgetreten.", titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

        internal static void ErrorInvalidEndMileageInput()
        {
            MessageBox.Show("Ihre Eingabe ist ungültig.\nVergewissern Sie sich, dass ihre Eingabe größer als der Startkilometerstand ist.", titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

		internal static DialogResult AskCustomerDelete()
		{
			return MessageBox.Show("Wollen Sie wirklich diesen Account löschen?", titleCare, MessageBoxButtons.YesNo);
		}

		internal static DialogResult AskVehicleDelete()
		{
			return MessageBox.Show("Wollen Sie wirklich dieses Fahrzeug löschen?", titleCare, MessageBoxButtons.YesNo);
		}

		internal static DialogResult AskOwnCustomerDelete()
		{
			return MessageBox.Show("Wollen Sie wirklich Ihren Account löschen?", titleCare, MessageBoxButtons.YesNo);
		}

		internal static void SuccessCustomersDelete()
		{
			MessageBox.Show("Der Account wurde erfolgreich gelöscht.", titleInformation, MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		internal static void SuccessOwnCustomerDelete()
		{
			MessageBox.Show("Ihr Account wurde erfolgreich gelöscht.\nSie werden nun abgemeldet.", titleInformation, MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		internal static void SuccessCustomersEdit()
		{
			MessageBox.Show("Der Account wurde erfolgreich bearbeitet.", titleInformation, MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		internal static void SuccessVehicleAdd()
		{
			MessageBox.Show("Das Fahrzeug wurde hinzugefügt.", titleInformation, MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		internal static void SuccessVehicleEdit()
		{
			MessageBox.Show("Das Fahrzeug wurde bearbeitet.", titleInformation, MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		internal static void SuccessVehicleDelete()
		{
			MessageBox.Show("Der Fahrzeug wurde erfolgreich gelöscht.", titleInformation, MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

        internal static void SuccessCloseBooking(double totalCost)
        {
            MessageBox.Show("Die Buchung wurde erfolgreich beendet.\nDie Gesamtkosten betragen " + totalCost.ToString("F2") + " €.", titleInformation, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
