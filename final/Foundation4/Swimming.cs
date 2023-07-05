public class Swimming : Activity
{
    private double _numberOfLaps;

    public Swimming(string date, double length, double numberOfLaps) : base(date, length)
    {
        _numberOfLaps = numberOfLaps;
    }

    public override string GetSummary()
    {
        string date = base.GetDate();
        double length = base.GetLength();
        double distance = Math.Round(GetDistance(), 1);
        double speed = Math.Round(GetSpeed(), 1);
        double pace = Math.Round(GetPace(), 1);

        return $"{date} Swimming ({length} minutes) - Distance: {distance} km, Speed: {speed} kph, Pace: {pace} min per km";
    }

    public override double GetDistance()
    {
        return _numberOfLaps * 50 / 100;
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