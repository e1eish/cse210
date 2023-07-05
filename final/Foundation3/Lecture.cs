public class Lecture : Event
{
    private string _speakerName;
    private int _capacity;

    public Lecture(string speakerName, int capacity, string eventTitle, string description, string date, string time, string streetAddress, string city, string stateOrProvince, string country) : base(eventTitle, description, date, time, streetAddress, city, stateOrProvince, country)
    {
        _speakerName = speakerName;
        _capacity = capacity;
    }

    public override string DisplayFullDetails()
    {
        return $"{base.Display()}\nSpeaker: {_speakerName}\nCapacity: {_capacity} people";
    }

    public override string DisplayShortDesc()
    {
        return $"Event Type: Lecture\nTitle: {base.GetTitle()}\nDate: {base.GetDate()}";
    }
}