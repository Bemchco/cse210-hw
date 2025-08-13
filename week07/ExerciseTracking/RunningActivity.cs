public class RunningActivity : Activity
{
    private double _distanceKm;

    public RunningActivity(DateTime date, int lengthMinutes, double distanceKm)
        : base(date, lengthMinutes)
    {
        _distanceKm = distanceKm;
    }

    public override double GetDistance() => _distanceKm;
    public override double GetSpeed() => (_distanceKm / LengthMinutes) * 60;
    public override double GetPace() => LengthMinutes / _distanceKm;
}
