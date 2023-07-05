using System;

class Program
{
    static void Main(string[] args)
    {
        Lecture lecture = new Lecture("Abraham Daniel", 100, "Sufficient Time", "She thought there'd be sufficient time if she hid her watch.", "22/10/2023", "10:30 a.m.", "123 Main St.", "Rexburg", "Idaho", "USA");
        Reception reception = new Reception("reception@email.com", "Dentists Against Chewing Bricks", "My dentist tells me that chewing bricks is very bad for your teeth.", "05/08/2023", "1:00 p.m.", "555 West Ave.", "Oxford", "Oxfordshire", "England");
        OutdoorGathering outdoorGathering = new OutdoorGathering("cloudy", "Nail Beds", "Andy loved to sleep on a bed of nails.", "14/09/2023", "2:45 p.m.", "987 Abendessen Blvd.", "Essen", "Düsseldorf", "Germany");

        Console.WriteLine(lecture.Display());
        Console.WriteLine();
        Console.WriteLine(lecture.DisplayFullDetails());
        Console.WriteLine();
        Console.WriteLine(lecture.DisplayShortDesc());

        Console.WriteLine("\n");

        Console.WriteLine(reception.Display());
        Console.WriteLine();
        Console.WriteLine(reception.DisplayFullDetails());
        Console.WriteLine();
        Console.WriteLine(reception.DisplayShortDesc());

        Console.WriteLine("\n");

        Console.WriteLine(outdoorGathering.Display());
        Console.WriteLine();
        Console.WriteLine(outdoorGathering.DisplayFullDetails());
        Console.WriteLine();
        Console.WriteLine(outdoorGathering.DisplayShortDesc());
    }
}