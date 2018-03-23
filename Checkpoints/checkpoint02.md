
# Checkpoint02 - Rum

## Intro

Skapa en consoleapp med projektnamnet *Checkpoint02*. Skapa en mapp i projektet som du d�per till ditt namn, t.ex *OscarOlsson*. I den mappen skapa en klass *App.cs*.

L�mna in hela mappen (t.ex *OscarOlsson*) alternativt bara *App.cs*-filen.

L�mna bara in en version. Du kan b�rja direkt p� version 2 eller 3 om du vill och skippa tidigare versioner.


## Level 1

Anv�ndaren matar in exakt **tre** rum. Pipetecknet anv�nds som separator.

Skriv en Room-klass och skapa tre rum:

    var r1 = new Room("...")
    var r2 = new Room("...")
    var r3 = new Room("...")

Skriv sedan utan rummens namn:

![](img/checkpoint02_1.png)



## Level 2

Anv�ndaren matar in rumsnamn tillsammans med storlek p� rummet. Storleken anges med en siffra samt texten "m2". Se nedan.

Skriv ut rummen och skriv �ven ut vilket rum som �r st�rst samt dess storlek.

![](img/checkpoint02_2.png)


## Level 3

Anv�ndaren skriver nu rum i detta format:

    Rumsnamn Kvadratmeter LjusetP�EllerEj

T.ex

    Salong 15m2 On

Ljuset i ett rum �r antingen p� eller av: **On** eller **Off**.

Validera anv�ndarens input. Ge meddelande om anv�ndaren matar in p� fel format. Upprepa i all evighet.

N�r anv�ndaren matar in r�tt input s� skriv ut:
- Vilka rum som �r t�nda (om n�got) 
- Vilket rum som �r st�rst 
- Hur m�nga rum som har angivits

Se nedan f�r hur datan ska presenteras.

![](img/checkpoint02_3.png)

## Level 4

Snygga till koden. 

Se �ver namn p� variabler och metoder. Fixa f�r l�nga metoder.

F�rs�k g�ra koden s� l�ttl�st som m�jligt.

Bryt ut Console-delen s� det �r l�tt att testa dina klasser och metoder.