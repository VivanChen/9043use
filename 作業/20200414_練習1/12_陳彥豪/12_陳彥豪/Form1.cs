using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12_陳彥豪
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            List<int> randomList = new List<int>();
            Random rNum = new Random();
              
            while (randomList.Count <6) //集合數量小於6時，跑程式
            {
                int num = rNum.Next(1, 50); //產生1-49亂數
                if (randomList.Contains(num)==false) //判斷是否存在集合內
                {
                    randomList.Add(num);//沒有的話就加入
                }
            }
            randomList.Sort(); //排序集合
            listBox1.DataSource = randomList;//資料繫結
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<int> randomList = new List<int>();
            Random rNum = new Random();
            for (int i = 0; i < 6; i++)
            {
                randomList.Add(rNum.Next(1, 50)); //產生1-50亂數 
                for (int j = 0; j < i; j++)
                {
                    while (randomList[j] == randomList[i]) //檢查是否與前面產生數值重複
                    {
                        j = 0; //重複的話J設為0 再次檢查
                        randomList[i] = rNum.Next(1, 50);//重新產生，存回陣列
                    }
                }
            }
            listBox1.DataSource = randomList;
        }
    }
}
