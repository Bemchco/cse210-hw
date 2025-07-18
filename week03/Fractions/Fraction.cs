public class Fraction
{
    private int _numerator;
    private int _denominator;

    public Fraction()
    {
        _numerator = 1;
        _denominator = 1;
    }

    public Fraction(int wholeNumber)
    {
        _numerator = wholeNumber;
        _denominator = 1;
    }


    public Fraction(int topNumber, int bottomNumber)
    {
        _numerator = topNumber;
        _denominator = bottomNumber;
    }


    public string GetNumbers()
    {
        string text = $"{_numerator}/{_denominator}";
        return text;
    }
    
    public double ToDecimal()
    {
        return (double)_numerator / _denominator;
    }


}