﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0413
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 5; i < 101; i+=5)
            {
                listBox1.Items.Add(i);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            int a = Convert.ToInt32(textBox2.Text);
            int b = Convert.ToInt32(textBox3.Text);

            for (int i = a; i < b; i++)
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

            int a = Convert.ToInt32(textBox1.Text);

            for (int i = 0; i < 100; i++)
            {
                if (i % a == 0)
                {
                    listBox1.Items.Add(i);
                }
            }
        }
    }
}
