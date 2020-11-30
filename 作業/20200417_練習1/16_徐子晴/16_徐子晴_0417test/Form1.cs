using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _16_徐子晴_0417test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //建立List
            List<Product> ProdList = new List<Product>()
            {
                //新增Product內容進List
                new Product(){Name="GPU",Price=1000,Count=100},
                new Product(){Name="CPU",Price=5000,Count=80},
                new Product(){Name="SSD",Price=500,Count=400},
            };
            //每個Prodlist的index項為item
            foreach ( Product item in ProdList)
            {
                //Print出來 組字串
                listBox1.Items.Add("產品名稱:"+item.Name+",價格:"+item.Price+",數量:"+item.Count);
            }
        }
    }
    //建立容器類別
    class Product
    {
        //修飾詞+型別+變數
        public string Name;
        public int Price;
        public int Count;

    }
}
