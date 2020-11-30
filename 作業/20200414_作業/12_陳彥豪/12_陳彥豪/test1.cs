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


namespace _12_陳彥豪
{
    public partial class test1 : Form
    {
        public test1()
        {
            InitializeComponent();
        }
        static void print(object o)
        {
            MessageBox.Show(o.ToString());
        }
              
        List<string> GetStart()
        {
            List<string> pList = File.ReadAllLines("prod.csv").ToList();  
            listBox1.DataSource = null;
            listBox1.Items.Clear();
            pList.RemoveAt(0);

            return pList;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Exists (檢查檔案是否存在)
            if (File.Exists("prod.csv") == false)
                {
                File.WriteAllText("prod.csv", "產品名稱,價格,數量,總價\r\n", Encoding.UTF8);
            }
                else

            //輸出資料
            MessageBox.Show(textBox1.Text + "輸出完成");
            int tatol = Convert.ToInt32(textBox2.Text) * Convert.ToInt32(textBox3.Text);  //tatol 等於tbox2(價格)+tbox3(數量)
            File.AppendAllText("prod.csv",
                $"{textBox1.Text},{textBox2.Text},{textBox3.Text},{tatol} \r\n", Encoding.UTF8);

        }

        private void test1_Load(object sender, EventArgs e)
        {
            login f = new login();
            f.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //List<string> pList = File.ReadAllLines("prod.csv").ToList();     //1
            //pList.RemoveAt(0);
            List<string> pList = GetStart();

            listBox1.DataSource = pList;
            
        }
        
        private void button6_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            listBox1.Items.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<string> pList = GetStart();

            listBox1.Items.Add(pList[Convert.ToInt32(textBox4.Text)]);
            

        }

        private void button4_Click(object sender, EventArgs e)
        {
            List<string> pList = GetStart();

            foreach (string proDuct in pList)
            {
                 if ( proDuct.Contains(textBox5.Text))
                {
                    listBox1.Items.Add(proDuct);
                }
            }
         }

        private void button5_Click(object sender, EventArgs e)
        {
            List<string> pList = GetStart();

            if (string.IsNullOrEmpty(textBox6.Text))
            {
                print("請輸入產品名稱");
            }
            else
             foreach (string proDuct in pList)
            {
                 string[] myProduct = proDuct.Split(',');
                    if (myProduct[0] == textBox6.Text)
                    {
                        listBox1.Items.Add(proDuct);
                    }
             }
            
           

        }

        private void button7_Click(object sender, EventArgs e)
        {
            List<string> pList = GetStart();

            foreach (string proDuct in pList)
                {
                    string[] myProduct = proDuct.Split(',');
                    int price = Convert.ToInt32(myProduct[1]);       //價格=myProduct[1]
                    if (price  >= Convert.ToInt32(textBox7.Text))     //價格大於tBox7的數
                    {
                        listBox1.Items.Add(proDuct);
                    }
                }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            List<string> pList = GetStart();

            foreach (string proDuct in pList)
            {
                string[] myProduct = proDuct.Split(',');
                string proDuctName = myProduct[0];     //產品名稱=
                string price = myProduct[1];                 //價格=

                listBox1.Items.Add($"名稱：{proDuctName},價格：{price}元");


            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            List<string> newList = new List<string>();
            List<string> pList = File.ReadAllLines("prod.csv").ToList();
            foreach (string proDuct in pList)
            {
                string[] myProduct = proDuct.Split(',');
                if (myProduct[0] != textBox8.Text)   //設產品名稱 不等於 tBbox8 
                {
                    newList.Add(proDuct);  //proDuct 加到 newList
                    File.WriteAllLines("prod.csv", newList, Encoding.UTF8); //將newList覆寫 prod檔
                }
            }
            print("刪除成功");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            List<string> newList = new List<string>();
            List<string> pList = File.ReadAllLines("prod.csv").ToList();
            foreach (string proDuct in pList)
            {
                string[] myProduct = proDuct.Split(',');  //將合拆開
                string proDuctName = myProduct[0];    
                string proDuctPrice = myProduct[1];
                string proDuctNumber = myProduct[2];
                int total = 0;
                string change;
                if (myProduct[0] == textBox9.Text)   //如果 產品名稱 等於 tBox9
                {
                    
                    if (textBox10.Text == "")             //如果價格(tBox10沒打)
                    {
                        proDuctPrice = myProduct[1];   //價格=原價格
                    }
                    else
                    { 
                        proDuctPrice = textBox10.Text;   //否則  價格=tBox10中的數
                    }
                     if (textBox11.Text == "")              //如果數量(tBox10沒打)
                    {
                        proDuctNumber = myProduct[2];   //數量=原數量
                    }
                    else
                    {
                     proDuctNumber = textBox11.Text;    //否則  數量=tBox11中的數
                    }
                    total = Convert.ToInt32(proDuctPrice) * Convert.ToInt32(proDuctNumber);  //total 等於 價格*數量
                    change = $"{proDuctName},{proDuctPrice},{proDuctNumber},{total}";     // change放 字串組合 名稱,價格,數量,總價
                    newList.Add(change);                                         
                }
                else
                {
                    newList.Add(proDuct);
                }
            }
            File.WriteAllLines("prod.csv", newList, Encoding.UTF8);  //將newList覆寫 prod檔
            print("修改成功");

        }

        private void button11_Click(object sender, EventArgs e)
        {
            List<string> newList = new List<string>();
            List<string> pList = File.ReadAllLines("prod.csv").ToList();
            newList = pList.ToList();
            string del = string.Empty;   //del = 空字串
            foreach (string proDuct in pList)
            {
                string[] myProduct = proDuct.Split(',');
                if (myProduct[0] == textBox8.Text)   //設產品名稱 不等於 tBbox8 
                {
                    del = proDuct;
                    newList.Remove(del);
                }
            }
            
            File.WriteAllLines("prod.csv", newList, Encoding.UTF8); //將newList覆寫 prod檔
            print("刪除成功");
        }
    } 
}
