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
            List<string> prodList = File.ReadAllLines("prod.csv").ToList();

            //移除表頭
            prodList.RemoveAt(0);

            //listbox繫結
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

        private void Form1_Load(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();

            f2.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            List<string> prodList = File.ReadAllLines("prod.csv").ToList();

            prodList.RemoveAt(0);

            listBox1.DataSource = null;
            listBox1.Items.Clear();

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

        private void button6_Click(object sender, EventArgs e)
        {
            List<string> prodList = File.ReadAllLines("prod.csv").ToList();
            prodList.RemoveAt(0);

            listBox1.DataSource = null;
            listBox1.Items.Clear();

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
            List<string> prodList = File.ReadAllLines("prod.csv").ToList();
            prodList.RemoveAt(0);

            listBox1.DataSource = null;
            listBox1.Items.Clear();

            foreach (string item in prodList)
            {
                List<string> pList = item.Split(',').ToList();

                string str = $"名稱 : {pList[0]},價格 : {pList[1]}元";

                listBox1.Items.Add(str);
            }
        }
    }
}
