public class Lecture : Event
{
    // Private member variables
    private string _speaker;
    private int _capacity;

    // Constructor
    public Lecture(string title, string description, DateTime date, string time, Address address, string speaker, int capacity)
        : base(title, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    // Method to return full details of a lecture
    public override string GetFullDetails()
    {
        return $"{GetStandardDetails()}\nSpeaker: {_speaker}\nCapacity: {_capacity}";
    }

    // Method to return short description of a lecture
    public override string GetShortDescription()
    {
        return $"Lecture: {Title} on {Date}";
    }
}