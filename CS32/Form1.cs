using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS32
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            IDatabase produt = new Product();
            IDatabase order = new Order();

            List<IDatabase> list = new List<IDatabase>();
            list.Add(produt);
            list.Add(order);
            foreach(var database in list) 
            {
                database.Save();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
