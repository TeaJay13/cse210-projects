using System;

public class Program
{
    public static void Main()
    {
        Address address = new Address("123 Street", "City", "State", "12345");
        LectureEvent lecture = new LectureEvent("Lecture Title", "Lecture Description", "7/14/2023", "12:30pm", address, "Dr. Speaker", 50);
        ReceptionEvent reception = new ReceptionEvent("Reception Title", "Reception Description", "7/15/2023", "11:30am", address, "rsvp@example.com");
        OutdoorEvent outdoor = new OutdoorEvent("Outdoor Title", "Outdoor Description", "7/16/2023", "12:00pm", address, "Sunny");

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
