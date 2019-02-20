using System;

namespace Quize
{
    public class ForKTeve : ITelevisions

    {
        string _remote;
        public ForKTeve(int size, int price)
        {


        }
        public ForKTeve(int size, float price, int ports, string remote, bool mountable)
        {
            this.size = size;
            this.price = price;
            this.ports = ports;
            this._remote = remote;
            this.mountable = mountable;

        }
        
       public int size { get; set; }

        public float price { get; set; }

        public int ports { get; set; }

        public string remote {get; set;}

        public bool mountable { get; set; } = true || false;

        public void TvOnOf()
       {
         Console.WriteLine("ForKTeve is on using Smart App");

       }
      

    }

}
