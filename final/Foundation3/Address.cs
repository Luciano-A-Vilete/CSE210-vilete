public class Address
{
    // Private member variables
    private string _street;
    private string _city;
    private string _state;
    private string _zip;

    // Constructor
    public Address(string street, string city, string state, string zip)
    {
        _street = street;
        _city = city;
        _state = state;
        _zip = zip;
    }

    // Method to return address as a string
    public override string ToString()
    {
        return $"{_street}, {_city}, {_state}, {_zip}";
    }
}