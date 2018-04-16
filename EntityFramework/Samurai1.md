# Samuari1 - Entity Framework


## Intro

I denna �vning ska vi bygga en samuarjdatabas utifr�n **Entity Framework** och principen **Code First**.

Allt handlar om att skapa en dom�n-modell och skapa en motsvarande databas.

Vi kommer inte beh�va n�gon console-app �n. Vi kommer inte l�gga till n�gon information i tabellerna.

## Setup

Skapa en solution med tv� projekt i:

- EfSamuari.Data - ett projekt av typ **Class Library (.NET Core)**
- EfSamuari.Domain - ett projekt av typ **Class Library (.NET Core)**

Installera f�ljande tv� nugetpaket i **EfSamuari.Data** genom att skriva f�ljande i **Package Manager Console**:


    Install-Package Microsoft.EntityFrameworkCore.Tools
    Install-Package Microsoft.EntityFrameworkCore.SqlServer


L�gg in en klass Samuari in Domain-projeket:


    public class Samurai
    {
        public int Id { get; set; }
    }

L�gg in en klass **SamuraiContext** i EfSamurai.Data-projektet:


    public class SamuraiContext : DbContext
    {
        public DbSet<Samurai> Samurais { get; set; }
      
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
              "Server = (localdb)\\mssqllocaldb; Database = EfSamurai; Trusted_Connection = True; ");
        }
    }

Skippa denna del (en tidigare bugg)

    Buggfix, l�gg in en rad i Data-projektfilen:


      <PropertyGroup>
        <TargetFramework>netcoreapp1.1</TargetFramework>
        <GenerateRuntimeConfigurationFiles>true</GenerateRuntimeConfigurationFiles>
      </PropertyGroup>
    

    (annars g�r det inte att k�ra Update-Database).

Starta ett GIT-repo, f�rslagsvis med SourceTree. Och checka in ofta. Annars blir det sv�rt att f�lja vilka filer som skapas av magi.

Aktivera ditt projekt **EfSamuari.Data**. I **Package Manager Console**, k�r detta kommando f�r att skapa din f�rsta migration:


    Add-Migration MyFirstMigration -StartupProject EfSamuari.Data

K�r sedan detta kommando f�r att uppdatera databasen:


    Update-Database -StartupProject EfSamuari.Data


## Alla Samurajer har ett namn

L�gg till en Name-property f�r Samurai. 
L�gg till en migration.
Uppdatera databasen.

Verifiera att en Name-kolumn har dykt upp.

Extra:

- L�gg till ytterligare n�gon/n�gra egenskaper en Samuarj kan ha och uppdatera databasen
- Unders�k de migreringsscript som skapats
- Unders�k snapshot-filen som �ndrats


## En-till-m�nga-relation (Quote)

L�gg till en klass **Quote** f�r samuarjers citat (I Domain-projektet).

En Samurai ska kunna ha flera Quotes. 
En Quote tillh�r enbart en Samurai.

L�gg till migration. Uppdatera databasen.

Extra:

- L�gg till ytterligare n�gon/n�gra egenskaper ett Citat kan ha och uppdatera databasen


## Citat-varianter

Det ska kunna finnas olika typer av Quotes:

- Lame
- Cheesy
- Awesome

Uppdatera din dom�n. L�gg till migration. Uppdatera databasen. 

## Frisyr

En samuarj kan ha olika frisyrer: 

- Chonmage
- Oicho
- Western

Uppdatera din dom�n. L�gg till migration. Uppdatera databasen. 


## Ett-till-ett-relation (SecretIdentity)

Alla Samuraier kan ha en hemlig identitet, som talar om deras verkliga namn.

Uppdatera Domain-projektet. L�gg till migration. Uppdatera databasen. 

## 
## Battle

L�gg till en Battle-klass. 

Ett krig ska kunna ha olika v�rden: namn, beskrivning, brutal (true/false), start-datum, slut-datum

L�gg till migration. Uppdatera databasen. 


## M�nga till m�nga relation (SamuraiBattle)

I ett krig ska flera samurajer kunna delta.
Samtidigt ska en samuarj kunna vara med flera olika krig.

Uppdatera din dom�n f�r att l�sa detta.

L�gg till migration. Uppdatera databasen. 


## BattleLog

Varje Battle har en BattleLog.
En BattleLog tillh�r ett Battle

En BattleLog har ett namn.

Uppdatera din dom�n. L�gg till migration. Uppdatera databasen. 


## BattleEvent

En krigslogg kan inneh�lla flera krigsh�ndelser.

En s�dan h�ndelse best�r av beskrivande text + en summering vad som h�nt. Det ska g� att se vilken ordning h�ndelserna sker.


