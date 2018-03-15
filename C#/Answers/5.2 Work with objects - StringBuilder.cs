private static void LabWithStringAndStringBuilder()
{
    Console.WriteLine();

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
    }

    Console.WriteLine();

    {
        ConsoleHelper ch = new ConsoleHelper();

        ch.WriteGreen("STRINGBUILDER TEST");
        Console.WriteLine();

        ConsoleTable ct = ConsoleTable.Create(3, ConsoleColor.DarkGray);
        ct.Write("Cycles", "Length of string", "Time");

        StringTest_StringBuilder(5);
        StringTest_StringBuilder(50);
        StringTest_StringBuilder(500);
        StringTest_StringBuilder(5000);
        StringTest_StringBuilder(50000);
    }
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

private static void StringTest_StringBuilder(int cycles)
{
    ConsoleTable ct = ConsoleTable.Create(3);
    Stopwatch stopwatch = new Stopwatch();
    stopwatch.Start();
    string result = GenerateString_StringBuilder("Tennis anyone? ", cycles);
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

private static string GenerateString_StringBuilder(string repeatme, int cycles)
{
    StringBuilder sb = new StringBuilder();

    for (int i = 0; i < cycles; i++)
    {
        sb.Append(repeatme);
    }

    return sb.ToString();
}