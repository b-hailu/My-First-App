using System;

namespace Lessons
{
    public class Lesson11
    {
        public const int MY_VALUE = 25;
        /* 
        method to demonestrate a constant
        which can not change its value;
        */
        public void SampleLesson11()


        {
            const string today = "Wednesday";
            //MY_VALUE = 35;//can not change the value
            //can use it with other variables

            int total = MY_VALUE * 2;
            Console.WriteLine(total);
            //can not change value of method level constant
            //today = "Friday";
        }

        public void UseParamas(params int[] items)

        {
            for (int i = 0; i < items.Length; i++)
            {
                Console.WriteLine(items[i] + " ");


            }
            Console.WriteLine();



        }

        public void UseParamas2(params object[] items)


        {
            for (int i = 0; i < items.Length; i++)
            {
                Console.WriteLine(items[i] + " ");
            }
            Console.WriteLine();





        }
        public void Optionalparam(string name, int age = 30)

        {
            System.Console.WriteLine(name + " is " + age + "yearsold.");
        }

        public void RefSample(ref int value)
        {
            value = value + 5;
            Console.WriteLine(value);
        }
        public void OutSample(string name, out string firstname, out string lastname, out string middle)

        {
            int myIndex = name.IndexOf(' ');
            firstname = name.Substring(0, myIndex);

            string otherName = name.Substring(myIndex + 1);
            int myOther = otherName.LastIndexOf(' ');

            middle = otherName.Substring(0, myOther);
            lastname = otherName.Substring(myOther + 1);


        }





    }
}