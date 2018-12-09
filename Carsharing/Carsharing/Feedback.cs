using System.Windows.Forms;

namespace Carsharing
{
	internal static class Feedback
	{
		private readonly static string titleError = "Fehler";
		private readonly static string titleCare = "Achtung";
		private readonly static string titleInformation = "Information";

		internal static void ErrorCustomerDeleteHimselfOpenBookings()
		{
			MessageBox.Show("Sie können ihren Account nicht löschen, während noch offene Buchungen vorhanden sind.", titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		internal static void ErrorNotAvailableVehicle()
		{
			MessageBox.Show("Buchung nicht erfolgreich, da das Fahrzeug nicht verfügbar ist.", titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		internal static void ErrorAlreadyOpenBooking()
		{
			MessageBox.Show("Buchung nicht erfolgreich, da Sie bereits eine offene Buchung haben.", titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		internal static void ErrorInvalidName()
		{
			MessageBox.Show("Bitte geben Sie ihren Vornamen an.", titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		internal static void ErrorInvaliLastdName()
		{
			MessageBox.Show("Bitte geben Sie ihren Nachnamen an.", titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		internal static void ErrorInvaliEmail()
		{
			MessageBox.Show("Bitte geben Sie eine gültige E-Mail-Adresse an.", titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		internal static void ErrorInvalidTel()
		{
			MessageBox.Show("Bitte geben Sie eine gültige Telefonnummer an.", titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		internal static void ErrorInvalidDate()
		{
			MessageBox.Show("Bitte geben sie ein gültiges Geburtsdatum ein.", titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		internal static void ErrorInvalidAge()
		{
			MessageBox.Show("Sie müssen älter als 18 Jahre sein.", titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		internal static void ErrorInvalidStreet()
		{
			MessageBox.Show("Bitte geben Sie ihre Straße an.", titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		internal static void ErrorInvalidHouseNumber()
		{
			MessageBox.Show("Bitte geben Sie ihre Hausnummer an.", titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		internal static void ErrorInvalidPLZ()
		{
			MessageBox.Show("Bitte geben Sie eine gültige Postleitzahl an.", titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		internal static void ErrorInvalidCity()
		{
			MessageBox.Show("Bitte geben Sie ihren Wohnort an.", titleError
, MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		internal static void ErrorInvalidCountry()
		{
			MessageBox.Show("Bitte geben Sie ihr Heimatland an.", titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		internal static void ErrorAlreadyExistingEmail()
		{
			MessageBox.Show("Diese Email existiert bereits in der Datenbank.", titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

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

		internal static void ErrorCustomersDeleteOpenBooking()
		{
			MessageBox.Show("Sie können diesen Kunden nicht löschen, da er noch offene Buchungen hat.", titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
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

		internal static void ErrorInvalidLogin()
		{
			MessageBox.Show("Die von dir eingegebene E-Mail-Adresse und/oder das von dir eingegebene Passwort kann keinem Konto zugeordnet werden.", titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
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

		internal static void SuccessOpenBooking()
		{
			MessageBox.Show("Buchung erfolgreich,", titleInformation, MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		internal static void ErrorInvalidNumberPlate()
		{
			MessageBox.Show("Bitte geben Sie das Kennzeichen des Fahrzeuges an.", titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		internal static void ErrorInvalidKM()
		{
			MessageBox.Show("Bitte geben Sie den aktuellen Kilometerstand des Fahrzeuges an, dieser kann auch 0 sein.", titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		internal static void ErrorInvalidCurrentFuel()
		{
			MessageBox.Show("Bitte geben Sie die Tankfüllung des Fahrzeuges an, diese kann auch 0 sein.", titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		internal static void ErrorInvalidBrand()
		{
			MessageBox.Show("Bitte geben Sie die Marke des Fahrzeuges an.", titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		internal static void ErrorInvalidModel()
		{
			MessageBox.Show("Bitte geben Sie das Modell des Fahrzeuges an.", titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		internal static void ErrorInvalidPower()
		{
			MessageBox.Show("Bitte geben Sie die Leistung des Fahrzeuges an.", titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		internal static void ErrorInvalidShift()
		{
			MessageBox.Show("Bitte geben Sie die Schaltart des Fahrzeuges an.", titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		internal static void ErrorInvalidMaxFuel()
		{
			MessageBox.Show("Bitte geben Sie die maximale Tankfüllung des Fahrzeuges an.", titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		internal static void ErrorInvalidBasePrice()
		{
			MessageBox.Show("Bitte geben Sie den Basispreises des Fahrzeuges an.", titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		internal static void ErrorInvalidPricePerKm()
		{
			MessageBox.Show("Bitte geben Sie den Preis pro Kilometer des Fahrzeuges an.", titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		internal static void ErrorInvalidPricePerMin()
		{
			MessageBox.Show("Bitte geben Sie den Preis pro Minute des Fahrzeuges an.", titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		internal static void ErrorInvalidXCoord()
		{
			MessageBox.Show("Bitte geben Sie die X-Koordinate des Fahrzeuges an.", titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		internal static void ErrorInvalidYCoord()
		{
			MessageBox.Show("Bitte geben Sie die Y-Koordinate des Fahrzeuges an.", titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
		}	
	}
}
