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
