using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace teacher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //for (int i = 1; i <= 100; i++)
            //for (int i = 5; i <= 100; i+=5)
            for (int i = 1; i < 101; i++)
            {
                if (i % 5 == 0)
                {
                    listBox1.Items.Add(i);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt32(textBox1.Text);
            for (int i = 1; i < 101; i++)
            {
                if (i % number == 0)
                {
                    listBox1.Items.Add(i);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int min = Convert.ToInt32(textBox2.Text);
            int max = Convert.ToInt32(textBox3.Text);

            for (int i = min; i < max + 1; i++)
            {
                if (i % 5 == 0 && i != 0)
                {
                    listBox1.Items.Add(i);
                }
            }
        }
    }
}
