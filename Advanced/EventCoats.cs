using System;
using System.Collections.Generic;
using System.Text;
using classwork;

namespace Advanced
{
    public delegate string MyCoat(string message);

    public class Coats
    {
        public event MyCoat MyEventCoat; // there is no underscore b/c it is not private
        public string MyResult { get; private set; }
        //default constructor
        public Coats()
        {
            this.MyEventCoat += new MyCoat(this.MyFavoriteCoat);
            MyResult = MyEventCoat("Trench");
        }

        public string MyFavoriteCoat(string message)
        {
            return " My Favorite Coat is " + message;
        }
    }
}
