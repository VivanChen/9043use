using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < 100; i++)
            {
                if (i <= 20)
                {
                    int a = 5 * i;
                    listBox1.Items.Add(a);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            for (int i = 1; i < 100; i++)
            {

                if (i <= 100)
                {
                    int num = Convert.ToInt32(textBox1.Text);
                    int a = num * i;

                    if (a <= 100)
                    {
                        listBox1.Items.Add(a);
                    }               
                }           
            }



        }

        private void button3_Click(object sender, EventArgs e)
        {
            int MAX = Convert.ToInt32(textBox3.Text);
            int Min = Convert.ToInt32(textBox2.Text);

            for (int i = Min; i < MAX; i++)
            {

                int a = 5 * i;

                if (a <= MAX)
                {
                    listBox1.Items.Add(a);
                }
            }



        }
    }
}
