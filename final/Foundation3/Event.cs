public abstract class Event
{
    // Private member variables
    private string _title;
    private string _description;
    private DateTime _date;
    private string _time;
    private Address _address;

    // Protected properties for derived classes to use
    protected string Title { get { return _title; } }
    protected DateTime Date { get { return _date; } }

    // Constructor
    public Event(string title, string description, DateTime date, string time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    // Method to return standard details of an event
    public virtual string GetStandardDetails()
    {
        return $"Title: {_title}\nDescription: {_description}\nDate: {_date}\nTime: {_time}\nAddress: {_address}";
    }

    // Abstract methods to be implemented by derived classes
    public abstract string GetFullDetails();
    public abstract string GetShortDescription();
}