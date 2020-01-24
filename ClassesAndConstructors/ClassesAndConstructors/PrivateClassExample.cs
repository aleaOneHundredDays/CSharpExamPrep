using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesAndConstructors
{
    class PrivateClassExample
    {
    }

    public class Counter
    {
        private Counter() { }
        public static int currentCount;
        public static int IncrementCount()
        {
            return ++currentCount;
        }
    }
}
