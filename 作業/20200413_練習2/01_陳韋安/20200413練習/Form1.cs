﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20200413練習
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //遞加5
            for (int i= 5; i <= 100; i+=5)
            {
                listBox1.Items.Add(i);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //判斷餘數被5除為0
            for (int i = 0; i <= 100; i++)
                if (i % 5 == 0) 
                {
                    listBox1.Items.Add(i);
                }
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //遞加?
            int a = Convert.ToInt32(textBox1.Text);
            for (int i = a; i <= 100; i+=a)
            {
                listBox1.Items.Clear();
                listBox1.Items.Add(i);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {


            int c = Convert.ToInt32(textBox3.Text);
            int d = Convert.ToInt32(textBox2.Text);

            for (int i = c; i <= d; i++)
            {
                if (i % 5 == 0)
                {
                    listBox1.Items.Add(i);
                }
            }
  
        }
    }
}
