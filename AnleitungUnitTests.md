# Schritte zur Erstellung von Komponententests (Unit Tests)

## Anleitung
1. **zu testende Klasse vom Projekt als öffentlich deklarieren**
- Zum zu testenden Projekt navigieren
- Klasse auf public setzen z.B. `public class Konto`

2. **Neues Komponententestprojekt anlegen**
- Rechtsklick auf die Projektmappe
- Neues Projekt erstellen
- der Name variert je nach Projektname z.B. `"zu testendes Projekt" Test`

3.**Verweis auf zu testendes Projekt hinzufügen**
- Rechtsklick auf das erstellte Komponententestprojekt und dann auf `Verweis hinzufügen`

4.**Im Komponententestprojekt ein Using Direktive für den Namespace anlegen**
- Wird genutzt um den Code aus dem zu testenden Projekt zu nutzen z.B. Methoden, Konstruktor etc.

5.**Testmethoden implementieren**
- Für postiven Test wird nur `[TestMethod]` genutzt, für einen negativen `[TestMethod]` sowie `[ExpectedException(typeof(ArgumentOutOfRangeException))]`
- Es muss nach Arrange - Act - Assert Form gearbeitet werden

6.**Tests ausführen**
- Rechtsklick auf das Komponententestprojekt
- Auswählen vom `Tests Ausführen` Reiter