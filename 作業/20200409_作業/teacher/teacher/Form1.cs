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

            //價格與數量不可以小等於於0\
            //price <= 0
            //count <= 0

            //if (strName.Trim() == "")  //產品名稱必填
            if (textBox1.TextLength == 0)  //產品名稱必填
            {
                MessageBox.Show("產品名稱必填");
            }
            else if(price <= 0 || count <= 0)  //textBox2.Text == "0"
            {
                MessageBox.Show("價格與數量不可以小於0");
            }
            else
            {
                File.WriteAllText("prod.txt",
                    $"{strName}\r\n{price},{count}\r\n{total}");
            }
            //            string strName = textBox1.Text;
            //            string strPrice = textBox2.Text;
            //            string strCount = textBox3.Text;

            //            int price = int.Parse(strPrice);
            //            int count = int.Parse(strCount);

            //            int total = price * count;

            //            //價格與數量不可以小等於於0\
            //            //price <= 0
            //            //count <= 0

            //            //if (strName.Trim() == "")  //產品名稱必填
            //            if (textBox1.TextLength == 0)  //產品名稱必填
            //            {
            //                MessageBox.Show("產品名稱必填");
            //            }
            //            else if (price <= 0 || count <= 0)  //textBox2.Text == "0"
            //            {
            //                MessageBox.Show("價格與數量不可以小於0");
            //            }
            //            else
            //            {
            //                File.WriteAllText("prod.txt",
            //                    $"{strName}\r\n{price},{count}\r\n{total}");
            //            }

        }
    }
}
