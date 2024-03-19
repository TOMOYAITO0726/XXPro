using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS27
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            var counter = new Counter(1);
            counter.Count = 555; //Countプロパティを呼び出して値を設定
            MessageBox.Show(counter.Count.ToString()); //Countプロパティを呼び出して、値を取得
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
