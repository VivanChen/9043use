using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            //Ctrl K D
            //數字在 1 - 49之間
            //不重複的號碼6個 => 不確定次數
            //產生之後請排序印出

            Random rnd = new Random();
            List<int> numberList = new List<int>();

            while (numberList.Count < 6)  //集合數量小於6的時候,一直跑
            {
                int number = rnd.Next(1, 50); //產生1-49的隨機亂數

                if( numberList.Contains(number) == false)  //檢查該數字是否不存在於集合
                {
                    numberList.Add(number); //不存在的話,就加入集合中
                }
            }

            numberList.Sort();

            listBox1.DataSource = numberList;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            List<int> numberList = new List<int>();

            while (true)  //集合數量小於6的時候,一直跑
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
