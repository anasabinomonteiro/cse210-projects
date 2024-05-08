using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        // Instances
        Fraction frac1 = new Fraction();                
        Console.WriteLine(frac1.GetFractionString()); //(1/1)
        Console.WriteLine(frac1.GetDecimalValue()); //(1)

        Fraction frac2 = new Fraction(8);               
        Console.WriteLine(frac2.GetFractionString()); //(8/1)
        Console.WriteLine(frac2.GetDecimalValue()); //(8)

        Fraction frac3 = new Fraction(2, 5);            
        Console.WriteLine(frac3.GetFractionString()); //(2/5)
        Console.WriteLine(frac3.GetDecimalValue()); //(0,40)

        Fraction frac4 = new Fraction(2, 7);          
        Console.WriteLine(frac4.GetFractionString()); // (2/7)
        Console.WriteLine(frac4.GetDecimalValue()); //(0,2857142....)
    }
}