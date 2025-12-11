public class Cycling : Activity
{
    private double _speed;

    public Cycling(DateTime date, int durationMinutes,  double speed) : base (date, durationMinutes)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        return (_speed * durationMinutes) / 60;
    }

    public override double GetSpeed()
    {
        return _speed;
    }   

    public override double GetPace()
    {
        return 60 / _speed;
    }

    public override string GetSummary()
    {
        return $"{Date.ToString("dd MMM yyyy")} Cycling ({durationMinutes} min) - " +
               $"Distance: {GetDistance():F1} km, " +
               $"Speed: {GetSpeed():F1} kph, " +
               $"Pace: {GetPace():F1} min/km";
    }
}