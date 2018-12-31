using System;

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
    




        }

    }
}
