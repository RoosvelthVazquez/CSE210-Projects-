public abstract class Activity
{
    private DateTime _date;
    private int _durationMinutes;

    // constructor 
    public Activity(DateTime date, int durationMinutes)
    {
        _date = date;
        _durationMinutes = durationMinutes;
    }

    protected DateTime Date => _date;
    public int durationMinutes => _durationMinutes;

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public virtual string GetSummary()
    {
        return $"{_date.ToString("dd MMM yyyy")} {GetType().Name} ({_durationMinutes} min)";
    }
}