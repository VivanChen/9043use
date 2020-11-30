using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lotto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //樂透號碼產生
            //數字在 1 - 49之間
            //不重複的號碼6個
            //產生之後請排序印出

            Random random = new Random(); //random 元件
            List<int> rndnum = new List<int>(); //建立一個list

            while (rndnum.Count < 6) //檢查有沒有6筆
            {
                int number = random.Next(1, 50);//隨機數
                if (rndnum.Contains(number) == false)//如果沒有重複
                {
                    listBox1.Items.Add(number);//把數字加入集合
                }
                
            }
            rndnum.Sort();//對我的集合做排列
            listBox1.DataSource = rndnum;//列印我的集合





        }
    }
}
