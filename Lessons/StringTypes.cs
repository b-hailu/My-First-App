using System;
using classwork;
using System.Text;

namespace Lessons
{
    public class StringTypes
    {
        private string _testString = "Test String";
        private string _secondString = "Second String";

        public void SampleString()
        {
            Console.WriteLine(_testString);



        }
        public void addString()
        {
            Console.WriteLine(_testString + _secondString);
        

        }
        public string StringBuilderExample(string value1, string value2, string value3)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(value1)
            .Append(" ").Append(value2)
            .Append(" ").Append(value3);

            return builder.ToString();

        }

        public void ChartTypeExample()
        
        {
            char ab = 'A';
            char de = 'b';
            char copyrightSymbole = '\u00a9';
            char hi = (char)88;

            Console.WriteLine(hi);
            Console.WriteLine(ab == de);

           
        }

        public void EscapeExample()
        
        {
           Console.WriteLine("our Instructor name is Roger o\'Dell ");
           Console.WriteLine("This is an \a Alert");
           Console.WriteLine("some sort of new line \nthat I cannot figure out.");
           Console.WriteLine("A sort of tab \t is around here somewhere.");
        }

        public void placeHolderExample()
        
        {
            Console.WriteLine("This string is {0}", "Cool");
            Console.WriteLine("We can use ints like {0} and {1}", 15, 10);
            Console.WriteLine("I like {1} more than {0}, but not as much as {2}", "Sad", "Happy", "Funny");

        }

        public void ArraySample()
        
        {
          
          string[] cars = new string[3];
          cars[0] = "Camaro";
          cars[1] = "mustang";
          cars[2] = "chevelle";

          // or this version
          string[] names = {"Tom", "Roger", "Matt"};
          Console.WriteLine(cars[1]);
           Console.WriteLine(cars[0]);
           Console.WriteLine(names[0]);


        }
        public void MyHouseArray()
        
        {
           House house1 = new House();
           house1.PaintDoor = "Green";
           House house2 = new House();
           house2.PaintDoor = "Blue";

           House[] houseList = {house1, house2 };
           Console.WriteLine(houseList[0].PaintDoor);
           Console.WriteLine(houseList[1].PaintDoor);


        }

        public void multiArraySample()
        
        {
        
        int[,] myIntArray = new int[2,2];
        myIntArray[0,0] = 5;
        myIntArray[0,1] = 10;
        myIntArray[1,0] = 2;
        myIntArray[1,1] = 4;

        Console.WriteLine(myIntArray[1,0]);
        Console.WriteLine(myIntArray[0,1]);
        Console.WriteLine(myIntArray[0,0]);
        Console.WriteLine(myIntArray[1,1]);

        }

    }
}