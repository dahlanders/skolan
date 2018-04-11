# Kundregister 2

Vi forts�tter med kundregistret.

L�gg till en **en-till-m�nga-relation** f�r kundregistret. Det kan t.ex vara:
- Varje kund kan ha 0, 1 eller flera telefonnummer (mobilnummer, fast nummer)
- Varje kund kan vara av olika typer (t.ex Potential, New, Discount, New)
- Varje kund kan tillh�ra 0, 1 eller flera projekt

Skapa CRUD-operationer f�r detta s� anv�ndaren kan administrera detta i console-appen.


## Extra

1. Karma: hj�lp en eller fler kollegor i minst 15 min

2. Se �ver dina metoder s� de �r korta och g�r en sak. Se �ver namngivning p� metoder och variabler.

3. Se �ver dina klasser s� de �r korta bara har ansvar f�r ett omr�de.

4. Uppdatera ditt testprojekt med fler testmetoder

5. Installera log4net eller nLog. L�gg till loggning. Logga alla CRUD-operationer, om det g�r bra eller d�ligt. T.ex om en kund har skapats eller om anv�ndaren matat in felaktigt format p� ett  telefonnummer.

6. Skapa en fil med sql-kommandon (textfil) som 
- tar bort databasen
- skapar en ny databas och tabeller
- fyller tabellerna med startv�rden

Skapa en metod som l�ser in textfilen och k�r sql-kommandona. L�t anv�ndaren kunna �terskapa databasen.

7. Ut�ka s�kfunktionen. L�t anv�ndaren kunna s�ka med fritext. S�k allts� p� alla f�lt (f�rnamn, epost, adress, telefonnummer�) och rangordna resultatet p� l�mpligt s�tt.

8. Om anv�ndaren vill ta bort en kund som har adresser kopplade till sig kan tv� saker h�nda:
a) programmet ger ett felmeddelande och tar inte bort n�got
b) programmet tar bort kunden och alla kopplade adresser

9. L�t programmets beteende vara konfigurerbart (t.ex i en fil)

10. L�t ditt program vara s�rbart f�r SQL-injection. Om anv�ndaren matar in ett f�rnamn: �kalle�); drop table Address; --� s� ska alla adresser raderas. I en konfigureringsfil anges om ditt program ska vara s�rbart eller ej.