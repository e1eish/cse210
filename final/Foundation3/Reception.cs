public class Reception : Event
{
    private string _rsvpEmail;

    public Reception(string rsvpEmail, string eventTitle, string description, string date, string time, string streetAddress, string city, string stateOrProvince, string country) : base(eventTitle, description, date, time, streetAddress, city, stateOrProvince, country)
    {
        _rsvpEmail = rsvpEmail;
    }

    public override string DisplayFullDetails()
    {
        return $"{base.Display()}\nRSVP Email: {_rsvpEmail}";
    }

    public override string DisplayShortDesc()
    {
        return $"Event Type: Reception\nTitle: {base.GetTitle()}\nDate: {base.GetDate()}";
    }
}