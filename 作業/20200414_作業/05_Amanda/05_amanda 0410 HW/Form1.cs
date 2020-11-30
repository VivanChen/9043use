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
                if (File.Exists("0410HW.csv") == false)
                {
                    File.WriteAllText("0410HW.csv", "產品名稱,價格,數量,金額\r\n", Encoding.UTF8);
                }
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
          //列出所有產品
          List<string> myList = File.ReadLines("0410HW.csv").ToList();
          listBox1.DataSource = myList;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //查第幾筆資料

            List<string> myList = GetStart();
            int index = Convert.ToInt32(textBox4.Text);//字串轉整數
            listBox1.Items.Add(myList[index]);
            //int index = Convert.ToInt32(textBox4.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //查符合關鍵字資料

            List<string> myList = GetStart();

            //teacher
            //mylist每個值放進item
            foreach (string item in myList)
            {
                //item是否有textbox5
                if (item.Contains(textBox5.Text))
                {
                    listBox1.Items.Add(item);
                }
            }


        }

        private void button5_Click(object sender, EventArgs e)
        {
            //查產品名稱

            List<string> myList = GetStart();

            //mylist每個值放進item
            foreach (string item in myList)
            {
                //移除item內的',' 組成list
                List<string> mList = item.Split(',').ToList();
                if (mList[0] ==textBox6.Text)
                {
                    listBox1.Items.Add(item);
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            List<string> myList = GetStart();
            
            foreach (string item in myList)
            {

                //移除item內的',' 組成list
                List<string> pList = item.Split(',').ToList();
                int plistInt = Convert.ToInt32(pList[1]);
                int box7Int = Convert.ToInt32(textBox7.Text);
                if (plistInt > box7Int)
                {
                    listBox1.Items.Add(item);
                }

            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            List<string> myList = GetStart();

            foreach (string item in myList)
            {

                //移除item內的',' 組成list
                List<string> pList = item.Split(',').ToList();

                listBox1.Items.Add(@"名稱:" + pList[0] + ",價格:" + pList[1] + "元");


            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            List<string> myList = File.ReadLines("prod.csv").ToList();

            //如果產品名稱相同 就刪除
            while (true)
            {
                myList.RemoveAt(myList[]);
            }

            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //修改商品
            List<string> myList = File.ReadLines("prod.csv").ToList();
        }

        List<string> GetStart()
        {
            //讀取csv資料轉list
            List<string> myList = File.ReadLines("prod.csv").ToList();

            //清空listBox1, 先將ListBox用成空集合 , 再CLEAR
            myList.RemoveAt(0);//移除表頭
            listBox1.DataSource = null;
            listBox1.Items.Clear();//清空list

            return myList;
        }
    }
}
