using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _16_test_0414test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //清除listbox1
            listBox1.DataSource = null;
            listBox1.Items.Clear();
            //Ctrl K D

            //亂數
            Random rnd = new Random();
            int number = 0;
            //宣告list
            List<int> intList = new List<int> { number };
            //宣告下方使用的i ,再回圈內宣告會使i一直重製
            int i = 0;
            do
            {
                //隨機產生1~49數字
                number = rnd.Next(1, 50);

                //找list內number 沒有的話i++
                if (intList.Contains(number) == false)
                {
                    //將number加入list
                    intList.Add(number);
                    i++;
                }                                                                                                                                                 
                //持續家到i>=6以上就fale 跳下去
            } while (i < 6);

            //移除宣告的int i=0;
            intList.Remove(0);
            //排序
            intList.Sort();
            listBox1.DataSource = intList; 

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //清除listbox1
            listBox1.DataSource = null;
            listBox1.Items.Clear();
            //Ctrl K D

            //亂數
            Random rnd = new Random();
            int number = 0;
            //宣告list
            List<int> intList = new List<int> { number };
            //宣告下方使用的i ,再回圈內宣告會使i一直重製
            int i = 0;

            while(true)
            {
                //隨機產生1~49數字
                number = rnd.Next(1, 50);

                //找list內number 沒有的話i++
                if (intList.Contains(number) == false)
                {
                    //將number加入list
                    intList.Add(number);
                    i++;
                }
                //持續家到i>=6以上就fale 跳下去
                if (intList.Count == 7)
                {
                    //break:跳出迴圈
                    break;
                }
            }

            //移除宣告的int i=0;
            intList.Remove(0);
            //排序
            intList.Sort();
            listBox1.DataSource = intList;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //清除listbox1
            listBox1.DataSource = null;
            listBox1.Items.Clear();
            //Ctrl K D

            //亂數
            Random rnd = new Random();
            int number = 0;
            //宣告list
            List<int> intList = new List<int> { number };
            //宣告下方使用的i ,再回圈內宣告會使i一直重製
            int i = 0;
            do
            {
                //隨機產生1~49數字
                number = rnd.Next(1, 50);

                //找list內number 沒有的話i++
                if (intList.Contains(number) == true)
                {
                    //continue:此程式跳過,繼續執行迴圈
                    continue;
                }
                    //將number加入list
                    intList.Add(number);
                    i++;

                //持續家到i>=6以上就fale 跳下去
            } while (i < 6);

            //移除宣告的int i=0;
            intList.Remove(0);
            //排序
            intList.Sort();
            listBox1.DataSource = intList;

        }
    }
}
