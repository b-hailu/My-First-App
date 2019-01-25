using System;

namespace Lessons
{
    public partial class Pear
    {
        public Pear(string message)
        {
            Console.WriteLine(message);
            Peel();
            Color();

        }
        partial void peel();
        partial void Color();
    }

}