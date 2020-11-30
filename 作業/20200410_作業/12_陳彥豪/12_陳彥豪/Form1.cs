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


namespace _12_陳彥豪
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
            File.WriteAllText("prod.csv", "產品名稱,價格,數量,總價\r\n", Encoding.UTF8);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(textBox1.Text + "輸出完成");
            int tatol = Convert.ToInt32(textBox2.Text) * Convert.ToInt32(textBox3.Text);
            File.AppendAllText("prod.csv", textBox1.Text + "," + textBox2.Text + "," + textBox3.Text + "," + Convert.ToString(tatol) + "\r\n");

        }
    }
}
