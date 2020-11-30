using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//加入file.writealltest用
using System.IO;

namespace _16_徐子晴_0409test2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static void print(object o)
        {
            MessageBox.Show(o.ToString());
        }
        private void label1_Click(object sender, EventArgs e)
        {
           
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //呼叫小視窗
            LoginForm f = new LoginForm();
            f.ShowDialog();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            //輸出參數對應prodsave
            string ProdCsvSave;
            Prodsave(out ProdCsvSave);

            File.WriteAllText(ProdCsvSave, "產品名稱,價格,數量,總價\r\n", Encoding.UTF8);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            

            ////空白全刪
            string d = textBox1.Text.Trim();
            //接收字串
            string a = textBox1.Text;
            //轉int計算
            var InputPrice = Convert.ToInt32(textBox2.Text);
            var InputCount = Convert.ToInt32(textBox3.Text);
            int total = InputPrice * InputCount;

            //輸出參數對應prodsave
            string ProdCsvSave;
            Prodsave(out ProdCsvSave);

            //判斷Name
            //字串長度<=0
            //if (c.Length<=0)
            //{
            //    print("產品名稱必須填");
            //}

            //扣除空白後,""就print
            //null或empty(""),print    但是"空白空白"依然有bug 還有重複輸入bug
            if (String.IsNullOrEmpty(a) || d == "")
            {
                print("產品名稱必須填");
            }

            ////空白也可以print出
            //if (textBox1.Text == "")
            //{
            //    print("產品名稱必須填");
            //}

            //判斷Price與Count是否小於等於0
            // = 為指定,不能寫在前面
           
            else if (InputPrice <= 0 || InputCount <= 0)
            {
                print("價格與數量不可以小於0");
            }
            else
            {

                //儲存為重複字串
                File.AppendAllText(ProdCsvSave,
                    $"{textBox1.Text},{InputPrice},{InputCount},{total}\r\n",
                    Encoding.UTF8);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //////查詢產品
            ////讀取csv資料(用readalltext都會便字元)轉成字串
            ////string str = File.ReadAllText(@"D:\C#課程\16_test\16_徐子晴_0410test 001\prod.csv");
            //////讀取讀取csv資料(用readallline)轉成字串
            //List<string> strlist= File.ReadAllLines(@"C:\16_test\16_徐子晴_0410test 02\prod.csv").ToList();
            //////移除index 0的標題
            //strlist.RemoveAt(0);
            ////把符號切除, 方便從文件讀取print出
            ////List<string> strlist = str.Split('char').ToList();

            //清除listbox資料+拿取csv檔轉list+刪除標題
            List<string> strlist = ClearListInputCsv();

            ////資料繫結 : DataSource
            listBox1.DataSource = strlist;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //清空listBox1, 先將ListBox用成空集合 , 再CLEAR
            listBox1.DataSource = null;
            listBox1.Items.Clear();

            //輸出參數對應prodsave
            string ProdCsvSave;
            Prodsave(out ProdCsvSave);
            //查詢產品
            //讀取csv資料轉list
            List<string> strlist = File.ReadAllLines(ProdCsvSave).ToList();
            //輸入查詢值
            int box4Index = Convert.ToInt32(textBox4.Text);
            

        }
        private void button5_Click(object sender, EventArgs e)
        {

            //清空listBox1, 先將ListBox用成空集合 , 再CLEAR
            listBox1.DataSource = null;
            listBox1.Items.Clear();

            //輸出參數對應prodsave
            string ProdCsvSave;
            Prodsave(out ProdCsvSave);

            //查詢產品
            //讀取csv資料轉list
            //string str = File.ReadAllText(@"C:\16_test\16_徐子晴_0410test 02\prod.csv");

            //listBox1.Items.Add(StringList1.Contains(textBox5.Text));
            List<string> strlist = File.ReadAllLines(ProdCsvSave).ToList();

            //移除標題
            strlist.RemoveAt(0);

            //strlist每個值放進item
            foreach (string item in strlist)
            {
                //item是否有textbox5
                if (item.Contains(textBox5.Text))
                {
                    listBox1.Items.Add(item);

                } 
            }



        }

        private void button6_Click(object sender, EventArgs e)
        {
            List<string> strlist = ClearListInputCsv();
            ////清空listBox1, 先將ListBox用成空集合 , 再CLEAR
            //listBox1.DataSource = null;
            //listBox1.Items.Clear();

            
            //strlist每個值放進item
            foreach (string item in strlist)
            {

                //移除item內的',' 組成list
                List<string> pList = item.Split(',').ToList();

                if (pList[0] == textBox6.Text)
                {
                    listBox1.Items.Add(item);
                }
            }
        }

        //清除listbox資料+拿取csv檔轉list+刪除標題
        List<string> ClearListInputCsv()
        {
            //輸出參數對應prodsave
            string ProdCsvSave;
            Prodsave(out ProdCsvSave);

            //清空listBox1, 先將ListBox用成空集合 , 再CLEAR
            listBox1.DataSource = null;
            listBox1.Items.Clear();
            //listBox1.Items.Add(StringList1.Contains(textBox5.Text));
            List<string> strlist = File.ReadAllLines(ProdCsvSave).ToList();
            //去掉標題 insex=0 這一項
            strlist.RemoveAt(0);
            return strlist;
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            //清除listbox資料+拿取csv檔轉list+刪除標題
            List<string> strlist = ClearListInputCsv();

            //新建list,取代原本資料的strlist
            List<string> NewList = new List<string>() ;

            //輸出參數對應prodsave
            string ProdCsvSave;
            Prodsave(out ProdCsvSave);

            //strlist每個值放進item
            foreach (string item in strlist)
            {

                //移除item內的',' 組成list
                List<string> pList = item.Split(',').ToList();

                if (pList.Contains(textBox7.Text) == false)
                {
                    NewList.Add(item);
                }

            }

            ////NewList print測試
            listBox1.DataSource = NewList;

            //將舊資料刪除,新增newlist為新資料
            File.Delete(ProdCsvSave);
            //新增prod.csv 還有標題
            File.AppendAllText(ProdCsvSave, "產品名稱,價格,數量,總價\r\n", Encoding.UTF8);
            //新增修改過的newlist
            File.AppendAllLines(ProdCsvSave, NewList, Encoding.UTF8);
        }

        //存檔點修改!!!使用輸出參數~~
        void Prodsave(out string x)
        {
             x = @"C:\16_test\16_徐子晴_0414 homework\prod.csv";
        }


        private void button7_Click(object sender, EventArgs e)
        {
            //清除listbox資料+拿取csv檔轉list+刪除標題
            List<string> strlist = ClearListInputCsv();

            //新建list,取代原本資料的strlist
            List<string> NewList = new List<string>();

            //輸出參數對應prodsave
            string ProdCsvSave;
            Prodsave(out ProdCsvSave);

            //strlist每個值放進item
            foreach (string item in strlist)
            {

                //移除item內的',' 組成list
                List<string> pList = item.Split(',').ToList();

                //如果產品名稱有找到
                if (pList.Contains(textBox8.Text) == true)
                {
                    //string轉int,計算總價
                    int Price = Convert.ToInt32(textBox9.Text);
                    int Count = Convert.ToInt32(textBox10.Text);
                    int total = Price * Count;

                    string TotalString = Convert.ToString(total);
                    //新增修改的item,組字串
                    NewList.Add($"{textBox8.Text},{textBox9.Text},{textBox10.Text},{TotalString}");

                }
                else if (pList.Contains(textBox8.Text) ==false)
                {
                    //新增原本的Item回去
                    NewList.Add(item);
                }
                else
                {
                    //新增原本的Item回去
                    NewList.Add(item);
                    MessageBox.Show("名稱查詢不到");
                }
            }

            ////NewList print測試
            listBox1.DataSource = NewList;

            //將舊資料刪除,新增newlist為新資料
            File.Delete(ProdCsvSave);
            //新增prod.csv 還有標題
            File.AppendAllText(ProdCsvSave, "產品名稱,價格,數量,總價\r\n", Encoding.UTF8);
            //新增修改過的newlist
            File.AppendAllLines(ProdCsvSave, NewList, Encoding.UTF8);


        }
    }
}
