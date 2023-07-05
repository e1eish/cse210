public class Activity
{
    private string _date;
    private double _length;

    public Activity(string date, double length)
    {
        _date = date;
        _length = length;
    }

    public virtual string GetSummary()
    {
        return $"{_date} Type ({_length} minutes) - Distance: ~ km, Speed: ~ kph, Pace: ~ min per km";
    }

    public double GetLength()
    {
        return _length;
    }

    public string GetDate()
    {
        return _date;
    }

    public virtual double GetDistance()
    {
        return 0;
    }

    public virtual double GetSpeed()
    {
        return 0;
    }

    public virtual double GetPace()
    {
        return 0;
    }
}