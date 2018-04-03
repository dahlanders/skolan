# SQL - Chinook database

Det som står inom parantes är de kolumner som ska hämtas. T.ex i fråga 3 så ska bara ArtistName-kolumnen hämtas.

## 1)

Öppna databasservern på din dator:

 	(localdb)\mssqllocaldb

Detta kan du göra från Visual Studio och välja *SQL Server Object Explorer*.

Alternativ: använd programmet *SQL Management Studio*. Välj File => Connect Object Explorer. 

Kör Chinook-scriptet för att skapa musik-databasen

## 2)

Lista all info om alla artister


## 3)

Lista alla artisters namn. Sortera på namn. (ArtistName)

## 4)

Lista de 10 första artisterna, sorterat på namn. (ArtistId, Name)

## 5)

Lista alla artister som börjar på "Academy" (Name)

## 6)

Lista alla album där den andra bokstaven i titeln är “a” och den tredje bokstaven är “r”
(Title)

## 7)

Lista alla album där första bokstaven på titeln är en vokal

## 8)

Lista alla album tillsammans med artister för albumen (ArtistName, AlbumTitle)

## 9)

Förklara skillnaden mellan
- inner join
- left join
- right join
- full join

## 10)

Lista de 10 artister som släppt flest album (NrOfAlbums, ArtistName)

## 11)

Lista namn på alla album som är Jazz eller Blues. Ett album ska bara finnas i listan en gång. (AlbumTitle)

## 12)

Albumet "Let There Be Rock" (av AC/DC) innehåller 8 låtar. Modifiera databasen så det går att ordna låtar i nummerordning. 

Uppdatera sedan databasen så låtarna i "Let There Be Rock" är numrerade från 1 till 8.

(kan även automatisera numreringen, men det är rätt svårt)

## 13)

Skriv en sqlfråga som visar de genres som är mest populära. 

Lista genre och antal tracks i den genren. Visa den genre som har flest tracks först och sedan i nedåtstigande ordning. Visa endast de genres som har fler än 100 tracks.
(GenreName, NrOfTracks)

## 14)

Skapa en variabel som sparar CustomerId utifrån kunden "Leonie Köhler"

Använd denna variabel för att lista alla datum när en faktura till Leonie Köhler gått iväg
(InvoiceDate)

## 15)

Skapa en temporär tabell #CustomerWithSupport som innehåller förnamn och efternamn på en kund och dess supportpersonal 
(CustomerFirstName, CustomerLastName, SupportFirstName, SupportLastName)


## 16)

Lista alla anställda som har en chef och deras chef.

Resultatet ska vara två kolumner (ej 4) med den anställdes och chefens fullständiga namn

(EmployeeName, BossName)

## 17)

Ta reda på hur många tecken den längsta epostadressen har bland alla kunder
(LongestMail)

## 18)

Ta reda på den eller de låtar som pågår längst tid
Resultatet ska vara en rad med låttitel och längden på låten
(Name, Minutes)

## 19)

Skriv ett script som gör en av kolumner i Customer unique. Motivera ditt val 

## 20)

Lista hur mycket som har fakturerat för varje år (2009-2013). Sortera så senaste åren visas först (2013)
(Year, Sum)

## Extra

## 1)

Hitta på två egna uppgifter som bygger på att data ska hämtas (via SELECT)

Lös uppgifterna.

Visa för din lärare.

## 2)

Hitta på två egna uppgifter som bygger på att data ska modifieras (via INSERT, UPDATE, DELETE)

Lös uppgifterna.

Visa för din lärare.

## 3)

Gör en backup av databasen Chinook till en fil. Ta bort alla spellistor.
Skriv en sql-fråga för att visa att spellistorna är borta

Gör sedan en restore av databasen så spellistorna kommer tillbaka.
Skriv en sql-fråga för att visa att spellistorna är tillbaka

## 4)

Använd transaktioner för att lösa denna uppgift.

Lägg till 5 artister i Artist-tabellen.

Ångra sedan transaktionen så de 5 artisterna inte läggs in. (använd alltså inte "delete" i denna uppgift)

## 5) 

(Svår!)

Kolumnen AlbumId har datatypen int, vilket kan vara onödigt generöst.

Välj en annan datatyp som är mer begränsande.

Skriv ett script som ändrar datatypen (och tar hänsyn till index och nycklar)

