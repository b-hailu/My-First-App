using System;

namespace Quize
{
    public class Conversions
    {
        
         
        public double MilliMeter;
        public double Meter;
        public double Centimeter;
        public double inches;
        public double yard;
        public double Feet;

        public void Length()
        {
            
             double ml  = Feet * MilliMeter;
            double m = Feet * Meter;
            double cm = Feet * Centimeter;
            double inch = Feet * inches;
            double y = Feet * yard;
            
            

        Console.WriteLine(" the value of the conversion feet to Millimeter is {0}ml \n feet to Meter is {1}m \n feet to Centimeter is {2}cm \n feet to inches is {3}inch \n feet to yard is {4}y",  ml, m, cm,inch, y);
           
        }
    }

}