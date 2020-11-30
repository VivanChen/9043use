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

namespace _05_amanda_0410_HW
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            //
            string name = textBox1.Text;
            string price = textBox2.Text;
            string number = textBox3.Text;
            int intPrice = Convert.ToInt32(price);
            int intNumber = Convert.ToInt32(number);

            if (textBox1.Text == "")
            {
                MessageBox.Show("產品名稱必填");
            }
            else if (intPrice <=0 || intNumber<=0)
            {
                MessageBox.Show("商品與數量不可小於0");
            }
            else
            {
                int count = Convert.ToInt32(intPrice) * Convert.ToInt32(intNumber);
                string total = Convert.ToString(count);
                File.AppendAllText("0410HW.csv", $"{name},{intPrice},{intNumber},{total}\r\n", Encoding.UTF8);
                MessageBox.Show($"{name}輸入完成!");
            }
            
        }

       private void groupBox2_Enter(object sender, EventArgs e)
        {

       }

       private void Form1_Load(object sender, EventArgs e)
       {
        Form2 f = new Form2();
        f.ShowDialog();
       }

        private void button2_Click(object sender, EventArgs e)
        {
          List<string> myList = File.ReadLines("0410HW.csv").ToList();
          listBox1.DataSource = myList;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            listBox1.Items.Clear();//清空list
        }

      

        private void button7_Click(object sender, EventArgs e)
        {
            File.WriteAllText("0410HW.csv", "產品名稱,價格,數量,金額\r\n", Encoding.UTF8);
        }
    }
}
