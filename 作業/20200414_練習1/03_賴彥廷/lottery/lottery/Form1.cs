using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lottery
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //listBox1.Items.Clear();
            //Random lotteryans = new Random();
            //List<int> lotterynumber = new List<int>();

            //while (lotterynumber.Count<6)
            //{
            //    int number = lotteryans.Next(1, 50);
            //    if(lotterynumber.Contains(number) == false)
            //    {
            //        lotterynumber.Add(number);
            //    }
            //}
            //lotterynumber.Sort();

            //listBox1.DataSource = lotterynumber;


            //設定一組lotterynumbers集合，用來存放1-49的數字
            List<int> lotterynumbers = new List<int>();
            
            //利用迴圈存放1-49的數字，到lotterynumbers集合中
            int number;
            number= 0;
            for (int i = 1; i <= 49; i++)
            {
                number = i;                   //一次只存放一個數字，所以用 number= i (因不需要累加)
                lotterynumbers.Add(number);   //存到集合中，存49次，共49個號碼
            }

            //亂數
            Random lottery = new Random();

            //設一個output集合，存6個號碼
            List<int> output = new List<int>();
            
            //迴圈run 6次
            for (int i = 0; i <6 ; i++)
            {
                int index = lottery.Next(lotterynumbers.Count); //設 index 來接亂數抽取的號碼  (lotterynumbers.Count為集合中的數量)
                output.Add(lotterynumbers[index]);              //每一次亂數抽取的號碼index，存到output集合中
                lotterynumbers.RemoveAt(index);                 //移除亂數抽取的號碼 index 在集合中對應的值，迴圈跑下一次時，集合中的數量(lotterynumbers.Count)會減少一次，以避免重複取值
            }
            output.Sort();                                      //排序output集合
            listBox1.DataSource = output;                       //print output集合
        }
    }
}
