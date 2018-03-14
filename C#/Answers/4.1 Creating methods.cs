private static void WithMethodsSimple()
{
    string response = GetInputFromUser();

    string[] peopleArray = CreateArrayOfPeople(response, ',');

    RespondToUser(peopleArray);
}

private static string GetInputFromUser()
{
    Console.Write("Enter a list of names: ");
    string answer = Console.ReadLine();
    return answer;
}

private static string[] CreateArrayOfPeople(string response, char separator = ',')
{
    string[] list = response.Split(new char[] { separator }, StringSplitOptions.RemoveEmptyEntries);

    return list;
}

private static void RespondToUser(string[] peopleArray)
{
    Console.ForegroundColor = ConsoleColor.Green;

    if (peopleArray.Length == 0)
    {
        Console.WriteLine("No people in the list");
        return;
    }

    foreach (string person in peopleArray)
    {
        Console.WriteLine($"***SUPER-{person.ToUpper()}***");
    }
}