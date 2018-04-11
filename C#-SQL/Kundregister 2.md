# Kundregister 2

Vi fortsätter med kundregistret.

Lägg till en **en-till-många-relation** för kundregistret. Det kan t.ex vara:
- Varje kund kan ha 0, 1 eller flera telefonnummer (mobilnummer, fast nummer)
- Varje kund kan vara av olika typer (t.ex Potential, New, Discount, New)
- Varje kund kan tillhöra 0, 1 eller flera projekt

Skapa CRUD-operationer för detta så användaren kan administrera detta i console-appen.


## Extra

1. Karma: hjälp en eller fler kollegor i minst 15 min

2. Se över dina metoder så de är korta och gör en sak. Se över namngivning på metoder och variabler.

3. Se över dina klasser så de är korta bara har ansvar för ett område.

4. Uppdatera ditt testprojekt med fler testmetoder

5. Installera log4net eller nLog. Lägg till loggning. Logga alla CRUD-operationer, om det går bra eller dåligt. T.ex om en kund har skapats eller om användaren matat in felaktigt format på ett  telefonnummer.

6. Skapa en fil med sql-kommandon (textfil) som 
- tar bort databasen
- skapar en ny databas och tabeller
- fyller tabellerna med startvärden

Skapa en metod som läser in textfilen och kör sql-kommandona. Låt användaren kunna återskapa databasen.

7. Utöka sökfunktionen. Låt användaren kunna söka med fritext. Sök alltså på alla fält (förnamn, epost, adress, telefonnummer…) och rangordna resultatet på lämpligt sätt.

8. Om användaren vill ta bort en kund som har adresser kopplade till sig kan två saker hända:
a) programmet ger ett felmeddelande och tar inte bort något
b) programmet tar bort kunden och alla kopplade adresser

9. Låt programmets beteende vara konfigurerbart (t.ex i en fil)

10. Låt ditt program vara sårbart för SQL-injection. Om användaren matar in ett förnamn: “kalle’); drop table Address; --” så ska alla adresser raderas. I en konfigureringsfil anges om ditt program ska vara sårbart eller ej.