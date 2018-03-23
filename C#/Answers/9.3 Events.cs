public class EventLab
{
    event Action spacePressed;

    public void Run()
    {

        spacePressed += SetColorBlue;
        spacePressed += SetBackgroundYellow;
        spacePressed += WriteLine;
        spacePressed += GiveMeCoffee;
        spacePressed += GiveMeCoffee;

        Console.WriteLine();
        Console.WriteLine("Press SPACE to invoke methods. Press 'Q' to quit");
        Console.WriteLine();

        ListenToKeyPress();
    }

    private void WriteLine()
    {
        Console.WriteLine("--------------");
    }

    private void GiveMeCoffee()
    {
        Console.WriteLine("Give me coffee");
    }

    private void SetColorBlue()
    {
        Console.ForegroundColor = ConsoleColor.Blue;
    }

    private void SetBackgroundYellow()
    {
        Console.BackgroundColor = ConsoleColor.Yellow;
    }

    private void ListenToKeyPress()
    {
        char keyPressed;

        do
        {
            keyPressed = Console.ReadKey(true).KeyChar;
            if (keyPressed == ' ')
            {
                spacePressed.Invoke();
            }
        }
        while (keyPressed != 'q');

    }
}
