using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
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

        void GetSart()
        {
            listBox1.DataSource = null;
            listBox1.Items.Clear();
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
            source.RemoveAt(0);
            listBox1.DataSource = source;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            GetSart();   //清除listbox上的所有數字

            List<string> soruce = File.ReadAllLines("form.csv").ToList();      //資料來源為"form"
            listBox1.Items.Add(soruce[Convert.ToInt32(textBox4.Text)]);        //利用索引值去搜尋"form"的資料並顯示出來
        }

        private void button5_Click(object sender, EventArgs e)
        {
            GetSart();        //清除listbox上的所有數字

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
            //List<string> soruce = File.ReadAllLines("form.csv").ToList();

            //for (int i = 0; i <= soruce.Count; i++)      //宣告 i= 0, i小於"form.csv"的所有索引值 比如是6 , i+1
            //{
            //    if (soruce[i].Contains(textBox6.Text))  //判斷 textbox輸入的字串為多少索引值傳回給"from.csv"[i] 
            //                                            //如果i跟傳回索引值不一樣則在進行一次迴圈

            //    {
            //        listBox1.Items.Add(soruce[i]);
            //    }
            //}

            GetSart();   //清空ListBox資訊

            List<string> soruce = File.ReadAllLines("form.csv").ToList();

            if (string.IsNullOrEmpty(textBox6.Text))
            {
                listBox1.Items.Clear();
                MessageBox.Show("輸入錯誤");
            }

            foreach (string num in soruce)
            {
                string[] my = num.Split(',');

                if (my[0] == textBox6.Text)
                {
                    //listBox1.Items.Add($"{my[0]} , {my[1]} , {my[2]} , {my[3]}");
                    listBox1.Items.Add(num);
                }
            }


        }

        private void button7_Click(object sender, EventArgs e)
        {
            List<string> soruce = File.ReadAllLines("prod.csv").ToList();

            soruce.RemoveAt(0);  //去掉表頭

            GetSart();   //清空ListBox資訊

            int number = Convert.ToInt32(textBox7.Text);    //因為比較數字需轉成int

            foreach (string item in soruce)
            {
                List<string> num = item.Split(',').ToList();
                int a = Convert.ToInt32(num[1]);              //因為比較數字需轉成int

                if (a >= number)
                {
                    listBox1.Items.Add(item);
                }
            }


        }

        private void button8_Click(object sender, EventArgs e)
        {
            List<string> soruce = File.ReadAllLines("prod.csv").ToList();

            soruce.RemoveAt(0);  //去掉表頭

            GetSart();    //清除ListBox資料

            foreach (string item in soruce)
            {
                List<string> num = item.Split(',').ToList();    //切成"產品名稱""價錢"....比較好判斷        

                listBox1.Items.Add($" {"名稱:"},{num[0]} ,{"價格:"},{num[1]}");
            }

            //List<string> soruce = File.ReadAllLines("prod.csv").ToList();
            //soruce.RemoveAt(0);
            //listBox1.DataSource = null;
            //listBox1.Items.Clear();

            //for (int i = 0; i < soruce.Count; i++)
            //{
            //    string num = Convert.ToString(soruce);
            //    List<string> num2 = num.Split(',').ToList();
            //    listBox1.Items.Add(num2);
            //}
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //List<string> soruce = File.ReadAllLines("form.csv").ToList();
            //List<string> newsoruce = new List<string>();
            //newsoruce = soruce.ToList();

            //foreach (string num in soruce)
            //{
            //    string[] my = num.Split(',');
            //    if (my[0] == textBox8.Text)
            //    {
            //        newsoruce.Remove(num);

            //    }

            //}        
            //File.WriteAllLines("form.csv", newsoruce, Encoding.UTF8);


            List<string> soruce = File.ReadAllLines("form.csv").ToList();


            for (int i = soruce.Count - 1; i >= 0; i--)       //利用for迴圈從後面開始搜尋並刪除
            {
                string B = string.Join(",", soruce[i]);      //集合轉字串
                string[] C = B.Split(',');                   //字串切完轉陣列
                if (C[0] == textBox8.Text)
                {
                    soruce.Remove(B);
                    File.WriteAllLines("form.csv", soruce, Encoding.UTF8);
                }
            }
        }




        private void button10_Click(object sender, EventArgs e)
        {
            //int number = Convert.ToInt32(textBox10.Text);              //將字串轉成值
            //int number1 = Convert.ToInt32(textBox11.Text);
            //int number2 = number * number1;

            //List<string> soruce = File.ReadAllLines("form.csv").ToList();     //取資料集合
            //string a = "";                                                      //用字串去接要刪除的值


            //foreach (string num in soruce)
            //{
            //    string[] my = num.Split(',');                         //切成"產品名稱","價格"....
            //    if (my[0] == textBox9.Text)
            //    {
            //        a = num;                                             //勇空自串接刪除的值

            //    }

            //}
            //soruce.Remove(a);                                           //刪除
            //File.WriteAllLines("form.csv", soruce, Encoding.UTF8);       //覆蓋

            //File.AppendAllText("form.csv", textBox9.Text + "," + textBox10.Text + "," + textBox11.Text + "," + number2);   //再附加新的值



            List<string> newsoruce = new List<string>();
            List<string> soruce = File.ReadAllLines("form.csv").ToList();
            //newsoruce = soruce.ToList();

            int number1 = int.Parse(textBox10.Text);
            int number2 = int.Parse(textBox11.Text);
            int total = number1 * number2;
            string number = textBox9.Text;

            foreach (string num  in soruce)
            {
                string[] my = num.Split(',');
                if (my[0]==textBox9.Text)
                {
                    if (my[1] != textBox10.Text)
                    {
                        number1 = Convert.ToInt32(textBox10.Text);
                        
                        if (my[2]!= textBox11.Text)
                        {
                            number2 = Convert.ToInt32(textBox11.Text);
                            newsoruce.Add($"{ number},{ number1},{ number2},{ total}");

                        }
                       
                        
                    }
                }
                 else
                        {
                            newsoruce.Add(num);
                        }
            }
            //newsoruce.Add(Catch);
            File.WriteAllLines("form.csv", newsoruce, Encoding.UTF8);

        }


    }
}




