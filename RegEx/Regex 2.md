# Regex 2

## Svenskt ord

Validera ett svenskt ord.

Ok:

    �pple
    P�ron
    traktor
    �

Fail

    $
    123
    trakt8r
    osc�r

## Produktnummer

Validera projektnummer.

Ok:

    AB-100-100
    DE-234-456
    FF-421-334

Fail:

    AB
    AB-100
    AB-10-0-100
    DEE-234-456
    FF-421-334-


## Produktnummer II

Plocka ut delarna ur ett produktnummer:
DE-234-456 => 

	F�rsta delen: DE
	Andra delen: 234
	Tredje delen: 456


## Extra

Anv�nds search and replace f�r att konvertera:

    a {font:Arial; color:red}
    h1 {padding:10px}
    h3 {margin:20px; padding-right:20px}

till

    a 
    {
	    font:Arial; color:red
    }

    h1 
    {
	    padding:10px
    }

    h3 
    {
	    margin:20px; padding-right:20px
    }
