using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS28
{
    public class Database : IDisposable
    {
        private SqlDataAdapter _adapter = new SqlDataAdapter(); //この場合データベースの
                                                                //クラス自体がDisposeの対象となる

        public void Dispose()
        {
            if(_adapter != null) 
            {
                _adapter.Dispose();

            }
        }

        public void Insert() 
        {
            //SqlConnection connection = new SqlConnection();

            //try
            //{
            //    connection.Open(); //アプリケーションの外側のSQLに接続
            //                       //処理
            //}
            //catch(Exception ex) 
            //{ }
            //finally 
            //{
            //    connection.Dispose();

            //}
            using(SqlConnection connection = new SqlConnection()) 
            using(SqlCommand command = new SqlCommand())
            {
                //処理
            }


        }
    }
}
