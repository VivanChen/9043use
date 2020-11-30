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

namespace homework0410
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            File.WriteAllText("a.csv" , "產品名稱 , 價格 , 數量 , 總價\r\n",Encoding.UTF8);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string strName = textBox1.Text;
            string strPrice = textBox2.Text;
            string strCount = textBox3.Text;

            int price = int.Parse(strPrice);
            int count = int.Parse(strCount);

            int total = price * count;
            
            
            if (strName == "")
            {
                MessageBox.Show("產品名稱不可空白");
            }
            else if(price <= 0 || count <=0)
            {
                MessageBox.Show("價格及數量不可小於等於0");
            }
            else
            {
                File.AppendAllText("a.csv",
                $"{strName},{strPrice},{strCount},{total}\r\n",
                Encoding.UTF8);

                MessageBox.Show(strName + "輸出完成");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //讀回csv檔內容
            List<string> myList = File.ReadAllLines("a.csv").ToList();

            //移除表頭
            myList.RemoveAt(0);

            //資料繫結
            listBox1.DataSource = myList;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            List<string> myList = File.ReadAllLines("a.csv").ToList();
           
            listBox1.DataSource = null;
            listBox1.Items.Clear();

            int index = Convert.ToInt32(textBox4.Text);
            listBox1.Items.Add(myList[index]);
                        
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            List<string> myList = File.ReadAllLines("a.csv").ToList();

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

        private void button6_Click(object sender, EventArgs e)
        {
            List<string> myList = File.ReadAllLines("a.csv").ToList();

            myList.RemoveAt(0);
            listBox1.DataSource = null;
            listBox1.Items.Clear();

            
            foreach (string item in myList)
            {
                List<string> prodLsit = item.Split(',').ToList();
                if (prodLsit[0] == textBox6.Text)
                {
                    listBox1.Items.Add(item);
                }
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            List<string> myList = File.ReadAllLines("a.csv").ToList();

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
            List<string> myList = File.ReadAllLines("a.csv").ToList();

            myList.RemoveAt(0);
            listBox1.DataSource = null;
            listBox1.Items.Clear();

            foreach (string item in myList)
            {
                List<string> prodLsit = item.Split(',').ToList();
                
                listBox1.Items.Add("名稱: "+prodLsit[0]+",價格: "+prodLsit[1]+"元");
            }
            
        }
    }
}
