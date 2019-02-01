using System;

namespace Quize
{
    public class LabResults

    {
        public int Voltage;
        public int Current;
        public int Resistance;

        public void ResultsLab()
        {
            int V = Voltage;
            int I = Current;
            int R = Resistance;
            V = I * R;
            I = V / R;
            R = V / I;
            Console.WriteLine("The Value of the voltage is " + V);
            Console.WriteLine("The Value of  current is " + I);
            Console.WriteLine("The Value of Resistance is " + R);

        }


    }
}