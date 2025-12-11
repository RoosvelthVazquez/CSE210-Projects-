public class Running : Activity
{
    private double _distance;

    public Running(DateTime date, int durationMinutes, double distance) : base (date, durationMinutes)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return (_distance / durationMinutes) * 60;
    }   

    public override double GetPace()
    {
        return durationMinutes / _distance;
    }

    public override string GetSummary()
    {
        return $"{Date.ToString("dd MMM yyyy")} Running ({durationMinutes} min) - " +
               $"Distance: {GetDistance():F1} km, " +
               $"Speed: {GetSpeed():F1} kph, " +
               $"Pace: {GetPace():F1} min/km";
    }
}