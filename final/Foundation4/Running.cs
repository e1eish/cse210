public class Running : Activity
{
    private double _distance;

    public Running(string date, double length, double distance) : base(date, length)
    {
        _distance = distance;
    }

    public override string GetSummary()
    {
        string date = base.GetDate();
        double length = base.GetLength();
        double distance = Math.Round(GetDistance(), 1);
        double speed = Math.Round(GetSpeed(), 1);
        double pace = Math.Round(GetPace(), 1);

        return $"{date} Running ({length} minutes) - Distance: {distance} km, Speed: {speed} kph, Pace: {pace} min per km";
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return (GetDistance() / base.GetLength()) * 60;
    }

    public override double GetPace()
    {
        return base.GetLength() / GetDistance();
    }
}