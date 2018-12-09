# Carsharing-Agrynerds
## Schwierigkeiten
### Musterabgleich
In VS 2015 funktioniert folgende Syntax nicht:
```
if (object obj is Type T t)
 {
    //some code here
 }
```
und muss durch
```
if (object obj is Type T)
 {
    T t = (T)obj;
 }
```
ersetzt werden.

### Download
Wenn das Projekt als ZIP-Archiv heruntergeladen wird, blockiert Windows .resx-Dateien.
Diese müssen manuell zugelassen werden.
(Rechtsklick auf die Datei -> Eigenschaften -> Zulassen)
Wenn das Projekt geklont wird, tritt der Fehler nicht auf.

## Programmanleitung
### Anmeldung/Registrierung
Der Programmstart setzt eine Datenbankverbindung voraus. Wenn diese nicht verfügbar, wird eine Fehlermeldung
ausgegeben und das Programm schließt sich.

Im Anmeldefenster hat man die Möglichkeit sich mit einem vorhandenen Account anzumelden (Anmelden-Button).
Es existiert ein mitgelieferter Account mit Adminrechten (E-Mail: admin@system.de Passwort: admin123).

Falls ein neuer User einen Account erstellen möchte, kann er das in der Registierungs-Form machen (Registrieren-Button).

### Hauptfenster
Im Hauptfenster befinden sich an der linken Seite die einzelnen Reiter der Features des Programms.
Durch klicken der einzelnen Reiter wechselt man zwischen diesen.

Insgesamt gibt es folgende Reiter: "Status" und "Buchung".
Ein Account mit Adminrechten verfügt exklusiv noch über die Reiter "Fuhrpark" und "Nutzer".

### Status
In diesen Reiter kann der Nutzer sich über alle vergangenen getätigten Buchungen informieren.
Eine offene Buchung kann hier ausgewählt werden und nach der Eintragung des Endkilometerstands beendet werden (Buchung beenden-Button).

Ebenfalls kann der Nutzer seine Account Informationen (Profil bearbeiten-Button) und sein Account löschen (Profil löschen-Button).

### Buchung
Im "Buchung" Reiter kann der Nutzer ein Fahrzeug buchen.
Alle verfügbaren Fahrzeuge werden hier aufgeführt, aus denen der Nutzer wählen kann.
Anschließend kann der Nutzer das ausgesuchte Fahrzeug buchen (Fahrzeug buchen-Button).
Der Nutzer kann immer nur eine Buchung gleichzeitig offen haben.

### Fuhrpark (Admin exklusiv)
In diesen Reiter kann ein Admin neue Fahrzeuge hinzufügen (Fahrzeug hinzufügen-Button), bearbeiten (Fahrzeug bearbeiten-Button) und löschen (Fahrzeug löschen-Button).
Es ist zu beachten, dass Fahrzeuge, die sich in einer offenen Buchung befinden, nicht gelöscht oder bearbeitet werden können.

### Nutzer (Admin exklusiv)
In diesen Reiter kann ein Admin alle registrierten Nutzer einsehen und bearbeiten.
Man kann diese bearbeiten (Nutzer bearbeiten-Button) und löschen (Nutzer löschen-Button), wobei man keine Nutzer löschen
kann, die eine offene Buchung haben.
