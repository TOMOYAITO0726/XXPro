using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            byte byteValue = 255;
            //byte byteValue2 = 256;

            short shortValue = 10;
            short shortMax = short.MaxValue;
            //ushort ushortValue = -1;

            int intValue = -10;
            uint uintValue = 10;

            long longValue = -10;
            ulong ulongValue = 10;

            float floatValue = 1.2345f;
            double doubleValue = 1.2345d;
            decimal decimalValue = 1.2345m;

            bool boolValue = true;
            if(boolValue == true) 
            {
                //Tureの時
            }
            if(boolValue == false) 
            {
                //Falseの時
            }
            if (boolValue) 
            {
                //Trueの時
            }
            if (!boolValue) 
            {
                //Falseの時
            }

        }
    }
}
