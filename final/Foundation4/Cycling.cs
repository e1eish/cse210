public class Cycling : Activity
{
    private double _speed;

    public Cycling(string date, double length, double speed) : base(date, length)
    {
        _speed = speed;
    }

    public override string GetSummary()
    {
        string date = base.GetDate();
        double length = base.GetLength();
        double distance = Math.Round(GetDistance(), 1);
        double speed = Math.Round(GetSpeed(), 1);
        double pace = Math.Round(GetPace(), 1);

        return $"{date} Cycling ({length} min) - Distance: {distance} km, Speed: {speed} kph, Pace: {pace} min per km";
    }

    public override double GetDistance()
    {
        return (GetSpeed() / 60) * base.GetLength();
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return base.GetLength() / GetDistance();
    }
}