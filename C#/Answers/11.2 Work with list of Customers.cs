private void ListOfCustomerLab()
{
    var parser = new Parser();
    List<Customer> list = parser.CreateListOfCustomers("PersonShort.csv");

    list.Sort((c1, c2) => c1.Age - c2.Age);
    DisplayListOfCustomers("Sorted list by age:", list);

    list.Sort((c1, c2) => string.Compare(c1.FirstName, c2.FirstName));
    DisplayListOfCustomers("Sorted list by first name:", list);

    var menOlderThan35 = list.Where(c => c.Gender == Gender.Male && c.Age > 35).ToList();
    DisplayListOfCustomers("Men older than 35:", menOlderThan35);

    var manipulatedList = menOlderThan35.Select(c => new Customer
    {
        Id = c.Id,
        Age = c.Age + 1000,
        FirstName = c.FirstName.ToUpper(),
        LastName = c.LastName.ToUpper(),
        Email = c.Email,
        Gender = c.Gender
    }).ToList();

    DisplayListOfCustomers("Manipulated:", manipulatedList);
}

private void DisplayListOfCustomers(string header, List<Customer> list)
{
    Console.WriteLine(header);

    var table = ConsoleTable.Create(3, ConsoleColor.DarkGray, 20);
    foreach (Customer c in list)
    {
        table.Write(c.FirstName, c.Age, c.Gender);
    }
    Console.WriteLine();
}

public class Customer
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public Gender Gender { get; set; }
    public int Age { get; set; }
}
