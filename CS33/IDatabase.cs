using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS33
{
    public  abstract class Database
    {
        public void Save() 
        {
            Before();

            //ここの処理のみ各サブクラスで変更する
            Execute();

            After();
        }

        protected abstract void Execute();
        private void Before() 
        {
        
        }
        private void After() 
        {
        
        }
    }
}
