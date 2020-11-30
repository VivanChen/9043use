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

namespace _0410作業練習
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            string name = textBox1.Text;
            string price = textBox2.Text;
            string number = textBox3.Text;
            int total1 = Convert.ToInt32(price) * Convert.ToInt32(number);
            string sum = Convert.ToString(total1);

            File.AppendAllText("list.csv", $"{name},{price},{number},{sum}\r\n", Encoding.UTF8);
            MessageBox.Show(name + "輸入完成");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<string> str = File.ReadAllLines("list.csv").ToList();

            listBox1.DataSource = str;
        }

        List<string> Start()
        {
            List<string> str = File.ReadAllLines("list.csv").ToList();//用集合來讀取
            listBox1.DataSource = null;
            listBox1.Items.Clear();
            //移除表頭
            str.RemoveAt(0);
            return str;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<string> str = File.ReadAllLines("list.csv").ToList();
            listBox1.DataSource = null;
            listBox1.Items.Clear();
            listBox1.Items.Add(str[Convert.ToInt32(textBox4.Text)]);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            List<string> str = Start();

            foreach (string item in str)
            {
                if (item.Contains(textBox5.Text))
                {
                    listBox1.Items.Add(item);

                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            List<string> str = Start();
            foreach (string item in str)
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
            List<string> str = Start();
            foreach (string item in str)
            {
                List<string> list1 = item.Split(',').ToList();
                if (Convert.ToInt32(list1[1]) > Convert.ToInt32(textBox7.Text))
                {
                    listBox1.Items.Add(item);
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            List<string> str = Start();
            foreach (string item in str)
            {
                List<string> myList = item.Split(',').ToList();
                listBox1.Items.Add($"產品 {myList[0]} 價格: {myList[1]}");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if ((textBox8.Text == "") || (textBox9.Text == "") || (textBox10.Text == ""))
            {
                MessageBox.Show("請不要空白");

            }
            int t;
            if ((int.TryParse(textBox9.Text, out t)) == false || (int.TryParse(textBox10.Text, out t)) == false)
            {
                MessageBox.Show("請確認價格與數量為數字");
            }

            List<string> str= File.ReadAllLines("list.csv").ToList();
            for (int i = 0; i < str.Count; i++)
            {
                string item = str[i];
                List<string> myList = item.Split(',').ToList();

                if (myList[0] == (textBox8.Text))
                {
                    //換掉字串
                    int total = int.Parse(textBox9.Text) * int.Parse(textBox10.Text);
                    str[i] =
                        $"{textBox8.Text},{textBox9.Text},{textBox10.Text},{total}";
                    break;
                }

            }
            File.WriteAllLines("list.csv", str);

        }

        private void button9_Click(object sender, EventArgs e)
        {
            List<string> str = File.ReadAllLines("list.csv").ToList();

            int deleteIndex = 0;//先宣告一個變數
            for (int i = 1; i < str.Count; i++)//用for迴圈來跑,若用foreach會因為集合數量改變而無法跑圈
            {
                string item = str[i];
                List<string> myList = item.Split(',').ToList();
                //string prodName = myList[0];

                if (myList[0] == textBox11.Text)
                {
                    deleteIndex = i;
                    break;
                }

            }
            str.RemoveAt(deleteIndex);
            File.WriteAllLines("list.csv", str);
        }
    }
}
