namespace classwork
{
    public class House
    {
        //the following are fields.
        string _foundation;
        string _roof;
        string _window;
        string _door;

       //standard long way of property
       public  string Foundation{
           get
           {
               return _foundation;
           }
           set 
           {
              this._foundation = value;
           }
       }



       public string window 
       {

           get
           {
               return _window;
           }
           set
           {
               this._window = value;
           }
       }
       //short handed property + field; Auto property
       public string Roof{get;set; }

       public string PaintDoor{get;set; }

        
        
        //the following are methods.
        
        public void Opendoor()
        {

        }



        public void CloseDoor()
        {

        }

    }



}
