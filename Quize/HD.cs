using System;

namespace Quize
{
    public class HD : ITelevisions
    {
        string _remote;
        public HD(int big, float price, int cable, string remote, bool mountable)
        {
            this.size = size;
            this.price = price;
            this.ports = ports;
            this.mountable = mountable;
            this._remote = remote;

        }
        public HD(int size, int ports){}

       public string remote{get; set;} 

       public int size { get; set; }

        public float price { get; set; }

        public int ports { get; set; }

        

        public bool mountable { get; set; } = true ||false;

        public void TvOnOf()
        {
          Console.WriteLine("The HD TV is on  using Physical Remote");

        }
       
        


        


    }

}


