using System;

namespace Quize
{
    public class Samsung : ITelevisions

    {
        public Samsung(int size, int price)
        {


        }
        public Samsung(int size, int price, int ports, bool mountable)
        {
            this.size = size;
            this.price = price;
            this.ports = ports;
            this.mountable = mountable;

        }
        
       public int size { get; set; }

        public int price { get; set; }

        public int ports { get; set; }

        public bool mountable { get; set; } = true || false;

        public void TvOnOf(string Remote)
       {
         Console.WriteLine("The Tv is on using Smart App");

       }
       public void WallMounted()
        {
            bool mount = true || false;
         if (mount == true)
         {
            Console.WriteLine("Need tools for installation"); 
         }

        }

    }

}
