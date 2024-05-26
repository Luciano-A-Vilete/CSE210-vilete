class Program
{
    static void Main()
    {
        List<Activity> activities = new List<Activity>
        {
            new Running(DateTime.Now, 30, 5),
            new Cycling(DateTime.Now, 30, 20),
            new Swimming(DateTime.Now, 30, 20)
        };

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}