
# Checkpoint03 - Kyrkor

## Intro

Skapa en databasmodell utifrån följande instruktioner. 

Lägg till lämpliga relationer och primärnycklar.

Lämna endast in en level. (Om du t.ex gör Level 3 så lämna inte in Level 2 eller Level 1)

Lämna in två filer:
- En bild på ditt databasdiagram (i formatet png)
- SQL-frågor (i formatet sql)

(du behöver inte script'a databasen)


## Level 1

Detta ska kunna lagras i databasen:

	Linnea bor i Göteborg
	Harry bor i Stockholm

Skriv en SQL-fråga för hämta alla städer i databasen. Tex:

	Göteborg
	Stockholm	

## Level 2

Detta ska kunna lagras i databasen:

	Linnea bor i Göteborg
	Harry bor i Stockholm

	Oscar-Fredriks kyrka finns i Göteborg och är byggd 1893
	Masthuggskyrkan finns i Göteborg och är byggd 1914
	Sankt Georgios kyrka finns i Stockholm och är byggd 1890
	Matteus kyrka finns i Norrköping och är byggd 1892

Skriv en SQL-fråga för hämta kyrkor och deras info. Tex:

	Göteborg	1893	Oscar-Fredriks kyrka
	Göteborg	1914	Masthuggskyrkan	
	Stockholm	1890	Sankt Georgios kyrka
	Norrköping	1892	Matteus kyrka


## Level 3

Detta ska kunna lagras i databasen:

	Linnea bor i Göteborg
	Harry bor i Stockholm

	Oscar-Fredriks kyrka finns i Göteborg och är byggd 1893
	Masthuggskyrkan finns i Göteborg och är byggd 1914
	Sankt Georgios kyrka finns i Stockholm och är byggd 1890
	Matteus kyrka finns i Norrköping och är byggd 1892

	Linnea gillar Oscar-Fredriks kyrka och Matteus kyrka
	Harry gillar Matteus kyrka

Skriv en SQL-fråga för hämta alla invånare och info om kyrkorna de gillar. Tex:

	Linnea	Oscar-Fredriks kyrka	1893
	Linnea	Matteus kyrka		1892
	Harry	Matteus kyrka		1892	