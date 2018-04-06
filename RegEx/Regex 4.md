# Regex 4

## Ta bort metataggar

Kolla i konstskola.html. Ta bort alla metataggar <meta>, t.ex denna:

    <meta property="og:description" content="Måleri | Grafik | Skulptur | Idégestaltning" />


## Ta bort id inom link

Kolla i konstskola.html. Ta bort id inom alla <link>-tagger.

T.ex:

    <link rel='stylesheet' id='child-style-css'  href='http://gbgkonstskola.se/wp-content/themes/wp-gk/style.css?ver=3.0' type='text/css' media='all' />

==>

    <link rel='stylesheet' href='http://gbgkonstskola.se/wp-content/themes/wp-gk/style.css?ver=3.0' type='text/css' media='all' />


## Ta bort kommentarer

Kolla i konstskola.html. Ta bort alla html-kommentarer.

T.ex

    <!-- Jetpack Open Graph Tags -->


## Ersätt menu-item 

Kolla i konstskola.html. Ersätta alla menu-item-NNN med  menu-item-666.

T.ex

    menu-item-579 ==> menu-item-666

(men menu-item-object-page ska vara oförändrad)


## Mellanslag och tabbar

Kolla i konstskola.html. Ta bort alla inledande mellanslag eller tabbar

     <body class="home singular page”>   
       
            <div class="off-canvas-wrapper">
    <div class="off-canvas-wrapper-inner" data-off-canvas-wrapper>

==>

    <body class="home singular page”>   
    <div class="off-canvas-wrapper">
    <div class="off-canvas-wrapper-inner" data-off-canvas-wrapper>
    

## Extra (svår!)

Kolla i konstskola.html. Gör om alla taggar till p-taggar . 

T.ex:

    <a href="http://gbgkonstskola.se/" title="Home" rel="home">Home</a>

    till

    <p href="http://gbgkonstskola.se/" title="Home" rel="home">Home</p>

T.ex:

    <meta property="og:type" content="website" /> 

	till

    <p property="og:type" content="website"></p>

