using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS27
{
    public class Counter
    {
        //private int _count = 0;

        public Counter(int count)
        {
            //SetCount(count);
            Count = count;
        }
        //public int Count 
        //{ 
        //    get 
        //    { 
        //        return _count; 
        //    }
        //    set 
        //    {

        //        if (value >= 100)
        //        {
        //            _count = 100;
        //            return;
        //        }
        //        //100以上の値が入らないことを保証する。
        //        _count = value;
        //    }
        //}

        public int Count { get; set; } = 0; //自動実装プロパティ（値に対して特にチェックロジック
                                        //などを記述しない場合に記述、privateフィールドの記述を
                                        //省略できる）
        //public int Count { get; private set; } //自動実装プロパティ


        public void Call()
        {
            Count++;
        }

        //public void SetCount(int value)
        //{
        //    if (value >= 100)
        //    {
        //        _count = 100;
        //        return;
        //    }
        //    //100以上の値が入らないことを保証する。
        //    _count = value;
        //}
        //public int GetCount()
        //{
        //    return _count;
        //}
    }
}
