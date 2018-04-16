# Samuari1 - Entity Framework


## Intro

I denna övning ska vi bygga en samuarjdatabas utifrån **Entity Framework** och principen **Code First**.

Allt handlar om att skapa en domän-modell och skapa en motsvarande databas.

Vi kommer inte behöva någon console-app än. Vi kommer inte lägga till någon information i tabellerna.

## Setup

Skapa en solution med två projekt i:

- EfSamuari.Data - ett projekt av typ **Class Library (.NET Core)**
- EfSamuari.Domain - ett projekt av typ **Class Library (.NET Core)**

Installera följande två nugetpaket i **EfSamuari.Data** genom att skriva följande i **Package Manager Console**:


    Install-Package Microsoft.EntityFrameworkCore.Tools
    Install-Package Microsoft.EntityFrameworkCore.SqlServer


Lägg in en klass Samuari in Domain-projeket:


    public class Samurai
    {
        public int Id { get; set; }
    }

Lägg in en klass **SamuraiContext** i EfSamurai.Data-projektet:


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

    Buggfix, lägg in en rad i Data-projektfilen:


      <PropertyGroup>
        <TargetFramework>netcoreapp1.1</TargetFramework>
        <GenerateRuntimeConfigurationFiles>true</GenerateRuntimeConfigurationFiles>
      </PropertyGroup>
    

    (annars går det inte att köra Update-Database).

Starta ett GIT-repo, förslagsvis med SourceTree. Och checka in ofta. Annars blir det svårt att följa vilka filer som skapas av magi.

Aktivera ditt projekt **EfSamuari.Data**. I **Package Manager Console**, kör detta kommando för att skapa din första migration:


    Add-Migration MyFirstMigration -StartupProject EfSamuari.Data

Kör sedan detta kommando för att uppdatera databasen:


    Update-Database -StartupProject EfSamuari.Data


## Alla Samurajer har ett namn

Lägg till en Name-property för Samurai. 
Lägg till en migration.
Uppdatera databasen.

Verifiera att en Name-kolumn har dykt upp.

Extra:

- Lägg till ytterligare någon/några egenskaper en Samuarj kan ha och uppdatera databasen
- Undersök de migreringsscript som skapats
- Undersök snapshot-filen som ändrats


## En-till-många-relation (Quote)

Lägg till en klass **Quote** för samuarjers citat (I Domain-projektet).

En Samurai ska kunna ha flera Quotes. 
En Quote tillhör enbart en Samurai.

Lägg till migration. Uppdatera databasen.

Extra:

- Lägg till ytterligare någon/några egenskaper ett Citat kan ha och uppdatera databasen


## Citat-varianter

Det ska kunna finnas olika typer av Quotes:

- Lame
- Cheesy
- Awesome

Uppdatera din domän. Lägg till migration. Uppdatera databasen. 

## Frisyr

En samuarj kan ha olika frisyrer: 

- Chonmage
- Oicho
- Western

Uppdatera din domän. Lägg till migration. Uppdatera databasen. 


## Ett-till-ett-relation (SecretIdentity)

Alla Samuraier kan ha en hemlig identitet, som talar om deras verkliga namn.

Uppdatera Domain-projektet. Lägg till migration. Uppdatera databasen. 

## 
## Battle

Lägg till en Battle-klass. 

Ett krig ska kunna ha olika värden: namn, beskrivning, brutal (true/false), start-datum, slut-datum

Lägg till migration. Uppdatera databasen. 


## Många till många relation (SamuraiBattle)

I ett krig ska flera samurajer kunna delta.
Samtidigt ska en samuarj kunna vara med flera olika krig.

Uppdatera din domän för att lösa detta.

Lägg till migration. Uppdatera databasen. 


## BattleLog

Varje Battle har en BattleLog.
En BattleLog tillhör ett Battle

En BattleLog har ett namn.

Uppdatera din domän. Lägg till migration. Uppdatera databasen. 


## BattleEvent

En krigslogg kan innehålla flera krigshändelser.

En sådan händelse består av beskrivande text + en summering vad som hänt. Det ska gå att se vilken ordning händelserna sker.


