using System;


namespace Lessons
{
    public abstract class Dinosaur : IPrehistoric

    {
        public string Travel { get; set; } = "Walk";// we can use Auto Property on this style

        public abstract void EatFood();

        public virtual void Move()

        {
            Console.WriteLine("The Dinosaur Moves");

        }
        public abstract void Swim();

        public virtual void Horns()

        {

            Console.WriteLine("The Dinosaur have horns");
        }

        public abstract void SkinType();
        public abstract void Teeth();

    }
}