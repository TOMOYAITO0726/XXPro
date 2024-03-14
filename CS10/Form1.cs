using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double d1 = 1.4d;
            int aaa = (int)d1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //string value = "10";
            //int intValue = int.Parse(value);

            string value = "aaa";
            int intValue = int.Parse(value);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string value = "10.4";
            int intValue;
            bool result = int.TryParse(value, out intValue);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string value = null;
            int intValue = Convert.ToInt32(value);
        }
    }
}
