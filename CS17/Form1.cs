﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //for(int i = 0; i < 5; i++) 
            //{
            //    MessageBox.Show(i.ToString());
            //}
            for (int i = 5; i >= 0; i--) 
            {
                if(i == 4) 
                { 
                    continue;
                }
                if(i == 2) 
                { 
                    break;
                }
                MessageBox.Show(i.ToString());
            }
        }
    }
}
