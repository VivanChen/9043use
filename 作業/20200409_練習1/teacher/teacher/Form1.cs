using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace teacher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strName = textBox1.Text;
            string strPrice = textBox2.Text;
            string strCount = textBox3.Text;

            int price = int.Parse(strPrice);
            int count = int.Parse(strCount);

            int total = price * count;

            //File.AppendAllText("prod.csv",
            //    textBox1.Text + "," + strPrice + "," + strCount + "," + total + "\r\n",
            //    Encoding.UTF8);

            File.AppendAllText("prod.csv",
                $"{strName},{strPrice},{strCount},{total}\r\n",
                Encoding.UTF8);

            MessageBox.Show(strName + "輸出完成");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //big-5
            File.WriteAllText("prod.csv", "產品名稱,價格,數量,總價\r\n" ,
                Encoding.UTF8);
        }
    }
}
