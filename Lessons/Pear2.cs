using System;


namespace Lessons
{
    public partial class Pear
    {
        public Pear(string message, string something)
        {
            Console.WriteLine(message + " is " + something);
            Peel();

        }
        void Peel()

        {
            Console.WriteLine("I peeled a Pear");

        }

    }
}