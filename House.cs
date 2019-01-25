using System;

namespace classwork
{
    public class House
    {
        //the following are fields.
        string _foundation;
        string _roof;
        string _window = "Double pane";
        string _door;

        //standard long way of property
        public string Foundation
        {
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
        public string Roof { get; set; } = "Composite";

        public string PaintDoor { get; set; }

        public House() { }

        public House(string foundation, string window)
        : this(foundation, window, "shingles", "Green")
        { }

        public House(string foundation, string window, string roof, string doorPaint)
        {

            this._foundation = foundation;
            this._window = window;
            Roof = roof;
            PaintDoor = doorPaint;
            this._roof = roof;

        }

        //the following are methods.

        public void OpenDoor()

        {
            Console.WriteLine("The door opens");
        }


        public void OpenDoor(bool isExterior)

        {
            if (isExterior)
            {
                Console.WriteLine("Open front Door.");
            }
            else
            {
                Console.WriteLine("Open Bedroom door");
            }

        }




        public void CloseDoor()
        {

        }

    }



}
