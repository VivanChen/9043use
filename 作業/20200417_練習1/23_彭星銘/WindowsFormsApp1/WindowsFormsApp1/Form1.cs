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
            List<Product> myList = new List<Product>();
            myList.Add(new Product() { Name = "顯示器", Price = 5000, Count = 2 });
            myList.Add(new Product() { Name = "RAM", Price = 2400, Count = 4 });
            myList.Add(new Product() { Name = "VGA", Price = 6000, Count = 1 });

            foreach (Product item in myList)
            {
                listBox1.Items.Add($"產品名稱:{item.Name}, 價格:{item.Price}, 數量:{item.Count}");
                //listBox1.Items.Add(item.GetInfo());//將方法寫在類別裡然後直接用方法顯示
            };

        }
        public class Product
        {
            public string Name;
            public int Price;
            public int Count;

            public int Total()
            {
                return Price * Count;
            }
            public string GetInfo()
            {
              return $"產品名稱:{Name}, 價格:{Price}, 數量:{Count}";
            }
        }
    }
}
