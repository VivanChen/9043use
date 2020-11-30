using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0413work
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
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
            listBox1.Items.Clear();
            for (int i = 1; i < 101; i++)
            {
                if (i%Int32.Parse(textBox1.Text)==0)
                {
                    listBox1.Items.Add(i);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            int a = Convert.ToInt32(textBox2.Text);
            int b = Convert.ToInt32(textBox3.Text);

            if (a > b)
            {
                for (int i = b; i <= a; i++)
                {
                    if (i % 5 == 0&&i!=0)
                    {
                        listBox1.Items.Add(i);
                    }

                }
            }

            else
            {
                for (int i =a ; i <= b; i++)
                {
                    if (i % 5 == 0&&i!=0)
                    {
                        listBox1.Items.Add(i);
                    }
                }
            }
        }
    }
}
