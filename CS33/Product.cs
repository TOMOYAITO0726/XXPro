using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS33
{
    public class Product :Database //継承と同じ
    {
        protected override void Execute()
        {
            Console.WriteLine("商品マスタの保存");
        }
    }
}
