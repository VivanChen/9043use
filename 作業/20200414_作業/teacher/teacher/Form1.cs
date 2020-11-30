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

            listBox1.Items.Clear();

            foreach (string item in prodList)
            {
                string[] tempAry = item.Split(',');

                string part1String = tempAry[0];

                if (part1String.Contains(textBox6.Text))
                {
                    listBox1.Items.Add(item);

                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            List<string> prodList = File.ReadAllLines("prod.csv").ToList();

            prodList.RemoveAt(0);

            listBox1.Items.Clear();

            foreach (string item in prodList)
            {
                string[] tempAry = item.Split(',');

                string part2String = tempAry[1];
                int prodPrice = int.Parse(part2String);

                int inputPrice = int.Parse(textBox7.Text);

                if (prodPrice > inputPrice)
                {
                    listBox1.Items.Add(item);

                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            List<string> prodList = File.ReadAllLines("prod.csv").ToList();

            int deleteIndex = 0;

            for (int i = 1; i < prodList.Count; i++)
            {
                string item = prodList[i];

                List<string> tempAry = item.Split(',').ToList();

                string prodName = tempAry[0];

                if (prodName == textBox8.Text)
                {
                    deleteIndex = i;
                    break;
                }
            }
            //if (deleteIndex == 0)
            //{
            //    MessageBox.Show("Not Found");
            //}
            //else
            //{
            //    prodList.RemoveAt(deleteIndex);
            //    File.WriteAllLines("prod.csv", prodList);
            //}

            if (deleteIndex == 0)
            {
                MessageBox.Show("Not Found");
                return;
            }

            prodList.RemoveAt(deleteIndex);
            File.WriteAllLines("prod.csv", prodList);


        }

        private void button8_Click(object sender, EventArgs e)
        {
            List<string> prodList = File.ReadAllLines("prod.csv").ToList();

            for (int i = 1; i < prodList.Count; i++)
            {
                string item = prodList[i];

                string[] tempAry = item.Split(',');

                string prodName = tempAry[0];

                if (prodName == textBox9.Text)
                {
                    //換掉字串
                    int total = int.Parse(textBox10.Text) * int.Parse(textBox11.Text);
                    prodList[i] =
                        $"{textBox9.Text},{textBox10.Text},{textBox11.Text},{total}";
                    break;
                }
            }


            File.WriteAllLines("prod.csv", prodList);
        }
    }
}
