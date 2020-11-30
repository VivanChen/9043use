using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _0410作業練習
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
         
            string name = textBox1.Text;
            string price = textBox2.Text;
            string number = textBox3.Text;
            int total1 = Convert.ToInt32(price) * Convert.ToInt32(number);
            string sum = Convert.ToString(total1);

            File.AppendAllText("list.csv", $"{name},{price},{number},{sum}\r\n", Encoding.UTF8);
            MessageBox.Show(name + "輸入完成");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List <string> str = File.ReadAllLines ("list.csv").ToList();

            listBox1.DataSource = str;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<string> str = File.ReadAllLines("list.csv").ToList();

            listBox1.DataSource = null;
            listBox1.Items.Clear();
            listBox1.Items.Add(str[Convert.ToInt32(textBox4.Text)]);
        }
    }
}
