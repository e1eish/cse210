public class OutdoorGathering : Event
{
    private string _weather;

    public OutdoorGathering(string weather, string eventTitle, string description, string date, string time, string streetAddress, string city, string stateOrProvince, string country) : base(eventTitle, description, date, time, streetAddress, city, stateOrProvince, country)
    {
        _weather = weather;
    }

    public override string DisplayFullDetails()
    {
        return $"{base.Display()}\nWeather: The weather will be {_weather}";
    }

    public override string DisplayShortDesc()
    {
        return $"Event Type: Outdoor Gathering\nTitle: {base.GetTitle()}\nDate: {base.GetDate()}";
    }
}