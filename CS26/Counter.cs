using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS26
{
    public class Counter
    {
        private int _counter = 0;
        private string unit = "回";

        public Counter(int count) 
        {
            SetCount(count);   
        }

        public void Call() 
        {
            _counter++;
        }

        public void SetCount(int value) 
        {
            if(value >= 100) 
            { 
                _counter = 100;
                return;
            }
            //100以上の値が入らないことを保証する。
            _counter = value;
        }
        public int GetCount() 
        { 
            return _counter;
        }
    }
}
