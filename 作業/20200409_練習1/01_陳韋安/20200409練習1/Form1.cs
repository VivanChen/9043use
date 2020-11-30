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

namespace _20200409練習1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int b = Convert.ToInt32(textBox2.Text);
            int c = Convert.ToInt32(textBox3.Text);
            int d = b * c;
            string outputstring = 
                "\r\n" + textBox1.Text + "," + textBox2.Text + "," + textBox3.Text + "," + d;
            File.AppendAllText("test_0409.csv", outputstring, Encoding.UTF8);
            MessageBox.Show(textBox1.Text + "輸出完成");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            File.WriteAllText("test_0409.csv", "產品名稱,價格,數量,總價",Encoding.UTF8);
        }
    }
}
