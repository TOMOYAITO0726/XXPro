using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS31
{
    internal class A1
    {
        private int _privateValue;
        protected int ProtectedValue;

        public A1(int value) 
        {
            _privateValue = value;
        }

        public virtual int GetData() 
        {
            return 100;
        }
    }
}
