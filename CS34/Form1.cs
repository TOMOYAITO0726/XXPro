using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS34
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Counter c = new Counter();
            c.GetData(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Counter c = new Counter();
                c.GetData(2);
            }
            catch(ArgumentOutOfRangeException aex)  
            {
                MessageBox.Show("AAA!! " + aex.Message);
            }
            catch(Exception ex)  
            {
                MessageBox.Show("ボタン２を押してエラー！");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try 
            {
                Counter c = new Counter();
                c.GetData2(2);
            }catch(Exception ex) 
            {
                Console.WriteLine(ex.InnerException.Message); //ログにはInnerException.Messageを表示
                                                              //インデックスが範囲を超えています。負でない値で、コレクションのサイズよりも小さくなければなりません。
                                                              //パラメーター名: indexが出力に表示される
                MessageBox.Show(ex.Message); //表では、メッセージ"CSVの読み込みに失敗しました"を表示

            }

        }
    }
}
