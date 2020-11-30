using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 練習0417
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Product> company = new List<Product>()
            {
                new Product(){Price=100,ProductName="Ram",Count=10 },
                new Product(){Price=100,ProductName="CPU",Count=10 },
                new Product(){Price=100,ProductName="HDD",Count=10 }
        };
            foreach (Product item in company)
            {
                listBox1.Items.Add($"產品名稱:{item.ProductName}, 價格:{item.Price},數量:{item.Count}");
            }

        
        }


        class Product
        {
            public int Price;
            public string ProductName;
            public int Count;
        }
    }
}
