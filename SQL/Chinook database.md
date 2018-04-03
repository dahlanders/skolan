# SQL - Chinook database

Det som st�r inom parantes �r de kolumner som ska h�mtas. T.ex i fr�ga 3 s� ska bara ArtistName-kolumnen h�mtas.

## 1)

�ppna databasservern p� din dator:

 	(localdb)\mssqllocaldb

Detta kan du g�ra fr�n Visual Studio och v�lja *SQL Server Object Explorer*.

Alternativ: anv�nd programmet *SQL Management Studio*. V�lj File => Connect Object Explorer. 

K�r Chinook-scriptet f�r att skapa musik-databasen

## 2)

Lista all info om alla artister


## 3)

Lista alla artisters namn. Sortera p� namn. (ArtistName)

## 4)

Lista de 10 f�rsta artisterna, sorterat p� namn. (ArtistId, Name)

## 5)

Lista alla artister som b�rjar p� "Academy" (Name)

## 6)

Lista alla album d�r den andra bokstaven i titeln �r �a� och den tredje bokstaven �r �r�
(Title)

## 7)

Lista alla album d�r f�rsta bokstaven p� titeln �r en vokal

## 8)

Lista alla album tillsammans med artister f�r albumen (ArtistName, AlbumTitle)

## 9)

F�rklara skillnaden mellan
- inner join
- left join
- right join
- full join

## 10)

Lista de 10 artister som sl�ppt flest album (NrOfAlbums, ArtistName)

## 11)

Lista namn p� alla album som �r Jazz eller Blues. Ett album ska bara finnas i listan en g�ng. (AlbumTitle)

## 12)

Albumet "Let There Be Rock" (av AC/DC) inneh�ller 8 l�tar. Modifiera databasen s� det g�r att ordna l�tar i nummerordning. 

Uppdatera sedan databasen s� l�tarna i "Let There Be Rock" �r numrerade fr�n 1 till 8.

(kan �ven automatisera numreringen, men det �r r�tt sv�rt)

## 13)

Skriv en sqlfr�ga som visar de genres som �r mest popul�ra. 

Lista genre och antal tracks i den genren. Visa den genre som har flest tracks f�rst och sedan i ned�tstigande ordning. Visa endast de genres som har fler �n 100 tracks.
(GenreName, NrOfTracks)

## 14)

Skapa en variabel som sparar CustomerId utifr�n kunden "Leonie K�hler"

Anv�nd denna variabel f�r att lista alla datum n�r en faktura till Leonie K�hler g�tt iv�g
(InvoiceDate)

## 15)

Skapa en tempor�r tabell #CustomerWithSupport som inneh�ller f�rnamn och efternamn p� en kund och dess supportpersonal 
(CustomerFirstName, CustomerLastName, SupportFirstName, SupportLastName)


## 16)

Lista alla anst�llda som har en chef och deras chef.

Resultatet ska vara tv� kolumner (ej 4) med den anst�lldes och chefens fullst�ndiga namn

(EmployeeName, BossName)

## 17)

Ta reda p� hur m�nga tecken den l�ngsta epostadressen har bland alla kunder
(LongestMail)

## 18)

Ta reda p� den eller de l�tar som p�g�r l�ngst tid
Resultatet ska vara en rad med l�ttitel och l�ngden p� l�ten
(Name, Minutes)

## 19)

Skriv ett script som g�r en av kolumner i Customer unique. Motivera ditt val 

## 20)

Lista hur mycket som har fakturerat f�r varje �r (2009-2013). Sortera s� senaste �ren visas f�rst (2013)
(Year, Sum)

## Extra

## 1)

Hitta p� tv� egna uppgifter som bygger p� att data ska h�mtas (via SELECT)

L�s uppgifterna.

Visa f�r din l�rare.

## 2)

Hitta p� tv� egna uppgifter som bygger p� att data ska modifieras (via INSERT, UPDATE, DELETE)

L�s uppgifterna.

Visa f�r din l�rare.

## 3)

G�r en backup av databasen Chinook till en fil. Ta bort alla spellistor.
Skriv en sql-fr�ga f�r att visa att spellistorna �r borta

G�r sedan en restore av databasen s� spellistorna kommer tillbaka.
Skriv en sql-fr�ga f�r att visa att spellistorna �r tillbaka

## 4)

Anv�nd transaktioner f�r att l�sa denna uppgift.

L�gg till 5 artister i Artist-tabellen.

�ngra sedan transaktionen s� de 5 artisterna inte l�ggs in. (anv�nd allts� inte "delete" i denna uppgift)

## 5) 

(Sv�r!)

Kolumnen AlbumId har datatypen int, vilket kan vara on�digt gener�st.

V�lj en annan datatyp som �r mer begr�nsande.

Skriv ett script som �ndrar datatypen (och tar h�nsyn till index och nycklar)

