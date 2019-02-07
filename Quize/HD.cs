using System;

namespace Quize
{
    public class HD : ITelevisions
    {
        public HD(int big, int sale, int cable, bool mountable)
        {
            this.size = size;
            this.price = price;
            this.ports = ports;
            this.mountable = mountable;

        }
        public HD(int size, int ports)
        {


        }
        public int size { get; set; }

        public int price { get; set; }

        public int ports { get; set; }

        public bool mountable { get; set; } = false;

        public void TvOnOf(string Remote)
        {
          Console.WriteLine("The TV is on  using Physical Remote");

        }
        public void WallMounted()
        {
            bool mount = true || false;
         if (mount == false)
         {
            Console.WriteLine("Need TV Stands"); 
         }

        }
        


        


    }

}


