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
            List<Product> ProductList = new List<Product>()
            {
                new Product(){Name ="cpu",Price = 100,count =50},
                new Product(){Name ="vga",Price = 50,count =50},
                new Product(){Name ="ram",Price = 20,count =50}
            };
            foreach (Product item in ProductList)
            {
                listBox1.Items.Add(item.ShowAll());
            }
        }
    }
    class Product
    {
        public string Name;
        public int Price;
        public int count;


        public string ShowAll()
        {
            return $"產品名稱:{Name},價格:{Price},數量:{count},總價{Price* count}";
        }
    }
}
