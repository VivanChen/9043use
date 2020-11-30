using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _28_李慶源
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            List<Product> myList = new List<Product>()
            {
                new Product() { Name = "主機板",Price = 15000 , Quantity = 2 },
                new Product() { Name = "記憶體",Price = 1200 , Quantity = 4},
                new Product() { Name = "顯示卡",Price = 13000 , Quantity = 1}
            };
            foreach (Product item in myList)
            {
                listBox1.Items.Add(item.GetChange());
            }
        }
    }
    class Product
    {
        public string Name;
        public int Price;
        public int Quantity;

        public string GetChange()
        {
            return $"產品名稱:{Name},價格:{Price},數量:{ Quantity}";
        }
    }




}
