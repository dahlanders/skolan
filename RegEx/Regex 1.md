# Regex 1

## Telefonnummer

Validera telefonnummer. 

Dessa ska vara ok:

    030211223
    031-112233
    073-6401023
    0736401023
    112

Dessa är inte ok:

    78
    031-112233a
    08-22-3344
    1111111111222222222222233333333333


## Epost

Validera epostadress

Ok:

    oo@happybits.se
    oscar.olsson@stendahls.se
    oscar.olsson.svensson@hej.stendahls.se

Inte ok:

    oscar
    @happybits.se
    oo@@happybits.se
    oo@happybåts.se
    oo@happybits
    oo.happybits.se
    oo..@happybits.se
    oo@happybits..se
    oo.@happybits.se
    .oo@happybits.se
    oo.@happybits.se.
    oo@happybits.seeek


## Extra

Skriv ett C#-program som plockar ut epostnamnet, hostnamnet och topdomänen ur epostadressen. Alltså:

oscar.olsson.svensson@hej.stendahls.se =>

	Namn: oscar.olsson.svensson
	Host: hej.stendahls
	Topdomän: se