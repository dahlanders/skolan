# Kundregister I

I denna och kommande uppgifter kommer du utveckla ett kundregister som ska administreras via en console-app.

Börja med att skapa en console-app och checka in den på github.

Skapa en databas med en tabell för ett kundregister där du kan lagra följande:
- Förnamn
- Efternamn
- Epost
- Telefonnummer

Skapa metoder för att CRUD-operationer alltså:
- Skapa en ny kund
- Ändra en kund
- Ta bort en kund
- Hämta alla kunder

Appen ska ha en meny där användaren göra ett val (skapa, ändra, ta bort, hämta) och sedan någon av operationerna ovan.

## Extra

1. Karma: hjälp en eller fler kollegor i minst 15 min

2. Se över dina metoder så de är korta och gör en sak. Se över namngivning på metoder och variabler.

3. Bryt ut dina metoder i lämpliga klasser. Skapa klasser som har ansvar för olika delar, t.ex:
  - Databas (läsa och skriva till databas)
  - Console (Console.Write, Console.Read etc)

4. Skapa ett testprojekt som testar dina metoder.

5. Lägg till två extra fält för kunder och uppdatera CRUD-metoderna.

6. Lägg till validering av alla kunduppgifter (förnamn, efternamn etc). Skriv först ner  giltiga/ogiltiga värden (ex giltiga och ogiltiga telefonnummer) och programmera sedan validering. Tips: använd reguljäruttryck

7. Lägg till en sökfunktion. Låt användaren välja vad han/hon vill söka på

8. Lägg tid på att snygga till GUI’t. Färger, typsnitt, radavstånd etc.

9. Om användaren trycker på en knapp så visa en hjälpassisten (tänk det populära gemet i gamla word) som ger stöd i hur programmet används.