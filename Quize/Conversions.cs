using System;

namespace Quize
{
    public class Conversions
    {
        public double Meter;
        public double MilliMeter;
        public double Centimeter;
        public double inches;
        public double yard;
        public double Feet;

        public void Length()
        {
            double m = 0.3048;
            double ml = 304.8;
            double cm = 30.48;
            double inch = 12;
            double y = 0.33333333333;
            double f = 1;

            Console.WriteLine("The length feet into Meter is " + m);
            Console.WriteLine("The length feet into Millimeter is " + ml);
            Console.WriteLine("The length feet into Centimeter is " + cm);
            Console.WriteLine("The length feet into Inches is " + inch);
            Console.WriteLine("The length feet into yard is " + y);



        }




    }

}