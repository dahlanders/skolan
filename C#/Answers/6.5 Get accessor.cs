
public class Address
{
    public string Street { get; set; }
    public string StreetNumber { get; set; }
    public string City { get; set; }

    // Get method

    public string GetFullStreet()
    {
        return $"{Street} {StreetNumber}";
    }

    // Get using property instead

    public string FullStreet => $"{Street} {StreetNumber}";
}
