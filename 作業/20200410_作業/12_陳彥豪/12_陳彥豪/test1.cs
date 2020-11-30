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
            int tatol = Convert.ToInt32(textBox2.Text) * Convert.ToInt32(textBox3.Text);
            File.AppendAllText("prod.csv",
                $"{textBox1.Text},{textBox2.Text},{textBox3.Text},{tatol} \r\n", Encoding.UTF8);

        }

        private void test1_Load(object sender, EventArgs e)
        {
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> pList = File.ReadAllLines("prod.csv").ToList();
            pList.RemoveAt(0);
            listBox1.DataSource = pList;
            

            //listBox1.Items.Add(pList);
        }
        
        private void button6_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            listBox1.Items.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<string> pList = File.ReadAllLines("prod.csv").ToList();
            listBox1.DataSource = null;
            listBox1.Items.Clear();
            listBox1.Items.Add(pList[Convert.ToInt32(textBox4.Text)]);
            

        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            listBox1.Items.Clear();
           
            List<string> pList = File.ReadAllLines("prod.csv").ToList();
            
            

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
            listBox1.DataSource = null;
            listBox1.Items.Clear();
            List<string> pList = File.ReadAllLines("prod.csv").ToList();
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
                        listBox1.Items.Add($"{ myProduct[0]} ,{ myProduct[1]} ,{ myProduct[2]},{ myProduct[3]}");
                    }
                                          
            }
              print("查無產品");
           

        }
            
    } 
}
