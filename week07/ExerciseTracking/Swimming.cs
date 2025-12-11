public class Swimming : Activity
{
    private int _laps;
    private const double LapLengthKm = 0.05;

    public Swimming(DateTime date, int durationMinutes, int laps) : base (date, durationMinutes)
    {
        _laps = laps; 
    }

    public override double GetDistance()
    {
        return _laps * LapLengthKm;
    }

    public override double GetSpeed()
    {
        return(GetDistance() / durationMinutes) * 60;
    }

    public override double GetPace()
    {
        return durationMinutes / GetDistance();
    }

    public override string GetSummary()
    {
        return $"{Date.ToString("dd MMM yyyy")} Swimming ({durationMinutes} min) - " +
               $"Laps: {_laps}, Distance: {GetDistance():F1} km, " +
               $"Speed: {GetSpeed():F1} kph, Pace: {GetPace():F1} min/km";
    }
}