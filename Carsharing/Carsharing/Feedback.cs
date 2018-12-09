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
			MessageBox.Show("Bitte geben Sie ihren Wohnort an.", titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		internal static void ErrorInvalidCountry()
		{
			MessageBox.Show("Bitte geben Sie ihr Heimatland an.", titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		internal static void ErrorConvertMileage()
		{
			MessageBox.Show("Bitte überprüfen Sie ihre Eingabe beim Kilometerstand des Fahrzeuges.", titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		internal static void ErrorConvertTankFilling()
		{
			MessageBox.Show("Bitte überprüfen Sie ihre Eingabe bei der aktuellen Tankfüllung des Fahrzeuges.", titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		internal static void ErrorConvertPower()
		{
			MessageBox.Show("Bitte überprüfen Sie ihre Eingabe bei der Leistung des Fahrzeuges.", titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		internal static void ErrorConvertMaxTankFilling()
		{
			MessageBox.Show("Bitte überprüfen Sie ihre Eingabe bei maximalen Tankfüllung des Fahrzeuges.", titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		internal static void ErrorConvertBasicPrice()
		{
			MessageBox.Show("Bitte überprüfen Sie ihre Eingabe beim Basispreis des Fahrzeuges.", titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		internal static void ErrorConvertPriceKilo()
		{
			MessageBox.Show("Bitte überprüfen Sie ihre Eingabe beim Preis pro Kilometer des Fahrzeuges.", titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		internal static void ErrorConvertPriceMin()
		{
			MessageBox.Show("Bitte überprüfen Sie ihre Eingabe beim Preis pro Minute des Fahrzeuges.", titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		internal static void ErrorConvertLocationX()
		{
			MessageBox.Show("Bitte überprüfen Sie ihre Eingabe der X-Koordinate des Standortes des Fahrzeuges.", titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		internal static void ErrorConvertLocationY()
		{
			MessageBox.Show("Bitte überprüfen Sie ihre Eingabe der Y-Koordinate des Standortes des Fahrzeuges.", titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		internal static void ErrorConvertFuelCon()
		{
			MessageBox.Show("Bitte überprüfen Sie ihre Eingabe beim Kraftstoffverbrauch des Fahrzeuges.", titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		internal static void ErrorConvertRegi()
		{
			MessageBox.Show("Bitte überprüfen Sie ihre Eingabe bei der Erstzulassung des Fahrzeuges.", titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		internal static void ErrorConvertConstructionYear()
		{
			MessageBox.Show("Bitte überprüfen Sie ihre Eingabe beim Baujahr des Fahrzeuges.", titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		internal static void ErrorConvertSeats()
		{
			MessageBox.Show("Bitte überprüfen Sie ihre Eingabe beim der Sitzeanzahl des Fahrzeuges.", titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		internal static void ErrorPhysikTankFilling()
		{
			MessageBox.Show("Die aktuelle Tankfüllung kann nicht größer sein als die maximale Tankfüllung des Fahrzeuges.", titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		internal static void ErrorConstructionYearTooEarly()
		{
			MessageBox.Show("Bitte überprüfen Sie ihre Eingabe beim Baujahr des Fahrzeuges.", titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		internal static void ErrorConstructionYearTooLate()
		{
			MessageBox.Show("Das Baujahr des Fahrzeuges kann nicht in der Zukunft liegen.", titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		internal static void ErrorRegiBeforeConstruction()
		{
			MessageBox.Show("Das Erstzulassungsjahr kann nicht vor dem Baujahr sein.", titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		internal static void ErrorMaintanceBeforeConstruction()
		{
			MessageBox.Show("Die letzte Wartung kann nicht vor dem Baujahr sein.", titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		internal static void ErrorNumberPlateAlreadyExist()
		{
			MessageBox.Show("Das Kennzeichen des Fahrzeug existiert bereits.", titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
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

		internal static void ErrorDatabaseLoadNumberPlates()
		{
			MessageBox.Show("Bei dem Laden aller Kennzeichen ist ein Fehler aufgetreten.", titleError, MessageBoxButtons.OK, MessageBoxIcon.Error); ;
		}

		internal static void ErrorDatabaseLoadBrands()
		{
			MessageBox.Show("Bei dem Laden aller Fahrzeugmarken ist ein Fehler aufgetreten.\nSie werden zum Hauptfenster zurückgeleitet.", titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		internal static void ErrorDatabaseLoadGears()
		{
			MessageBox.Show("Bei dem Laden aller Getriebearten ist ein Fehler aufgetreten.", titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		internal static void ErrorDatabaseLoadFuels()
		{
			MessageBox.Show("Bei dem Laden aller Kraftstoffarten ist ein Fehler aufgetreten.", titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
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

		internal static void ErrorCustomerIsntLoggedIn()
		{
			MessageBox.Show("Sie sind nicht angemeldet.", titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		internal static void ErrorCustomerIsntAdmin()
		{
			MessageBox.Show("Sie sind nicht als Admin angemeldet.", titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
			MessageBox.Show("Beim Hinzufügen des Fahrzeuges ist ein Fehler unterlaufen.", titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		internal static void ErrorDatabaseVehicleEdit()
		{
			MessageBox.Show("Beim Bearbeiten des Fahrzeuges ist ein Fehler unterlaufen.", titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
	}
}
