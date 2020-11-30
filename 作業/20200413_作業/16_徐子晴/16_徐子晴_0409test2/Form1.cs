using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//加入file.writealltest用
using System.IO;

namespace _16_徐子晴_0409test2
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
        private void label1_Click(object sender, EventArgs e)
        {
           
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //呼叫小視窗
            LoginForm f = new LoginForm();
            f.ShowDialog();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            File.WriteAllText(@"C:\16_test\16_徐子晴_0410test 02\prod.csv", "產品名稱,價格,數量,總價\r\n", Encoding.UTF8);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            

            ////空白全刪
            string d = textBox1.Text.Trim();
            //接收字串
            string a = textBox1.Text;
            //轉int計算
            var InputPrice = Convert.ToInt32(textBox2.Text);
            var InputCount = Convert.ToInt32(textBox3.Text);
            int total = InputPrice * InputCount;

            //判斷Name
            //字串長度<=0
            //if (c.Length<=0)
            //{
            //    print("產品名稱必須填");
            //}

            //扣除空白後,""就print
            //null或empty(""),print    但是"空白空白"依然有bug
            if (String.IsNullOrEmpty(a) || d == "")
            {
                print("產品名稱必須填");
            }

            ////空白也可以print出
            //if (textBox1.Text == "")
            //{
            //    print("產品名稱必須填");
            //}

            //判斷Price與Count是否小於等於0
            // = 為指定,不能寫在前面
           
            else if (InputPrice <= 0 || InputCount <= 0)
            {
                print("價格與數量不可以小於0");
            }
            else
            {

                //儲存為重複字串
                File.AppendAllText(@"C:\16_test\16_徐子晴_0413\prod.csv",
                    $"{textBox1.Text},{InputPrice},{InputCount},{total}\r\n",
                    Encoding.UTF8);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ////查詢產品
            //讀取csv資料(用readalltext都會便字元)轉成字串
            //string str = File.ReadAllText(@"D:\C#課程\16_test\16_徐子晴_0410test 001\prod.csv");
            ////讀取讀取csv資料(用readallline)轉成字串
            List<string> strlist= File.ReadAllLines(@"C:\16_test\16_徐子晴_0413\prod.csv").ToList();
            ////移除index 0的標題
            strlist.RemoveAt(0);
            //把符號切除, 方便從文件讀取print出
            //List<string> strlist = str.Split('char').ToList();
            ////資料繫結 : DataSource
            listBox1.DataSource = strlist;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //清空listBox1, 先將ListBox用成空集合 , 再CLEAR
            listBox1.DataSource = null;
            listBox1.Items.Clear();

            //查詢產品
            //讀取csv資料轉list
            List<string> strlist = File.ReadAllLines(@"C:\16_test\16_徐子晴_0413\prod.csv").ToList();
            //輸入查詢值
            int box4Index = Convert.ToInt32(textBox4.Text);
            

        }
        private void button5_Click(object sender, EventArgs e)
        {

            //清空listBox1, 先將ListBox用成空集合 , 再CLEAR
            listBox1.DataSource = null;
            listBox1.Items.Clear();

            //查詢產品
            //讀取csv資料轉list
            //string str = File.ReadAllText(@"C:\16_test\16_徐子晴_0410test 02\prod.csv");

            //listBox1.Items.Add(StringList1.Contains(textBox5.Text));
            List<string> strlist = File.ReadAllLines(@"C:\16_test\16_徐子晴_0413\prod.csv").ToList();

            //移除標題
            strlist.RemoveAt(0);

            //strlist每個值放進item
            foreach (string item in strlist)
            {
                //item是否有textbox5
                if (item.Contains(textBox5.Text))
                {
                    listBox1.Items.Add(item);

                } 
            }



        }

        private void button6_Click(object sender, EventArgs e)
        {

            //清空listBox1, 先將ListBox用成空集合 , 再CLEAR
            listBox1.DataSource = null;
            listBox1.Items.Clear();

            //查詢產品
            //讀取csv資料轉list
            //string str = File.ReadAllText(@"C:\16_test\16_徐子晴_0410test 02\prod.csv");

            //listBox1.Items.Add(StringList1.Contains(textBox5.Text));
            List<string> strlist = File.ReadAllLines(@"C:\16_test\16_徐子晴_0413\prod.csv").ToList();

            ////把符號切除',',' '
            //char[] listchar = { ' ', ',', '\n' };
            ////str切除char組成list
            //List<string> StringList1 = str.Split(listchar).ToList();
            ////indexof查詢索引
            //int box6index = StringList1.IndexOf(textBox6.Text);

            //if (box6index > 3)
            //{

            //    if (box6index % 4 == 0)
            //    {
            //        int realindex = box6index / 4;
            //        //輸出 strlist 的 index項  值
            //        //listBox1.Items.Add(realindex);
            //        listBox1.Items.Add(strlist[realindex]);

            //    }
            //    else
            //    {
            //        listBox1.Items.Add("查無資料");
            //    }

            //}
            //else
            //{
            //    listBox1.Items.Add("查無資料");
            //}

            //strlist每個值放進item
            foreach (string item in strlist)
            {

                //移除item內的',' 組成list
                List<string> pList = item.Split(',').ToList();

                if (pList[0] == textBox6.Text)
                {
                    listBox1.Items.Add(item);
                }
            }


        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

            //清空listBox1, 先將ListBox用成空集合 , 再CLEAR
            listBox1.DataSource = null;
            listBox1.Items.Clear();
            //listBox1.Items.Add(StringList1.Contains(textBox5.Text));
            List<string> strlist = File.ReadAllLines(@"C:\16_test\16_徐子晴_0413\prod.csv").ToList();
            //remove第一排
            strlist.RemoveAt(0);

            foreach (string item in strlist)
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

        private void button8_Click(object sender, EventArgs e)
        {

            //清空listBox1, 先將ListBox用成空集合 , 再CLEAR
            listBox1.DataSource = null;
            listBox1.Items.Clear();
            //listBox1.Items.Add(StringList1.Contains(textBox5.Text));
            List<string> strlist = File.ReadAllLines(@"C:\16_test\16_徐子晴_0413\prod.csv").ToList();
            strlist.RemoveAt(0);

            foreach (string item in strlist)
            {

                //移除item內的',' 組成list
                List<string> pList = item.Split(',').ToList();

                listBox1.Items.Add(@"名稱:"+pList[0]+",價格:"+pList[1]+"元");

                
            }
        }
    }
}
