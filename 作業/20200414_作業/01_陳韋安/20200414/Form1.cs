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

namespace _20200414
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

            if (File.Exists("prod.csv") == false)
            {
                File.WriteAllText("prod.csv", "產品名稱,價格,數量,總價\r\n",
                    Encoding.UTF8);
            }

            File.AppendAllText("prod.csv",
                strName + "," + strPrice + "," + strCount + "," + total + "\r\n",
                Encoding.UTF8);

            MessageBox.Show(strName + "輸出完成");
            File.Exists("prod.csv");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //讀回csv檔內容
            //List<string> prodList = File.ReadAllLines("prod.csv").ToList();
            //移除表頭
            //prodList.RemoveAt(0);
            //listbox繫結
            List<string> prodList = GetStart();
            listBox1.DataSource = prodList;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<string> prodList = File.ReadAllLines("prod.csv").ToList();

            int index = int.Parse(textBox4.Text);

            listBox1.DataSource = null;
            listBox1.Items.Clear();

            listBox1.Items.Add(prodList[index]);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            List<string> prodList = GetStart();

            foreach (string item in prodList)
            {
                if (item.Contains(textBox5.Text))
                {
                    listBox1.Items.Add(item);

                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            List<string> prodList = GetStart();

            foreach (string item in prodList)
            {
                List<string> pList = item.Split(',').ToList();

                if (pList[0] == textBox6.Text)
                {
                    listBox1.Items.Add(item);
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            List<string> prodList = GetStart();

            foreach (string item in prodList)
            {
                List<string> pList = item.Split(',').ToList();

                int price = Convert.ToInt32(pList[1]);
                int input = Convert.ToInt32(textBox7.Text);

                if (price > input)
                {
                    listBox1.Items.Add(item);
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            List<string> prodList = GetStart();

            foreach (string item in prodList)
            {
                List<string> pList = item.Split(',').ToList();

                string str = $"名稱 : {pList[0]},價格 : {pList[1]}元";

                listBox1.Items.Add(str);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();

            f2.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            List<string> newList = new List<string>();
            List<string> pList = File.ReadAllLines("prod.csv").ToList();
            foreach (string proDuct in pList)
            {
                string[] myProduct = proDuct.Split(',');
                if (myProduct[0] != textBox8.Text)   //設產品名稱 不等於 tBbox8 
                {
                    newList.Add(proDuct);  //proDuct 加到 newList
                    File.WriteAllLines("prod.csv", newList, Encoding.UTF8); //將newList覆寫 prod檔
                }
            }
            MessageBox.Show("刪除成功");
        }
    
    List<string> GetStart()//宣告方法,list的泛型
    {
        List<string> prodList = File.ReadAllLines("Prod.csv").ToList();
        prodList.RemoveAt(0);
        listBox1.DataSource = null;
        listBox1.Items.Clear();
        return prodList;
    }


        private void button9_Click_1(object sender, EventArgs e)
        {
            List<string> newList = new List<string>();
            List<string> pList = File.ReadAllLines("prod.csv").ToList();
            foreach (string proDuct in pList)
            {
                string[] myProduct = proDuct.Split(',');  //將合拆開
                string proDuctName = myProduct[0];
                string proDuctPrice = myProduct[1];
                string proDuctNumber = myProduct[2];
                int total = 0;
                string change;
                if (myProduct[0] == textBox11.Text)   //如果 產品名稱 等於 tBox11
                {

                    if (textBox12.Text == "")             //如果價格(tBox12沒打)
                    {
                        proDuctPrice = myProduct[1];   //價格=原價格
                    }
                    else
                    {
                        proDuctPrice = textBox12.Text;   //否則  價格=tBox12中的數
                    }
                    if (textBox13.Text == "")              //如果數量(tBox13沒打)
                    {
                        proDuctNumber = myProduct[2];   //數量=原數量
                    }
                    else
                    {
                        proDuctNumber = textBox13.Text;    //否則  數量=tBox11中的數
                    }
                    total = Convert.ToInt32(proDuctPrice) * Convert.ToInt32(proDuctNumber);  //total 等於 價格*數量
                    change = $"{proDuctName},{proDuctPrice},{proDuctNumber},{total}";     // change放 字串組合 名稱,價格,數量,總價
                    newList.Add(change);
                }
                else
                {
                    newList.Add(proDuct);
                }
            }
            File.WriteAllLines("prod.csv", newList, Encoding.UTF8);  //將newList覆寫 prod檔
            MessageBox.Show("修改成功");
        }
    }
}