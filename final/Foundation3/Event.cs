public class Event
{
    private string _eventTitle;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;

    public Event(string eventTitle, string description, string date, string time, string streetAddress, string city, string stateOrProvince, string country)
    {
        _eventTitle = eventTitle;
        _description = description;
        _date = date;
        _time = time;
        _address = new Address(streetAddress, city, stateOrProvince, country);
    }

    public string Display()
    {
        return $"Title: {_eventTitle}\nDescription: {_description}\nDate: {_date}\nTime: {_time}\nAddress: {_address.Display()}";
    }

    public virtual string DisplayFullDetails()
    {
        return Display();
    }

    public virtual string DisplayShortDesc()
    {
        return Display();
    }

    public string GetTitle()
    {
        return $"{_eventTitle}";
    }

    public string GetDate()
    {
        return $"{_date}";
    }
}