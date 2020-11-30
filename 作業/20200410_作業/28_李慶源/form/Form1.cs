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

namespace form
{
    public partial class Form1 : Form
    {
        static void print(object o)
        {
            MessageBox.Show(o.ToString());
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //File.WriteAllText("form.csv", "產品名稱,價格,數量,總價", Encoding.UTF8);
        }

        private void button2_Click(object sender, EventArgs e)
        {


            int number = Convert.ToInt32(textBox2.Text);
            int number1 = Convert.ToInt32(textBox3.Text);
            int number2 = number * number1;

            if (File.Exists("form.csv"))    //File.Exists = 判斷檔案是否存在
            {
                print(textBox1.Text + "輸出完成");
                File.AppendAllText(
                    "form.csv", "\r\n" + textBox1.Text + "," + textBox2.Text + "," + textBox3.Text + "," + number2);
            }
            else
            {
                File.WriteAllText("form.csv", "產品名稱,價格,數量,總價", Encoding.UTF8);
                print(textBox1.Text + "輸出完成");
                File.AppendAllText(
                    "form.csv", "\r\n" + textBox1.Text + "," + textBox2.Text + "," + textBox3.Text + "," + number2);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HOMEWORK f = new HOMEWORK();
            f.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<string> source = File.ReadAllLines("form.csv").ToList();
            listBox1.DataSource = source;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (File.Exists("form.csv"))
            {
                listBox1.DataSource = null;
                listBox1.Items.Clear();
            }
            else
            {
            }
            List<string> soruce = File.ReadAllLines("form.csv").ToList();      //資料來源為"form"
            listBox1.Items.Add(soruce[Convert.ToInt32(textBox4.Text)]);        //利用索引值去搜尋"form"的資料並顯示出來
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (File.Exists("form.csv"))
            {
                listBox1.DataSource = null;
                listBox1.Items.Clear();         //清除listbox上的所有數字
            }

            List<string> soruce = File.ReadAllLines("form.csv").ToList();

            foreach (string num in soruce)
            {

                if (num.Contains(textBox5.Text))
                {
                    listBox1.Items.Add(num);
                }
            }


            //for (int i = 0; i < soruce.Count; i++)
            //{
            //    if (soruce[i].Contains(textBox5.Text))
            //    {
            //        listBox1.Items.Add(soruce[i]);
            //    }
            //}

        }
        private void button6_Click(object sender, EventArgs e)
        {
            if (File.Exists("form.csv"))
            {
                listBox1.DataSource = null;
                listBox1.Items.Clear();
            }

            //List<string> soruce = File.ReadAllLines("form.csv").ToList();

            //for (int i = 0; i <= soruce.Count; i++)      //宣告 i= 0, i小於"form.csv"的所有索引值 比如是6 , i+1
            //{
            //    if (soruce[i].Contains(textBox6.Text))  //判斷 textbox輸入的字串為多少索引值傳回給"from.csv"[i] 
            //                                            //如果i跟傳回索引值不一樣則在進行一次迴圈

            //    {
            //        listBox1.Items.Add(soruce[i]);
            //    }
            //}
            List<string> soruce = File.ReadAllLines("form.csv").ToList();

            foreach (string num in soruce)
            {
                string[] my = num.Split(',');

                   if (my[0] == textBox6.Text)
                {
                    listBox1.Items.Add($"{my[0]} , {my[1]} , {my[2]} , {my[3]}");
                }
            }
            if (string.IsNullOrEmpty(textBox6.Text))
            {
                listBox1.Items.Clear();
                MessageBox.Show("輸入錯誤");
            }            

        }
    }
}   


  

