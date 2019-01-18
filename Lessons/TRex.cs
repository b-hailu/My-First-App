using System;

namespace Lessons
{
    public class TRex : Dinosaur
    {
        public override void EatFood()
        {
            Console.WriteLine("TRex eats");
        }

        public override void Move()

        {
            Console.WriteLine("TRex runs");
        }

        public override void Swim()
        {
            Console.WriteLine("TRex can swim");

        }
        public override void Horns()

        {
            Console.WriteLine(" TRexs have eight horns");
        }

        public override void SkinType()
        {
            Console.WriteLine("Feathery");
        }

        public override void Teeth()
        {
            Console.WriteLine("Razer Sharp");
        }
    }
}