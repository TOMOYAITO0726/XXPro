using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = 10;
            int b = 20;

            MessageBox.Show("a=" + a);
            MessageBox.Show("b=" + b);

            a = b;
            MessageBox.Show("a=" + a);
            MessageBox.Show("b=" + b);

            b = 30;
            MessageBox.Show("a=" + a);
            MessageBox.Show("b=" + b);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Other a = new Other();
            Other b = new Other();

            a.Value = 10;
            b.Value = 20;
            MessageBox.Show("a=" + a.Value);
            MessageBox.Show("b=" + b.Value);

            a = b;
            MessageBox.Show("a=" + a.Value);
            MessageBox.Show("b=" + b.Value);

            b.Value = 30;
            MessageBox.Show("a=" + a.Value);//30
            MessageBox.Show("b=" + b.Value);

        }
        private void OtherMethod(Other other) 
        {
            other.Value = 55;
        }
        private void ValueMethod(int other)
        {
            other = 55;
        }

        public class Other 
        {
            public int Value;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Other a = new Other();
            a.Value = 10;
            OtherMethod(a);
            MessageBox.Show("a=" + a.Value);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int a = 10;
            ValueMethod(a);
            MessageBox.Show("a=" + a);
        }
    }
}
