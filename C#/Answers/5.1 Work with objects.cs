
private static void LabWithString()
{
    ConsoleHelper ch = new ConsoleHelper();

    ch.WriteGreen("STRING TEST");
    Console.WriteLine();

    ConsoleTable ct = ConsoleTable.Create(3, ConsoleColor.DarkGray);
    ct.Write("Cycles", "Length of string", "Time");

    StringTest(5);
    StringTest(50);
    StringTest(500);
    StringTest(5000);
    StringTest(50000);

    Console.WriteLine();
    
}

private static void StringTest(int cycles)
{
    ConsoleTable ct = ConsoleTable.Create(3);
    Stopwatch stopwatch = new Stopwatch();
    stopwatch.Start();
    string result = GenerateString("Tennis anyone? ", cycles);
    stopwatch.Stop();
    ct.Write(cycles, result.Length, stopwatch.ElapsedMilliseconds + "ms");
}

private static string GenerateString(string repeatme, int cycles)
{
    string result = "";

    for (int i = 0; i < cycles; i++)
    {
        result += repeatme;
    }

    return result;
}