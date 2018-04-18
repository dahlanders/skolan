# Samuari3 - Entity Framework


## AllSamuariNameWithAlias

Skapa en metod som hämtar alla samurajer och returnerar en lista med strängar. Varje sträng ska innehålla:


    samuraiRealName + “ alias ” + samuraiName

 
 Använd **Select** för att lösa uppgiften. Exempel:


    List<string> namesWithAlias = AllSamuariNameWithAlias();
    DisplayList(namesWithAlias);

Om du skriver ut listan av strängar kan det se ut såhär:


    Per alias Pelle
    Lars alias Lasse
    Julia alias Julle



## ListAllBattles_WithLog(DateTime from, DateTime to, bool isBrutal)

Lista alla slag tillsammans med dess loggbok och händelser.

Sortera händelseloggarna på dess sorteringsordning.


    -------------------------------------------------------------------------------------
    Name of battle           Battle 1
    Log name                 Battlelog for battle 1
    Event                    Summary of event (order1, battle1)
    Event                    Summary of event (order2, battle1)
    Event                    Summary of event (order3, battle1)
    -------------------------------------------------------------------------------------
    Name of battle           Battle 2
    Log name                 Battlelog for battle 2
    Event                    Summary of event (order1, battle2)
    Event                    Summary of event (order2, battle2)
    -------------------------------------------------------------------------------------


## List<SamuraiInfo> GetSamuraiInfo()

Skapa en klass **SamuraiInfo**:

    public class SamuraiInfo
    {
        public string Name { get; set; }
        public string RealName { get; set; }
        public string BattleNames { get; set; }
    }

Gå igenom alla samurajer och skapa en lista av SamuraiInfo.

BattleNames är en sträng med de slag som samurajen deltagit i (kommaseparerad)

Skapa sedan en metod som skriver ut en **List< SamuraiInfo >** : 


    Name                     RealName                 Battles
    --------------------------------------------------------------------------------------
    Kalle                    Karl                     Battle 1,Battle 2
    Pelle                    Per                      Battle 1
    Lasse                    Lars                     Battle 2
    Julle                    Julia


## GetBattlesForSamurai(string samuraiName)

Skriv ut de slag som en viss samuarj deltar i:

    Samurai 'Kalle' is participating in the following battles:
    
    Id                       Name
    1                        Battle 1
    2                        Battle 2



## Reset’a index på alla tabeller

Tips hur du återskapar index för alla tabeller:

    private static void ReseedAllTables()
    {
        _context.Database.ExecuteSqlCommand("DBCC CHECKIDENT('Samurais', RESEED, 0)");
        _context.Database.ExecuteSqlCommand("DBCC CHECKIDENT('SecretIdentity', RESEED, 0)");
        _context.Database.ExecuteSqlCommand("DBCC CHECKIDENT('Quotes', RESEED, 0)");
        _context.Database.ExecuteSqlCommand("DBCC CHECKIDENT('Battles', RESEED, 0)");
        _context.Database.ExecuteSqlCommand("DBCC CHECKIDENT('BattleLog', RESEED, 0)");
        _context.Database.ExecuteSqlCommand("DBCC CHECKIDENT('BattleEvent', RESEED, 0)");
    }





## Initiera logger

Om du vill skriva ut alla SQL-kommandon som Entity Framework skickar till din databas, gör följande:

Lägg in denna klass i Domain-projektet


    using Microsoft.EntityFrameworkCore.Storage;
    using Microsoft.Extensions.Logging;
    using System;
    
    namespace EfSamurai.Data
    {
        public class MyLoggerProvider : ILoggerProvider
        {
            public ILogger CreateLogger(string categoryName)
            {
                return new MyLogger();
            }
    
            public void Dispose()
            {
            }
    
            private class MyLogger : ILogger
            {
    
                public bool IsEnabled(LogLevel logLevel)
                {
                    return true;
                }
    
                public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception,
                  Func<TState, Exception, string> formatter)
                {
                    if (state is DbCommandLogData)
                    {
                        Console.WriteLine(formatter(state, exception));
                        Console.WriteLine();
                    }
                }
    
                public IDisposable BeginScope<TState>(TState state)
                {
                    return null;
                }
            }
        }
    }
    

För att använda loggningen, skriv detta först i ditt program:


    _context.GetService<ILoggerFactory>().AddProvider(new MyLoggerProvider());

Nu loggas alla anrop till databasen, så du ser dem i console-fönstret.


## InvestigateWhenDatabaseIsQueried


Syftet med denna uppgift är att du undsöker när EF skickar SQL-kommandon till din databas.

Här har du nytta av din logger.

Undersök olika kommandon

    var query = context.Samurais;
    
    var samurais = context.Samurais.ToList();
    
    foreach (var samurai in samurais)
    {
        Console.Write(samurai.Name);
    }
    
    var first = context.Samurais.First();
    
    // Lägg till samurai i context utan att anropa SaveChanges
    context.Samurais.Add(new Samurai { Name = "Sven" });

…och ta reda på när databasen anropas och när den inte göra det. Output kan se ut såhär:


![](https://d2mxuefqeaa7sj.cloudfront.net/s_50B48A3E826B1ECEA9D50B394A799008B1C932035A37A339FFEA2C28A7D24AFB_1494263362570_image.png)


