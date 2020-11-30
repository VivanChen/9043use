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
using System.Collections;

namespace _20200410
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //指定Form1事件,先執行Form2
            Form2 f = new Form2();
            f.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //輸出檔案
            //產品,價格,數量,總價
            string Sname = textBox1.Text;
            int Iprice = Convert.ToInt32(textBox2.Text);
            int Icount = Convert.ToInt32(textBox3.Text);
            int Itotal = Iprice * Icount;
            if (Sname=="")
            {
                MessageBox.Show("產品名稱不可為空");
            }
            else if (Iprice <=0 || Icount <=0)
            {
                MessageBox.Show("價格與數量不可小於等於0");
            }
            else
            {
                File.AppendAllText
                    ("product.csv", 
                    $"\r\n{Sname},{Iprice},{Icount},{Itotal}",
                    Encoding.UTF8);

                List<string> myList = File.ReadAllLines("product.csv").ToList();

                listBox2.DataSource = null;
                listBox2.Items.Clear();
                listBox2.DataSource = myList;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            File.WriteAllText("Product.csv","產品,價格,數量,總價", Encoding.UTF8);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //讀回csv檔內容
            List<string> myList = File.ReadAllLines("product.csv").ToList();

            //移除表頭
            myList.RemoveAt(0);

            //資料繫結
            listBox1.DataSource = myList;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<string> myList = File.ReadAllLines("product.csv").ToList();

            listBox1.DataSource = null;
            listBox1.Items.Clear();

            int index = Convert.ToInt32(textBox4.Text);
            listBox1.Items.Add(myList[index]);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            List<string> myList = File.ReadAllLines("product.csv").ToList();

            myList.RemoveAt(0);
            listBox1.DataSource = null;
            listBox1.Items.Clear();

            foreach (string item in myList)
            {
                if (item.Contains(textBox5.Text))
                {
                    listBox1.Items.Add(item);
                }
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            List<string> prodList = File.ReadAllLines("prod.csv").ToList();
            prodList.RemoveAt(0);

            listBox1.DataSource = null;
            listBox1.Items.Clear();

            foreach (string item in prodList)
            {
                List<string> pList = item.Split(',').ToList();

                if (pList[0] == textBox6.Text)
                {
                    listBox1.Items.Add(item);
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            List<string> myList = File.ReadAllLines("prod.csv").ToList();

            myList.RemoveAt(0);
            listBox1.DataSource = null;
            listBox1.Items.Clear();

            int price = Convert.ToInt32(textBox7.Text);

            foreach (string item in myList)
            {
                List<string> prodLsit = item.Split(',').ToList();
                int pri = Convert.ToInt32(prodLsit[1]);

                if (pri > price)
                {
                    listBox1.Items.Add(item);
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            List<string> myList = File.ReadAllLines("prod.csv").ToList();

            myList.RemoveAt(0);
            listBox1.DataSource = null;
            listBox1.Items.Clear();

            foreach (string item in myList)
            {
                List<string> prodLsit = item.Split(',').ToList();

                listBox1.Items.Add("名稱: " + prodLsit[0] + ",價格: " + prodLsit[1] + "元");
            }

        }
    }
}
