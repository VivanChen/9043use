using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.IO;

namespace _03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static void print(object o)
        {
            MessageBox.Show(o.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            File.WriteAllText("c.csv", "產品名稱, 價格, 數量, 總價", Encoding.UTF8);
        }

        private void button2_Click(object sender, EventArgs e)
        {
           string stritem = textBox1.Text;
           string strprice = textBox2.Text;
           string strcount = textBox3.Text;

            int a = Convert.ToInt32(strprice);
            int b = Convert.ToInt32(strcount);
            int total = a * b;
            textBox2.Text = a.ToString();
            textBox3.Text = b.ToString();

            //string outputstring = textBox1.Text + "," + textBox2.Text + "," + textBox3.Text + "," + total;
            string outputstring = $"{stritem},{strprice},{strcount},{total}";
            File.AppendAllText("c.csv","\r\n" + outputstring , Encoding.UTF8);

            MessageBox.Show("處理完成");

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Login f = new Login();
            f.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //string str = File.ReadAllText("c.csv");
            
            List<string> mylist = File.ReadAllLines("c.csv").ToList(); //把資料讀取後,轉成集合
            mylist.RemoveAt(0); // 移除不要的字串

            listBox1.DataSource = mylist; //印出我要的資料


        }

        private void button4_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox4.Text);
            List<string> mylist = File.ReadAllLines("c.csv").ToList();//拿到幾筆資料,然後轉成資料集合

            listBox1.DataSource = null; //清空資料
            listBox1.Items.Clear();

            listBox1.Items.Add(mylist[a]);//我要去我拿到的mylist 取第幾筆資料



            //if (a <= mylist.Count-1)
            //{
            //    listBox1.Items.Add(mylist[a]);//把textBox 轉成數字就可以用串列來讀
            //}
            //else {
            //    listBox1.Items.Add("out of range");
            //}
            //string a = ConvertToInt32(textBox4.Text) ;(要記得轉型態)
            //mylist.IndexOf();(這個只能用在listBox1.Items.Add(括弧裡))
            //listBox1.Items.Add(); 增加到list

        }

        private void button7_Click(object sender, EventArgs e)
        {
            List<string> mylist = File.ReadAllLines("c.csv").ToList();//拿到幾筆資料,然後轉成資料集合

            listBox1.DataSource = null;
            listBox1.Items.Clear(); //清空

            mylist.RemoveAt(0);//刪除第一行

            foreach (string item in mylist)
            {
                if (item.Contains(textBox5.Text))// 如果有包含的字 比較 true and false
                {
                    listBox1.Items.Add(item);//條件成立 item 印出來
                }
            }


        }

        private void button6_Click(object sender, EventArgs e)
        {
            List<string> mylist = File.ReadAllLines("c.csv").ToList();//拿到幾筆資料,然後轉成資料集合

            listBox1.DataSource = null;
            listBox1.Items.Clear(); //清空

            mylist.RemoveAt(0);//刪除第一行

            foreach (string item in mylist) 
            {
                List<string> list = item.Split(',').ToList();//一個新的list 拿進來用 逗號隔開
                if (list[0] == textBox6.Text)//取第一個值看有沒有跟textbox 相等
                {
                    listBox1.Items.Add(item);//也是item 印出
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            List<string> mylist = File.ReadAllLines("c.csv").ToList();//拿到幾筆資料,然後轉成資料集合

            listBox1.DataSource = null;
            listBox1.Items.Clear(); //清空

            mylist.RemoveAt(0);//刪除第一行

            foreach (string item in mylist)
            {
                List<string> list = item.Split(',').ToList();//字串用逗號隔開 放進一個名為"list"型別為string的泛行集合"List"
               
                if (Convert.ToInt32(list[1]) > Convert.ToInt32(textBox8.Text))
                {
                    listBox1.Items.Add(item);//也是item 印出
                }

            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            List<string> mylist = File.ReadAllLines("c.csv").ToList();//拿到幾筆資料,然後轉成資料集合

            listBox1.DataSource = null;
            listBox1.Items.Clear(); //清空

            mylist.RemoveAt(0);//刪除第一行

            foreach (string item in mylist)
            {
                List<string> list = item.Split(',').ToList();//集合字串 宣告 item帶進來 用逗號隔開 轉成集合
                listBox1.Items.Add($"名稱:{list[0]}, 價格:{list[1]}");// $字串插值:{變動值}
                //list
                //list[0] list[1]
            }
           
        }
    }

        
    
}
