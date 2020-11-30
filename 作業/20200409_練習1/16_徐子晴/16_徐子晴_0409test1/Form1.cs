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

namespace _16_徐子晴_0409test1
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
            File.WriteAllText(@"C:\16_test\16_徐子晴_0409test1\prod.csv","產品名稱,價格,數量,總價\r\n",Encoding.UTF8);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            int Inputtext2 = Convert.ToInt32(textBox2.Text);
            int Inputtext3 = Convert.ToInt32(textBox3.Text);
            int total = Inputtext2 * Inputtext3;
            print(textBox1.Text+"輸出完成");
            string Output= textBox1.Text + "," + textBox2.Text + "," + textBox3.Text + "," + total+"\r\n";
            File.AppendAllText(@"C:\16_test\16_徐子晴_0409test1\prod.csv",Output, Encoding.UTF8);
        }
    }
}
