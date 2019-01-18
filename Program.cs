using System;
using Lessons;
using Quize;


namespace classwork
{
    //class is a blue print of an object.
    class Program
    //has no access modifier.if ther is no access modefier it is a default.
    {


        static void Main(string[] args)
        {//static  means no copies it is only one.
            //Console.WriteLine("Hello World!");
            /* console is a class and writeline is a method with a 
            parameter*/
            //printer myPrinter= new printer();
            //myPrinter.ConnectCable = "connect";
            //myPrinter.Cablewired();
            //Console.WriteLine(myPrinter.ConnectCable);
            //MyNumericExamples();
            //MyStringExample();
            //StatementSamples();
            // HouseSample();
            //StructSample();
            //Quize();
            //FruitSample();
            //ParamSample();
            //ModifierExamples();
            //Lesson12();
            AbstractDemo();


        }
        static void AbstractDemo()

        {
            TRex trex = new TRex();
            Triceratops triceratops = new Triceratops();

            trex.EatFood();
            trex.Move();

            trex.Swim();
            trex.Horns();

            trex.SkinType();
            trex.Teeth();

            triceratops.EatFood();
            triceratops.Move();

            triceratops.Swim();
            triceratops.Horns();

            triceratops.SkinType();
            triceratops.Teeth();









        }

        static void Lesson12()

        {
            double temp = Utility.CelsiusToFahrenheit("43.2");
            Console.WriteLine(temp);
            double temp2 = Utility.FahrenheitToCelsius("109.76");
            Console.WriteLine(temp2);



        }

        static void ModifierExamples()

        {
            int test = 14;
            Lesson11 myLesson = new Lesson11();
            myLesson.RefSample(ref test);
            Console.WriteLine(test);


            string first, second, middle;
            myLesson.OutSample("John Doe", out first, out second, out middle);

            Console.WriteLine(first);
            Console.WriteLine(second);
            Console.WriteLine(middle);

        }
        static void ParamSample()

        {
            Lesson11 lesson = new Lesson11();
            lesson.UseParamas(10, 3, 24, 36, 45, 120);
            lesson.UseParamas();
            int[] intArray = { 2, 3, 4, 5, 6 };

            lesson.UseParamas(intArray);
            lesson.UseParamas2(1, "happy", false, 34.5F);

            lesson.Optionalparam("Bella");
            lesson.Optionalparam("Mark", 19);



        }



        static void FruitSample()

        {
            Apple myApple = new Apple();
            myApple.EatFruit();


            Fruit myFruit = new Apple();
            myFruit.EatFruit();
            myApple.Cobbler();

            Orange myOrange = new Orange();
            myOrange.EatFruit();

            RanchStyle ranch = new RanchStyle("Stone", "Triple Pane", "Composite", "Blue");
            ranch.OpenDoor();
            Console.WriteLine(ranch.Roof);
        }
        static void StructSample()

        {
            BookSample bookSample = new BookSample(4.99m, "Zombie Fallout", "Mark Tufo");
            Console.WriteLine("The book " + bookSample.title + " by " + bookSample.author + " is $" + bookSample.price);


        }

        static void Printer()

        {
            printer myPrinter = new printer("multiple wire", "for Laptop");

        }
        static void HouseSample()

        {
            House MyHouse = new House("concrete", "triple pane");

            Console.WriteLine(MyHouse.PaintDoor);
            Console.WriteLine(MyHouse.Foundation);
            MyHouse.OpenDoor(true);


        }

        static void StatementSamples()
        {
            StatementExample se = new StatementExample();
            //se.SampleIf();
            //se.SampleIfElse();
            //se.sampleIfChain();
            //se.SampleIfOr();
            //se.SampleIfAnd();
            //se.SampleConditional();
            //se.sampleSwitch(10);
            //se.sampleSwitch(15);
            //se.sampleSwitch(1);
            //se.SampleWhile();
            //se.SampleDoWhile();
            //se.SampleFor();
            //se.Foreach();
            // string mystring = se.JumpStatementExample("Sunday");
            //Console.WriteLine(mystring);
            //bottlessong();
            //se.SampleDays(DaysOfWeek.Sun);
            //se.SampleDays(DaysOfWeek.Thur);
            //se.SampleYear(MonthsOfYear.Apr);
            //se.SampleYear(MonthsOfYear.Jan);
            // se.SampleYear(MonthsOfYear.Sep);






        }
        static void bottlessong()
        {
            BottlesOfBeer beer = new BottlesOfBeer();
            string song = beer.BottlesOfBeerSong();
            Console.WriteLine(song);
        }


        static void MyStringExample()
        {
            StringTypes myTypes = new StringTypes();
            myTypes.SampleString();
            myTypes.addString();
            string words = myTypes.StringBuilderExample("Hello", "c Sharp", "Class");

            Console.WriteLine(words);
            myTypes.ChartTypeExample();
            myTypes.EscapeExample();
            myTypes.placeHolderExample();
            myTypes.ArraySample();
            myTypes.MyHouseArray();
            myTypes.multiArraySample();
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
        public static void Quize()

        {
            QuizeClass1 myGrade = new QuizeClass1();
            string Grade = myGrade.SampleGrade("E");
            Console.WriteLine(Grade);
            myGrade.QuizeMath();
        }
        public static void QuizeMath()
        {

        }








        // created and objects instance of House called myHouse
        House myHouse = new House();
        House house1 = new House();


        // this sets the value of Red to the object




    }



}

