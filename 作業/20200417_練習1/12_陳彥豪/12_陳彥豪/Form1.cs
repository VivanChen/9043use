using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12_陳彥豪
{
    class product
        {
           public string ProductName;
           public Double ProductPrice;
           public int ProductNumber;

        public string GetInfo()
        {
            return $"名稱: {ProductName} 價格: {ProductPrice} 數量: {ProductNumber}";
        }
        }
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<product> productList = new List<product>()

            {new product() { ProductName="顯示卡",ProductPrice=5000,ProductNumber=1},
             new product() { ProductName="記憶體",ProductPrice=500,ProductNumber=4 },
             new product() { ProductName = "主機板", ProductPrice = 2000, ProductNumber = 1 }
            };
            foreach (product item in productList)
            {
              listBox1.Items.Add(item.GetInfo());
            }
        }
    }
}
