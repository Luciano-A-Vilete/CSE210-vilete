using System;

class Program
{
    static void Main(string[] args)
    {
        // Create events
    var lecture = new Lecture("C# Inheritance", "A lecture on C# inheritance.", DateTime.Now, "10:00 AM", new Address("123 Main St", "Anytown", "Anystate", "12345"), "John Doe", 100);
    // var reception = new Reception(...);
    // var outdoorGathering = new OutdoorGathering(...);

    // Output marketing messages
    Console.WriteLine(lecture.GetStandardDetails());
    Console.WriteLine(lecture.GetFullDetails());
    Console.WriteLine(lecture.GetShortDescription());
    }
}