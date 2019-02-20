using System;

namespace Quize
{
    public class LeapYear
    
    {
       
        public void YearValidate()
     
     
        {
             int Year = 2019;
             
         if (Year % 400 == 0 || (Year % 100 != 0 && (Year % 4 == 0))) 
         {
            Console.WriteLine("it is a Leap Year");
         }
         else 
         {
            Console.WriteLine("is not a Leap Year");
         }
         
          
         
                  
          
        }
    }
}



