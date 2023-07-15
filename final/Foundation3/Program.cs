using System;

public class Program
{
    public static void Main()
    {
        Address address = new Address("123 Street", "City", "State", "12345");
        LectureEvent lecture = new LectureEvent("Lecture Title", "Lecture Description", DateTime.Now, TimeSpan.FromHours(10), address, "Dr. Speaker", 50);
        ReceptionEvent reception = new ReceptionEvent("Reception Title", "Reception Description", DateTime.Now, TimeSpan.FromHours(14), address, "rsvp@example.com");
        OutdoorEvent outdoor = new OutdoorEvent("Outdoor Title", "Outdoor Description", DateTime.Now, TimeSpan.FromHours(18), address, "Sunny");

        Event[] events = new Event[] { lecture, reception, outdoor };

        foreach (Event e in events)
        {
            Console.WriteLine(e.GetStandardDetails());
            Console.WriteLine(e.GetFullDetails());
            Console.WriteLine(e.GetShortDescription());
            Console.WriteLine("");
        }
    }
}
