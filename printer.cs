using System;
namespace classwork
{
    public class printer
    {
        //the followings are fields.
        string _model;
        string _size;
        string _discription;
        string _cablewired;
        string _wireless;
        //standard long way of property
        public string Model
        {
            get
            {
                return _model;
            }
            set
            {
                this._model = value;

            }

        }

        public string Size
        {
            get
            {
                return _size;

            }
            set
            {
                this._size = value;
            }

        }
        //short handed property + field; Auto property
        public string ConnectCable { set; get; }

        public printer() { }
        public printer(string model, string size)

        {
            this._size = size;
            this._model = model;
            ConnectCable = "Cablewired";

        }
        public printer(string size, string model, string discription, string cablewired, string wireless)

        {
            this._size = size;
            this._model = model;
            this._discription = discription;
            ConnectCable = cablewired;
            this._wireless = wireless;



        }

        //the following are method.
        public void Cablewired()
        {
            Console.WriteLine("Cable Wired");
        }

        public void Cablewired(bool isDirect)

        {
            if (isDirect)
            {
                Console.WriteLine("connect the cable");
            }
            else
            {
                Console.WriteLine("Connect Wireless");
            }

        }


        public void Wireless()
        {

        }

    }


}




































