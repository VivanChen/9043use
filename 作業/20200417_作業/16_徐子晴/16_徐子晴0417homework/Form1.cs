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

namespace _16_徐子晴0417homework
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //清除LISTBOX
            listBox1.DataSource = null;
            listBox1.Items.Clear();

            //呼叫return的ProList List<物件>內容
            List<Product> ProList = ProductUtility.GetProducts();

            //分每一組物件做成item
            foreach (Product item in ProList)
            {
                //如果school項等於下拉選單文字
                if (item.School == comboBox1.Text)
                {
                    //為什麼不能直接用Item印出來??
                    //將item轉成字串表示
                    listBox1.Items.Add(item.GetInfo());
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //清除LISTBOX
            listBox1.DataSource = null;
            listBox1.Items.Clear();

            //呼叫return的ProList List<物件>內容
            List<Product> ProList = ProductUtility.GetProducts();

            //分每一組物件做成item
            foreach (Product item in ProList)
            {
                //如果地址中找到__區
                if (item.Address.Contains(textBox1.Text))
                {
                    listBox1.Items.Add(item.GetInfo());
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //清除LISTBOX
            listBox1.DataSource = null;
            listBox1.Items.Clear();

            //呼叫return的ProList List<物件>內容
            List<Product> ProList = ProductUtility.GetProducts();

            //分每一組物件做成item
            foreach (Product item in ProList)
            {
                //如果Telephone項等於輸入文字
                if (item.Telephone == textBox2.Text)
                {
                    listBox1.Items.Add(item.GetInfo());
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //呼叫return的ProList List<物件>內容
            List<Product> ProList = ProductUtility.GetProducts();

            //八德路,士林區,大同區,大安區,中山區,中正區,內湖區,文山區,北投區,松山區,信義區,南港區,萬華區
            List<String> StrArea = new List<string>() {"八德路","士林區",
                "大同區","大安區","中山區","中正區","內湖區","文山區","北投區",
                "松山區","信義區","南港區","萬華區"};

            //分每一組物件做成item
            foreach (Product item in ProList)
            {

                foreach (string Area in StrArea)
                {
                    //如果地址中找到__//分區輸出CSV檔案
                    if (item.Address.Contains(Area))
                    {
                        listBox1.Items.Add(item.GetInfo());

                        //寫入檔案 
                        File.AppendAllText(
                                    $@"C:\16_test\16_徐子晴0417homework\{Area}.csv",
                                    $"{ item.GetInfo()}\r\n", Encoding.UTF8);
                    }
                }
            }

        }
    }
    /// <summary>
    ///class 宣告物件
    /// </summary>
    class Product
    {
        //宣告物件
        public String School;
        public string SchoolName;
        public string PostalCode;
        public string Address;
        public string Telephone;
        public string Lat;
        public string Lon;

        //組物件轉成字串
        public string GetInfo()
        {
            return $"{School},{SchoolName},{PostalCode},{Address},{Telephone},{Lat},{Lon}";
        }
    }
    /// <summary>
    /// class個方法,讀取檔案整理完
    /// </summary>
    class ProductUtility
    {
        public static List<Product> GetProducts()
        {

            //讀取檔案
            List<string> StrProdList = File.ReadAllLines(
                @"C:\16_test\16_徐子晴0417homework\1080416臺北市各級學校分布圖.csv").ToList();
            //去標題
            StrProdList.RemoveAt(0);
            //建立物件List     //static不可new 所以另外一個class宣告
            List<Product> prodList = new List<Product>();

            foreach (string item in StrProdList)
            {
                //將item每個index分開
                List<string> ItemList = item.Split(',').ToList();

                //新增到物件 List<物件>的方式!!!!!要記得方法
                prodList.Add(new Product()
                {
                    //上方宣告完的物件對照數值
                    School = ItemList[0],
                    SchoolName = ItemList[1],
                    PostalCode = ItemList[2],
                    Address = ItemList[3],
                    Telephone = ItemList[4],
                    Lat = ItemList[5],
                    Lon = ItemList[6],
                });

            }

            return prodList;
        }
    }
   
}
