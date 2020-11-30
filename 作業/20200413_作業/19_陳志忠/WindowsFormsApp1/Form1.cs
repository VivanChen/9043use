using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            File.AppendAllText("a.csv", "產品名稱,價格,數量,總價", Encoding.UTF8);
        }

        private void button2_Click(object sender, EventArgs e)
        {

            int a = Convert.ToInt32(textBox2.Text);
            int b = Convert.ToInt32(textBox3.Text);

            File.AppendAllText("a.csv", "\r\n" + textBox1.Text + "," + textBox2.Text + "," + textBox3.Text + "," + a * b);

            MessageBox.Show(label1.Text + textBox1.Text + "儲存成功");
        }



        //預先載入視窗
        private void Form1_Load(object sender, EventArgs e)
        {
            Form2 longin = new Form2();
            longin.ShowDialog();
        }



        //列出所有資料
        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            List<string> AllList = File.ReadAllLines("a.csv").ToList();

            for (int i = 1; i < AllList.Count; i++)
            {
                listBox1.Items.Add(AllList[i]);
            }
        }


        //查詢某筆資料
        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            List<string> sor = File.ReadAllLines("a.csv").ToList();

            switch (textBox4.TextLength)
            {
                case 0:
                    MessageBox.Show("請輸入第幾筆");
                    break;

                default:

                    int a = Convert.ToInt32(textBox4.Text);

                    //第0筆資料是抬頭，但Count有算到
                    if (a > sor.Count - 1)
                    {
                        listBox1.Items.Add($"請輸入比{a}小的數");
                    }
                    else if (a > 0 && a <= sor.Count - 1)
                    {
                        listBox1.Items.Add(sor[a]);
                    }
                    else
                    {
                        listBox1.Items.Add("請輸入大於0之整數");
                    }
                    break;
            }



        }




        //以產品名搜尋
        private void button5_Click(object sender, EventArgs e)
        {
            string b = textBox5.Text;

            listBox1.Items.Clear();
            
            //讀出資料成集合，去掉不要的
            List<string> list1 = File.ReadAllLines("a.csv").ToList();
            list1.RemoveAt(0); //給索引值移除
            //list1.Remove("產品名稱,價格,數量,總價");

            //再轉字串重新整理集合(建成一個新集合)
            string st = string.Join(",", list1);

            List<string> list2 = st.Split(',').ToList();

            //判斷輸入有無在集合中
            if (list2.Contains(b))
            {
                List<string> list3 = new List<string>();

                for (int i = Convert.ToInt32(list2.IndexOf(b)); i < list2.IndexOf(b) + 4; i++)
                {
                    list3.Add(list2[i]);
                }

                string st2 = string.Join(",", list3);

                listBox1.Items.Add(st2);
            }
            else
            {
                MessageBox.Show("產品不存在");
            }


        }


        //關鍵字搜尋
        private void button6_Click(object sender, EventArgs e)
        {
            //先清畫面
            listBox1.Items.Clear();

            string but6 = textBox6.Text;

            List<string> list1 = File.ReadAllLines("a.csv").ToList();
            list1.Remove("產品名稱,價格,數量,總價");

            //這樣就可以了
            foreach (var item in list1)   //列出所有的item
            {
                List<string> list3 = item.Split(',').ToList();  //
                if (list3[0].Contains(but6))
                {
                    listBox1.Items.Add(item);
                }
            }


            //string st2 = string.Join(",", list1);

            //List<string> list2 = st2.Split(',').ToList();

            //原來字串用Contains可以當模糊搜尋

            //把每個都列出然後都比較字串
            //如果true就將當下序號往後加3，都存入另一集合
            //再轉字串列出
            //for (int i = 0; i < list2.Count; i++)
            //{
            //    if (list2[i].Contains(but6))
            //    {
            //        List<string> a = new List<string>();
                    
            //        for (int t = i; t < i + 4; t++)
            //        {
            //            a.Add(list2[t]);
            //        }
            //        string str = string.Join(",", a);
            //        listBox1.Items.Add(str);
            //    }

            //}


        }


        //產品價格大於??
        private void button8_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            int a = Convert.ToInt32(textBox7.Text);

            List<string> list1 = File.ReadAllLines("a.csv").ToList();
            list1.RemoveAt(0);

            foreach (var item in list1)
            {
                List<string> list2 = item.Split(',').ToList();

                if (Convert.ToInt32(list2[1]) > a)
                {
                    listBox1.Items.Add(item);
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            List<string> list1 = File.ReadAllLines("a.csv").ToList();
            list1.RemoveAt(0);

            foreach (var item in list1)
            {
                List<string> list2 = item.Split(',').ToList();
                
               listBox1.Items.Add($"產品名稱: {list2[0]} , 價格: {list2[1]}");
               
            }
        }
    }
}
