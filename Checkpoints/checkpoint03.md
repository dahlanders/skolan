
# Checkpoint03 - Kyrkor

## Intro

Skapa en databasmodell utifr�n f�ljande instruktioner. 

L�gg till l�mpliga relationer och prim�rnycklar.

L�mna endast in en level. (Om du t.ex g�r Level 3 s� l�mna inte in Level 2 eller Level 1)

L�mna in tv� filer:
- En bild p� ditt databasdiagram (i formatet png)
- SQL-fr�gor (i formatet sql)

(du beh�ver inte script'a databasen)


## Level 1

Detta ska kunna lagras i databasen:

	Linnea bor i G�teborg
	Harry bor i Stockholm

Skriv en SQL-fr�ga f�r h�mta alla st�der i databasen. Tex:

	G�teborg
	Stockholm	

## Level 2

Detta ska kunna lagras i databasen:

	Linnea bor i G�teborg
	Harry bor i Stockholm

	Oscar-Fredriks kyrka finns i G�teborg och �r byggd 1893
	Masthuggskyrkan finns i G�teborg och �r byggd 1914
	Sankt Georgios kyrka finns i Stockholm och �r byggd 1890
	Matteus kyrka finns i Norrk�ping och �r byggd 1892

Skriv en SQL-fr�ga f�r h�mta kyrkor och deras info. Tex:

	G�teborg	1893	Oscar-Fredriks kyrka
	G�teborg	1914	Masthuggskyrkan	
	Stockholm	1890	Sankt Georgios kyrka
	Norrk�ping	1892	Matteus kyrka


## Level 3

Detta ska kunna lagras i databasen:

	Linnea bor i G�teborg
	Harry bor i Stockholm

	Oscar-Fredriks kyrka finns i G�teborg och �r byggd 1893
	Masthuggskyrkan finns i G�teborg och �r byggd 1914
	Sankt Georgios kyrka finns i Stockholm och �r byggd 1890
	Matteus kyrka finns i Norrk�ping och �r byggd 1892

	Linnea gillar Oscar-Fredriks kyrka och Matteus kyrka
	Harry gillar Matteus kyrka

Skriv en SQL-fr�ga f�r h�mta alla inv�nare och info om kyrkorna de gillar. Tex:

	Linnea	Oscar-Fredriks kyrka	1893
	Linnea	Matteus kyrka		1892
	Harry	Matteus kyrka		1892	