using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //List<int> myList = new List<int>() { };

            //Random num = new Random();

            //while (myList.Count < 6)   //集合數量小於6的時候迴圈不停止
            //{
            //    int number = num.Next(0, 50);   //產生1-49亂數
            //    if (myList.Contains(number) == false) //如果集合內的數字不存在則存入集合內反之不存入
            //    {
            //        myList.Add(number);

            //    }
            //}

            //myList.Sort();

            //listBox1.DataSource = myList;


            List<int> myList = new List<int>() { };

            Random num = new Random();

            for (int i = 0; i < 500; i++)
            {
                int number = num.Next(1, 50); 

                if (myList.Contains(number) == false)  
                {
                    myList.Add(number); 
                }

                if (myList.Count == 6)
                {
                    break;
                }
            }
            myList.Sort();

            listBox1.DataSource = myList;

        }
    }
}
