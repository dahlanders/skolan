private static void RepeatNameWithWhile()
{
    Console.Write("Enter your name: ");
    string yourName = Console.ReadLine();

    Console.Write("Times to repeat: ");
    int repeat = int.Parse(Console.ReadLine());

    int counter = 0;

    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine();

    while (counter < repeat)
    {
        Console.WriteLine($"Your name is {yourName}");
        counter++;
    }
}