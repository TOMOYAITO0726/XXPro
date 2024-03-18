using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<int> items = new List<int>();
            items.Add(10);
            items.Add(20);
            items.Add(30);
            items.Add(40);

            foreach (int item in items) 
            {
                if (item == 20)
                {
                    continue;
                }
                if (item == 30) 
                {
                    break;
                }
                MessageBox.Show(item.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<int> items = new List<int>();
            items.Add(10);
            items.Add(20);
            items.Add(30);
            items.Add(40);

            foreach (int item in items)
            {
                //items[1] = 22;
                //items.Remove(item);
                //MessageBox.Show(item.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<int> items = new List<int>();
            items.Add(10);
            items.Add(10);
            items.Add(30);
            items.Add(40);

            for (int i = 0; i < items.Count -1; i++) 
            {
                if (items[i] == 10) 
                { 
                    items.RemoveAt(i);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            List<int> items = new List<int>();
            items.Add(10);
            items.Add(10);
            items.Add(30);
            items.Add(40);
            items.Add(10);
            items.Add(10);


            for (int i =  items.Count - 1; i>=0; i--)
            {
                if (items[i] == 10)
                {
                    items.RemoveAt(i);
                }
            }
        }
    }
}
