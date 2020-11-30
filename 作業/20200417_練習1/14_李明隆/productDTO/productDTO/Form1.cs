using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace productDTO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Product> productList = new List<Product>()
            {
                new Product() { Name="PC", Price="1000",Count="2"},
                new Product() { Name="CD", Price="200",Count="1"},
                new Product() { Name="VGA", Price="3000",Count="3"}

            };

            //for (int i = 0; i < productList.Count; i++)
            //{
            //    listBox1.Items.Add(productList[i].GetProductInfo());
            //}

            foreach (Product item in productList)
            {
                listBox1.Items.Add(item.GetProductInfo());
            }
        }
    }

    public class Product
    {
        public string Name;
        public string Price;
        public string Count;

        public string GetProductInfo()
        {
            return $"產品名稱:{Name},價格:{Price},數量:{Count}";
        }
    }
}
