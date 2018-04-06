# Regex 2

## Svenskt ord

Validera ett svenskt ord.

Ok:

    äpple
    Päron
    traktor
    ö

Fail

    $
    123
    trakt8r
    oscér

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

Skriv en metod ProductNumberIsValid (i C#) som returnerar sant som produktnumret är på rätt format

Tips: använd Regex.IsMatch

### Produktnummer III

Skriv en metod PrintPartOfProductNumber (i C#) som skriver ut ett produktnummers delar.

Ex.

    DE-234-456 => 

	Första delen: DE
	Andra delen: 234
	Tredje delen: 456

Tips: använd Regex.Match

## Extra

Används search and replace för att konvertera:

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
