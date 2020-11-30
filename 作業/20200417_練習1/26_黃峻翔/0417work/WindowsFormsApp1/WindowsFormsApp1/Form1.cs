using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            List<Product> myList = new List<Product>() {
                new Product() { Name="記憶體", price=1500,count=3},
                new Product() { Name="處理器", price=3000,count=2},
                new Product() { Name="螢幕", price=3500,count=5}
            };

            foreach (Product item in myList)
            {
                listBox1.Items.Add($"產品名稱:{item.Name},價格:{item.price},數量:{item.count}");
            }
        }
    }

    class Product
    {
        public string Name;
        public int price;
        public int count;
    }
}
