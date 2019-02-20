using System;

namespace Quize
{
    public struct LEDTV

    {
        private int _size;
         float _price;
         int _ports;
         bool _mountable;
         string _remote;

        public LEDTV(int size, float price, int ports, bool mountable, string remote)
        {
           this._size = size; 
           this._price = price;
           this._ports = ports;
           this._mountable = mountable;
           this._remote = remote;
        } 

        public int Size 

        { 
         get
         {
          return _size;
         }
         set
         {
            _size = 50;
         }
        
        }

        public float Price
        {
            get 
            {

            return _price; 
            
            }
            set
            {
                _price = 2500.50F;
            }
        }
        public int Ports
        {
            get 
            {

            return _ports; 
            
            }
            set
            {
                _ports = 2;
            }
        }
        public bool Mountable
        {
            get 
            { 
                
            return _mountable; 
            
            }
            set
            {
                _mountable = true;
            }

        }
        public string Remote
        {
         get
         {
             return _remote;
         }
         set
         {
           _remote = "uses Physical Remote and Smart App";
         }

        }
        public void TVModel()
        
        {
         Console.WriteLine("This is your LEDTV");
        }
        
    }
}