using System;

namespace Lessons
{
    public class IndexerExamples
    {
        private int[] _numbers = new int[5] { 100000, 200, 300, 400, 500 };

        public int Length
        {
            get { return _numbers.Length; }
        }
        public int this[int index]
        {
            get { return _numbers[index]; }
            set { _numbers[index] = value; }
        }

    }

}