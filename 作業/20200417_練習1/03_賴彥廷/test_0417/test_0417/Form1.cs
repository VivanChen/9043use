using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test_0417
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Product> ProductList = new List<Product>() {
                new Product(){ ProductName="CPU", ProductPrice=9000, ProductQuantity=10 },
                new Product(){ ProductName="GPU", ProductPrice=20000, ProductQuantity=5 },
                new Product(){ ProductName="RAM", ProductPrice=2000, ProductQuantity=30 }
            };


            for (int i = 0; i < ProductList.Count; i++)
            {
                listBox1.Items.Add($"產品名稱:{ProductList[i].ProductName},價格:{ProductList[i].ProductPrice},數量:{ProductList[i].ProductQuantity}");
            }

            //在使用一個Button與ListBox,
            //點選按鈕之後使用集合建立三筆Prodcut資料
            //並列印資訊至ListBox內,

            //ListBox的每一行資訊應該如下:
            //"產品名稱:XXX,價格XXX,數量XXX"
        }
    }
    public class Product
    {
        //請設計一個類別 名為 Product,
        //用來存放產品資料
        //1.名稱
        //2.價格
        //3.數量
        public string ProductName;
        public int ProductPrice;
        public int ProductQuantity;
    }
}
