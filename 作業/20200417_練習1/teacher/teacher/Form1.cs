using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace teacher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Product> myList = new List<Product>() {
                new Product(){ Name="CPU" , Price=1000 , Count=5 },
                new Product(){ Name="RAM" , Price=1100 , Count=4 },
                new Product(){ Name="SSD" , Price=1200 , Count=3 }
            };

            foreach (Product item in myList)
            {
                //listBox1.Items.Add($"產品名稱: {item.Name}, 價格 : {item.Price}, 數量 : {item.Count}");
                listBox1.Items.Add(item.GetInfo());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<Product> myList = new List<Product>() {
                new Product(){ Name="VGA" , Price=1000 , Count=5 },
                new Product(){ Name="HDD" , Price=1100 , Count=4 },
            };

            foreach (Product item in myList)
            {
                //listBox1.Items.Add($"產品名稱: {item.Name}, 價格 : {item.Price}, 數量 : {item.Count}");
                listBox1.Items.Add(item.GetInfo());
            }
        }
    }
    class Product
    {
        public string Name;
        public int Price;
        public int Count;

        public string GetInfo()
        {
            return $"產品名稱: {Name}, 價格 : {Price}, 數量 : {Count}";
        }

    }
}
