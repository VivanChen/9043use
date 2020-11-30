using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<int> mylist = new List<int>();
            Random str = new Random();
            do
            {
                int number = str.Next(1, 50);
                if (mylist.Contains(number) == false)
                {
                    mylist.Add(number);
                }
            } while (mylist.Count < 6);
            mylist.Sort();
            listBox1.DataSource = mylist;

        }
    }
}
