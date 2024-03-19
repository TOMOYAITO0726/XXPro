using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS31
{
    class A2 : A1
    {
        public A2(int value) : base(value) //親クラスのコンストラクタを呼び出す
        {
            base.ProtectedValue = 3;
        }
        public override int GetData()
        {
            var value = base.GetData();
            value += 3;
            return 333;
        }
    }
}
