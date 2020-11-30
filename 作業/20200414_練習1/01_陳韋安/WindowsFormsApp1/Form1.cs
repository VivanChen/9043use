using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Ctrl K D ,自動排序
            //數字在 1 - 49之間
            //不重複的號碼6個 => 不確定次數
            //產生之後請排序印出

            Random rnd = new Random();
            List<int> numberList = new List<int>();

            while (numberList.Count < 6)  //集合數量小於6的時候,一直跑
            {
                int number = rnd.Next(1, 50); //產生1-49的隨機亂數

                if (numberList.Contains(number) == false)  //檢查該數字是否不存在於集合
                {
                    numberList.Add(number); //不存在的話,就加入集合中
                }
            }
            numberList.Sort();

            listBox1.DataSource = numberList;

            //Random rnd = new Random();
            //int a = 0;
            //int b = 0;
            //int c = 0;
            //int d = 0;
            //int aa = 0;//?e
            //int bb = 0;
            //List<int> myList = new List<int>();
            //while (a < 50 || b < 50 || c < 50 || d < 50 || aa < 50 || bb < 50)
            //{
            //    a = rnd.Next(1, 50);
            //    b = rnd.Next(1, 50);
            //    c = rnd.Next(1, 50);
            //    d = rnd.Next(1, 50);
            //    aa = rnd.Next(1, 50);
            //    bb = rnd.Next(1, 50);
            //    myList.Add({a},);
            //}

            //myList.Sort();
            //listBox1.DataSource = myList;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            List<int> numberList = new List<int>();

            while (true) //無限迴圈
            {
                int number = rnd.Next(1, 50); //產生1-49的隨機亂數

                if (numberList.Contains(number) == false)  //檢查該數字是否不存在於集合
                {
                    numberList.Add(number); //不存在的話,就加入集合中
                }
                if (numberList.Count == 6)
                {
                    break;
                }
            }
            numberList.Sort();

            listBox1.DataSource = numberList;
        }
    }
}
