using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0414練習
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            Random run = new Random();
            List<int> numberList = new List<int>();//*
            for (int i = 0; i < 6; i++)
            {
                int number = run.Next(1, 49);
                if (numberList.Contains(number) == false)//*
                {
                    numberList.Add(number);
                }
            }
            numberList.Sort();
            listBox1.DataSource = numberList;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Ctrl K D
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
        }
    }
}
