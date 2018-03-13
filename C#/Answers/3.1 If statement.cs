private static void DoYouNeedToSleep()
{
    Console.Write("When did you go to bed yesterday? ");
    int toSleep = int.Parse(Console.ReadLine());

    Console.Write("When did you wake up? ");
    int wokeUp = int.Parse(Console.ReadLine());

    int sleepTime = wokeUp + (24 - toSleep);

    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine();

    if (sleepTime < 6)
    {
        Console.WriteLine($"You've only slept {sleepTime}. Go back to bed!");
    }
    else if (sleepTime > 12)
    {
        Console.WriteLine($"You've slept {sleepTime} hours. That's a lot.");
    }
    else
    {
        Console.WriteLine($"You have slept well. ({sleepTime} hours)");
    }

}
