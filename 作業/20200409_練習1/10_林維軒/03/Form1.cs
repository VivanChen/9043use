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

namespace _03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            File.WriteAllText("c.csv", "產品名稱, 價格, 數量, 總價", Encoding.UTF8);
        }

        private void button2_Click(object sender, EventArgs e)
        {
           string stritem = textBox1.Text;
           string strprice = textBox2.Text;
           string strcount = textBox3.Text;

            int a = Convert.ToInt32(strprice);
            int b = Convert.ToInt32(strcount);
            int total = a * b;
            textBox2.Text = a.ToString();
            textBox3.Text = b.ToString();

            //string outputstring = textBox1.Text + "," + textBox2.Text + "," + textBox3.Text + "," + total;
            string outputstring = $"{stritem},{strprice},{strcount},{total}";
            File.AppendAllText("c.csv","\r\n" + outputstring , Encoding.UTF8);

            MessageBox.Show("處理完成");

        }
    }
}
