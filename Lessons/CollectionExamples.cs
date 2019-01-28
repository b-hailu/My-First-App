using System.Collections;
using System.Collections.Generic;
using System;
namespace Lessons
{
    public class CollectionExamples

    {

        public void MyListExample()
        {
            List<Dinosaur> myDino = new List<Dinosaur>();
            myDino.Add(new TRex());
            myDino.Add(new TRex() { Travel = "Stomp" });
            myDino.Add(new Triceratops() { Travel = "Trample" });

            foreach (Dinosaur dino in myDino)
            {
                Console.WriteLine("This Dinos travel by{0}", dino.Travel);
                Console.WriteLine(dino);
            }

        }
        public void MyArrayListExample()
        {

            ArrayList MyArrayList = new ArrayList();
            MyArrayList.Add("hello");
            MyArrayList.Add("World");
            MyArrayList.Add(82);
            MyArrayList.Add(42);

            Console.WriteLine("Count = {0}", MyArrayList.Count);

            MyArrayList.Remove(82);
            MyArrayList.RemoveAt(0);



            MyArrayList.Add("Other");
            MyArrayList.Add("Stuff");

            foreach (Object item in MyArrayList)
            {
                Console.WriteLine("type = " + item);
            }

        }





    }
}