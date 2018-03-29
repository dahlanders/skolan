private void ListOfStringLab()
{
    var parser = new Parser();
    List<string> list = parser.CreateListOfNames("PersonShort.csv");

    list.Sort();
    DisplayListOfString("Sorted list:", list);

    var result = new List<string>();

    foreach (var name in list)
    {
        if (name.StartsWith("J"))
            result.Add(name);
    }

    list = result;

    var startsWithJ = list.Where(name => name.StartsWith("J")).ToList();
    DisplayListOfString("Start with J:", startsWithJ);

    var startsWithDAndUpper = startsWithJ.Select(name => name.ToUpper()).ToList();
    DisplayListOfString("Start with J and uppercase:", startsWithDAndUpper);


    Console.ReadKey();
}

private void DisplayListOfString(string header, List<string> list)
{
    Console.WriteLine(header);
    foreach (string s in list)
    {
        ch.WriteDark(s);
    }
    Console.WriteLine();
}
