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

namespace hw3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static void print(object o)
        {
            MessageBox.Show(o.ToString());
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string Name = textBox1.Text;
            string Price = textBox2.Text;
            string Count = textBox3.Text;

            int a = Convert.ToInt32(textBox2.Text);
            int b = Convert.ToInt32(textBox3.Text);
           

            int total = a * b;
            if (Name.Trim() == "")
            {
                MessageBox.Show("產品名稱必填");
            }
            else if (a <= 0 || b <= 0)
            {
                MessageBox.Show("價格與數量不能小於0");
            }
            else
            {
                File.WriteAllText("Prob.txt", $"{Name}\r\n{Price},{Count}\r\n{total}", Encoding.UTF8);
            }
         
        }
    }
}
