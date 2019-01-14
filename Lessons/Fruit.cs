using System;

namespace Lessons
{
    public class Fruit
    {
        public virtual void EatFruit()
        {
            Console.WriteLine("I Eat Fruit");
            ThrowFruit();

        }

        private void ThrowFruit()

        {
            Console.WriteLine("Throwing Fruit");


        }
    }
}