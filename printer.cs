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
        
        public string Size{
            get{
                return _size;

            }
            set{
                this._size=value;
            }

        }
        //short handed property + field; Auto property
        public string ConnectCable{set; get; }
    
        //the following are method.
        public void Cablewired()
        {
        Console.WriteLine("Cable Wired");
        }

        public void Wireless()
        {

        }

    }
        
        
}
        








    
        

        

        

        






    












