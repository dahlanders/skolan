private static void IfConditional()
    {
    Console.Write("Enter a number: ");
    int number = int.Parse(Console.ReadLine());

    string message = (number > 20) ? "The number is higher than 20" : "Lower or equal to 20";
    Console.WriteLine(message);
}
