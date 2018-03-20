
public class Address
{
    public string Street { get; set; }
    public string StreetNumber { get; set; }
    public string City { get; set; }

    private string _zipCode;

    public string ZipCode
    {
        get
        {
            return _zipCode;
        }
        set
        {
            if (ZipCodeIsValid(value))
            {
                _zipCode = value;
            }
        }
    }

    private bool ZipCodeIsValid(string value)
    {
        string okZipCodePattern = @"^\d\d\d \d\d$";
        return Regex.IsMatch(value, okZipCodePattern);
    }

}
