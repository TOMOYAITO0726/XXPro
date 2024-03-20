using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS32
{
    public class Product :IDatabase //継承と同じ
    {
        public void Save() 
        {
            Console.WriteLine("商品マスタの保存");
        }
    }
}
