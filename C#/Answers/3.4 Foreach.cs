private static void SplitAndForeach()
{
    Console.Write("Enter names in a list (like Maria,Peter,Lisa): ");
    string names = Console.ReadLine() ?? "";
    string[] nameList = names.Split(',');

    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine();

    foreach (string name in nameList)
    {
        Console.WriteLine($"{name} Andersson");
    }
}