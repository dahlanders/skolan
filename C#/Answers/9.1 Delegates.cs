public class DelegateLab
{
    ConsoleHelper ch = new ConsoleHelper();

    public void Run()
    {
        GoodWay();
        //BadWay();
    }

    public void GoodWay()
    {
        AskUserAndRespond(ToUpper);
        AskUserAndRespond(Tripple);
        AskUserAndRespond(AddStars);
    }

    public void BadWay()
    {
        AskUserAndRespond_ToUpper();
        AskUserAndRespond_Tripple();
        AskUserAndRespond_AddStars();
    }

    private void AskUserAndRespond_ToUpper()
    {
        string input = ch.AskForString($"Enter a string to convert:");
        string answer = ToUpper(input);
        Console.WriteLine($"Here is the result:{answer}\n");
    }

    private void AskUserAndRespond_Tripple()
    {
        string input = ch.AskForString($"Enter a string to convert:");
        string answer = Tripple(input);
        Console.WriteLine($"Here is the result:{answer}\n");
    }

    private void AskUserAndRespond_AddStars()
    {
        string input = ch.AskForString($"Enter a string to convert:");
        string answer = AddStars(input);
        Console.WriteLine($"Here is the result:{answer}\n");
    }

    private string ToUpper(string s)
    {
        return s.ToUpper();
    }

    private string Tripple(string s)
    {
        return s + s + s;
    }

    private string AddStars(string s)
    {
        string spacyString = "";
        foreach (char c in s)
        {
            spacyString += c + "*";
        }
        spacyString = spacyString.TrimEnd('*');
        return spacyString;
    }

    private void AskUserAndRespond(Func<string, string> converter)
    {
        string input = ch.AskForString($"Enter a string to convert:");
        string answer = converter(input);
        Console.WriteLine($"Here is the result:{answer}\n");
    }
}
