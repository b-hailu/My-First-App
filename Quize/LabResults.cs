using System;

namespace Quize
{
    public class LabResults

    {
        public double Voltage;
        public double Current;
        public double Resistance;

        public void CercuiteCalc()
        {
         
         
         
          double V = Current * Resistance;
          double I = Voltage / Resistance;
          double R = Voltage/ Current;
          Console.WriteLine("The Value of the Voltage is {0} \n the Value of the Current is {1} \n the Value of  the Resistance is {2}"  , V, I, R);

          


         
        }

    }

        
    }


    
