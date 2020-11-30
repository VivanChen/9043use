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
        //List<string> product = new List<string>();
        List<string> product = File.ReadAllLines("product.csv").ToList();
        //int productTotal;
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
            List<string> myList = File.ReadAllLines("product.csv").ToList();
            listBox1.DataSource = null;
            listBox1.Items.Clear();
            listBox1.DataSource = myList;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(textBox6.Text);
            List<string> myList = File.ReadAllLines("product.csv").ToList();
            listBox1.DataSource = null;
            listBox1.Items.Clear();
            listBox1.Items.Add(myList[num1]);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            listBox1.Items.Clear();
            string key = textBox5.Text;
            bool notFound = true;

            if (textBox5.Text != "")
            {
                for (int i = 0; i < product.Count; i++)
                {
                    if (product[i].Contains(key))
                    {
                        listBox1.Items.Add(product[i]);
                    }
                }
                if (notFound == true)
                {
                    MessageBox.Show("查無此產品");
                }
            }
            else
            {
                MessageBox.Show("請輸入資料");
            }

        }
    }
}
