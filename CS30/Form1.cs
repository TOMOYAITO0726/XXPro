using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS30
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            A2 a2 = new A2(3);
            a2.GetData(); //GetData()はA1（親クラス）のメソッドだが継承してるので使える
        }
    }
}
