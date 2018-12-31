using System;
namespace Lessons
{
    public class NumericTypes
    {
        /* integral - signedn*/
        // range - 128 to 127
        sbyte _mySbyteValue = 2;

        // range - 32,768 to 32,767
        short _myShortValue = 4;

        // range -2,147,483,648 to 2,147,483,647
        int _myIntvalue = 25000;
        // - 9,223,372,036,854,775,808 = 9,223,372,036,854,775,807
        long _myLongValue = 1_234_567L;
        long _myLongValue2 = 0x5F;
        /*Integral - Unsigned */
        //range 0 to 65,535
        ushort _myUnshortValue = 35;

        // range 0 to 4,294,967,295 I 
        uint _myUInt = 2345U;

        //range 0 to 18,446,744,073,709,551,615
        ulong _myUlongValue = 123456UL;

        /*Real Numbers */
        // range 3.4E +/- 38(7 digits)
        float _myFloatValue = -123.6589F;
        //range 1.7E +/- 308 (5 digits)
        double _myDoubleValue = 12.34;
        double _myuDoubleValue2 = 1E06;

        // range -7.9228E+24 to 7.9228E+24
        decimal _myDecimalValue = 13.234M;
        
        public void GetSomeType()
        {
            Console.WriteLine(3.0.GetType());
            Console.WriteLine(_myFloatValue.GetType());

        }





    }
}