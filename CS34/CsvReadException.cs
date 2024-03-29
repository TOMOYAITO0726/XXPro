﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS34
{
    public sealed class CsvReadException :Exception //独自の例外クラス
    {
        public CsvReadException()
            : base("CSVの読み込みに失敗しました") 
        {
            
        }
        public CsvReadException(Exception exception)
            : base("CSVの読み込みに失敗しました", exception)
        {

        }

    }
}
