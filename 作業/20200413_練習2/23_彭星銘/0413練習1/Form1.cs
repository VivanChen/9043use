using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0413練習1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 5; i < 101; i += 5) 
            {
                listBox1.Items.Add(i);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int i = 1; i < 101; i +=1)
            {
                if (i%Convert.ToInt32(textBox1.Text)==0 )
                {
                    listBox1.Items.Add(i);
                }
                
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int i = Convert.ToInt32(textBox2.Text); i < Convert.ToInt32(textBox3.Text); i++)
            {
                if (i % Convert.ToInt32(textBox4.Text) == 0)
                {
                    listBox1.Items.Add(i);
                }
            }
        }
    }
}
