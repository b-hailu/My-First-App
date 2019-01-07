using System;

namespace Lessons
{
    public class StatementExample
    {
        public void SampleIf()

        {
            int num = 10;
            Console.WriteLine("Before If statment");
            if (num > 9)

            {
                Console.WriteLine("If statment was valid");

            }
            Console.WriteLine("Ater If statment");


        }
        public void SampleIfElse()

        {
            int value = 15;
            Console.WriteLine("Before If statment");
            if (value >= 15)

            {
                Console.WriteLine("If Statment Execuites");
            }
            else
            {
                Console.WriteLine("Else Statment Execuites ");
            }
            Console.WriteLine("After if statment");
        }

        public void sampleIfChain()

        {
            int num = 15;
            Console.WriteLine("Before If");
            if (num > 15)

            {
                Console.WriteLine("If execuites");
            }
            else if (num == 5)
            {
                Console.WriteLine("Else If execuites");

            }
            Console.WriteLine("After If");
        }

        public void SampleIfOr()
        {

            int num1 = 15, num2 = 20;
            Console.WriteLine("Before If");
            if (num2 > 25 || num1 == 15)
            {
                Console.WriteLine("If execuites");
            }
            else
            {
                Console.WriteLine("else execuites");
            }
            Console.WriteLine("After If");
        }

        public void SampleIfAnd()
        {
            int num1 = 15, num2 = 20;
            Console.WriteLine("Before If");
            if (num1 < 20 && num2 > 19)
            {
                Console.WriteLine("If execuites");
            }
            else
            {
                Console.WriteLine("Else execuites");
            }
            Console.WriteLine("After If");
        }

        public void SampleConditional()
        {

            int num = 20;
            string word = (num < 25) ? "its is less " : "its more";
            Console.WriteLine(word);
        }

        public void sampleSwitch(int num)
        {
            switch (num)
            {
                case 1:
                case 5:
                    Console.WriteLine("1 or 5 was chosen");
                    break;
                case 10:
                    Console.WriteLine("10 was chosen");
                    break;
                case 15:
                    Console.WriteLine("15 was chosen");
                    break;
                case 20:
                    Console.WriteLine("20 was chosen");
                    break;
                default:
                    Console.WriteLine("no correct number was chosen");
                    break;
            }
        }

        public void SampleWhile()
        {
            int num = 0;
            while (num < 10)

            {
                Console.WriteLine("Number = {0}", num);
                num++;
            }

        }
        public void SampleDoWhile()
        {
            int num = 0;
            do
            {
                Console.WriteLine("Number = {0}", num);
                num++;
            } while (num < 10);
        }
        public void SampleFor()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("number = {0}", i);
            }
        }
        public void Foreach()
        {
            foreach (char ch in "Something")
            {
                Console.WriteLine(ch);
            }
        }
        public string JumpStatementExample(string day)
        {
            switch (day)
            {
                case "Sunday":
                    goto default;
                case "Monday":
                case "Tuesday":
                      return "Test Something Tuesday";
                default:
                      return "Test Nothing";
            }
        }

    }
}










