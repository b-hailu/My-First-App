using System;

namespace Lessons
{
    //Apple Extends Fruit
    public class Apple : Fruit
    {
        //Inherits EatFruit
        public override void EatFruit()
        {
            Console.WriteLine(" I Eat Apple");
        }
        public void Cobbler()
        {
            Console.WriteLine("I like Cobbler");
        }
    }
}