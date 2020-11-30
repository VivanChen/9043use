using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0412練習
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <=100 ; i+=5)
            {
                if (i>=5)
                {
                    listBox1.Items.Add(i);
                }
               
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            for (int i = 0; i <= 100; i++)
            {
                if (i % a ==0 && i!=0)
                {
                    listBox1.Items.Add(i);
                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int b = Convert.ToInt32(textBox2.Text);
            int c = Convert.ToInt32(textBox3.Text);

            for (int i = b; i <= c; i++)
            {
                if (i %5 ==0 && i != 0)
                {
                    listBox1.Items.Add(i);
                }
            }
        }
    }
}
