using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS29
{
    internal class Counter
    {
        private static int _count = 0;
        private int _value = 0;

        internal static void Call() { 
            _count++;
            //_value = 1;
            var ddd = 0;
            ddd = 1;
        }
        internal static int GetCount() 
        { 
            return _count; 
        }
        internal void DDD() 
        {
        
        }
    }
}
