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



namespace _0410HomeWork
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //建立文件
            File.WriteAllText("prod.csv", "產品名稱,價格,數量,總價\r\n", Encoding.UTF8);
            MessageBox.Show("已建立文件");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //宣告變數產品名稱,價格,數量,及總價
            string Name = textBox1.Text.Trim();//trim把空白去掉
            string Price = textBox2.Text;
            string Count = textBox3.Text;

            int IntPrice = Int32.Parse(Price);
            int IntCount = Int32.Parse(Count);


            int Total = IntPrice * IntCount;

            //如果產品名稱沒填且不得為空格,及價格或數量<=0
            if (IntPrice <= 0 || IntCount <= 0)
            {
                MessageBox.Show("價格與數量不可小於0");
            }
            else if (Name == "")
            {
                MessageBox.Show("產品名稱必填");
            }
            //其餘輸出文件並清空textbox文字
            else
            {
                File.AppendAllText("prod.csv",
                $"{Name},{Price},{Count},{Total}\r\n", Encoding.UTF8);
                MessageBox.Show(Name+"輸出完成");
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //在listBox中讀取csv檔明細
            List<string> CheakList = File.ReadAllLines("prod.csv").ToList();
            CheakList.RemoveAt(0);//移除表頭
            listBox1.DataSource = CheakList;//listbox繫結


        }

        private void button4_Click(object sender, EventArgs e)
        {
            //查第幾筆資料
            List<string> CheakList = File.ReadAllLines("prod.csv").ToList();
            listBox1.DataSource = null;
            int No = Int32.Parse(textBox4.Text);
            listBox1.Items.Clear();
            listBox1.Items.Add(CheakList[No]);


        }

        private void button7_Click(object sender, EventArgs e)
        {
            //清空表單
            listBox1.DataSource = null;
            listBox1.Items.Clear();


        }
        private void button5_Click(object sender, EventArgs e)
        {
            List<string> CheakList = File.ReadAllLines("prod.csv").ToList();
            listBox1.DataSource = null;
            CheakList.RemoveAt(0);
            listBox1.Items.Clear();//先將item清掉,不然再按一次會重複資料
            //==============================================================
            string keyWord = textBox5.Text;//注意變數命名,命名要有意義
            //if (!string.IsNullOrEmpty(keyWord))//判斷是不是空值
            //{
            
                foreach (string target in CheakList)
                {
                    if (target.Contains(keyWord))
                    {
                        listBox1.Items.Add(target);
                    }
                }
            //}
            if (listBox1.Items.Count==0)
            {
                MessageBox.Show("查無此項目");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoginForm Login = new LoginForm();
            Login.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            List<string> CheakList = File.ReadAllLines("prod.csv").ToList();
            listBox1.DataSource = null;
            CheakList.RemoveAt(0);
            listBox1.Items.Clear();//先將item清掉,不然再按一次會重複資料

            foreach (string item in CheakList)
            {
                List<string> clist = item.Split(',').ToList();
                if (clist[0]==textBox6.Text)
                {
                    listBox1.Items.Add(item);
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            List<string> CheakList = File.ReadAllLines("prod.csv").ToList();
            listBox1.DataSource = null;
            CheakList.RemoveAt(0);
            listBox1.Items.Clear();

            foreach (string item in CheakList)
            {
                List<string> clist = item.Split(',').ToList();
                if (int.Parse(clist[1]) >int.Parse(textBox7.Text))
                {
                    listBox1.Items.Add(item);
                }
            }
            if (listBox1.Items.Count==0)
            {
                MessageBox.Show("無價格大於"+textBox7.Text+"產品");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            List<string> CheakList = File.ReadAllLines("prod.csv").ToList();
            listBox1.DataSource = null;
            CheakList.RemoveAt(0);
            listBox1.Items.Clear();


            foreach (string item in CheakList)
            {
                List<string> clist = item.Split(',').ToList();

                listBox1.Items.Add("名稱:"+clist[0]+",價格:"+clist[1]+"元");
            }

        }
    }
}
