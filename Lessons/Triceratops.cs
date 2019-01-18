using System;

namespace Lessons
{
    public class Triceratops : Dinosaur

    {
        public override void EatFood()
        {
            Console.WriteLine("Triceratops eat food");
        }

        public override void Swim()
        {
            Console.WriteLine("TRex Can Swim");

        }
        public override void Horns()

        {
            Console.WriteLine(" Triceratops have three horns");
        }

        public override void SkinType()
        {
            Console.WriteLine("Leathery");
        }

        public override void Teeth()
        {
            Console.WriteLine("Flat");
        }
    }
}