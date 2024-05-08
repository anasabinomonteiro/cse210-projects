using System;

public class Fraction {
            private int  _top;
            private int _bottom;

            // Constructor without parameters(1/1)
            public Fraction()
            {
                _top = 1;
                _bottom = 1;
            }

            // Construtor with 1 parameter (start boottom 1)
            public Fraction(int wholeNumber)
            {
                _top = wholeNumber;
                _bottom = 1;
            }

            //Constructor with 2 parameters (top, bottom)
            public Fraction(int top, int bottom)
            {
                _top = top;
                _bottom = bottom;                
            }

            //Methods to return the representations
            public string GetFractionString() 
            {
                string msg = $"{_top}/{_bottom}";
                return msg;
            }

            public double GetDecimalValue() 
            {
                return (double)_top / (double)_bottom;
            }
        }