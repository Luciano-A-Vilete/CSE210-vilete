using System;

public class Fraction
{
    private int TopNumber;
    private int BottomNumber;

    public Fraction(){
        TopNumber = 1;
        BottomNumber = 1;
    }

    public Fraction(int TopNumber){
        this.TopNumber = TopNumber;
        BottomNumber = 1;
    }

    public Fraction(int TopNumber, int BottomNumber){
        this.TopNumber = TopNumber;
        this.BottomNumber = BottomNumber;
    }

    public string GetFractionString()
    {
        string text = $"{TopNumber}/{BottomNumber}";
        return text;
    }

    public double GetDecimalValue()
    {
        return (double)TopNumber / (double)BottomNumber;
    }
}