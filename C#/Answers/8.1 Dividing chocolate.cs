private void ChocolateTest()
{
    ConsoleHelper ch = new ConsoleHelper();
    Console.WriteLine("The chocolate contains 10 pieces");
    int people = ch.AskForWholeNumber("How many want to share?");

    try
    {
        decimal piecePerPerson = 10M / people;
        Console.WriteLine($"Everyone get {piecePerPerson:.##} pieces");
    }
    catch (DivideByZeroException ex)
    {
        ch.ErrorMessage("Zero people can't divide a chocolate");
    }
    catch (Exception ex)
    {
        ch.ErrorMessage("Something strange happened!");
    }
}
