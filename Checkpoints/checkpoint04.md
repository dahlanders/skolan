
# Checkpoint04 - Tomtar

## Intro

L�mna in **en** cs-fil med din programkod. 

(Om du skapar flera klasser s� l�gg allts� klasserna i samma fil)

## Level 1

Skapa en databas **GnomeDb** med en tabell **Gnome**

L�gg in tre tomtar i gnome-tabellen. Varje tomte har ett namn.

G�r en console-app som skriver ut namnen p� alla tomtar.

Anv�nd denna connectionstr�ng:

	string conString = "Server = (localdb)\\mssqllocaldb; Database = GnomeDb; Trusted_Connection = True;"

Exempel om du lagt in tre tomtar:

![Checkpoint04 1](img/checkpoint04_1.png)


## Level 2

Uppdatera gnome-tabellen enligt nedan.

Varje tomte:
- har ett namn
- har sk�gg eller �r sk�ggl�sa
- �r ond eller god
- har ett temperament (en siffra mellan 1 och 5)

Skriv ut info om alla tomtar:

![Checkpoint04 3](img/checkpoint04_3.png)

## Level 3

Samma som *Level 2* men stuva om koden s� du har en metod som h�mtar tomtarna och en som skriver ut dem.

Skapa en klass *Gnome* med l�mpliga properties.

Ditt huvudprogram ska allts� se ut s�h�r:

	List<Gnome> x = GetGnomesFromDatabase();
	DisplayGnomes(x);

