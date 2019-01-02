using System;
 using Lessons;

namespace classwork
{
    //class is a blue print of an object.
    class Program
    //has no access modifier.if ther is no access modefier it is a default.
    {


        static void Main(string[] args)
        {//static  means no copies it is only one.
            Console.WriteLine("Hello World!");
            /* console is a class and writeline is a method with a 
            parameter*/
            printer myPrinter= new printer();
            myPrinter.ConnectCable = "connect";
            myPrinter.Cablewired();
            Console.WriteLine(myPrinter.ConnectCable);
            MyNumericExamples();




        }
        static void MyNumericExamples()
        {
          NumericTypes myTypes = new NumericTypes();
          myTypes.GetSomeType();
          int something = myTypes.ConvertFloatToInt(35.9F);
          Console.WriteLine(something);

          Console.WriteLine(myTypes.LongFromInt(5600));
          myTypes.BasicMath();
          myTypes.CheckOperators();
          myTypes.IncrementDecrement();
          myTypes.SpecialValues();
          myTypes.comparisonOperators();
          

        }
        static void otherNumericExamples()
        {
           NumericTypes myTypes = new NumericTypes();
           myTypes.OtherOperators();
           
        }

        

            // created and objects instance of House called myHouse
            House myHouse = new House();
            // this sets the value of Red to the object
            
        


        }



    }

