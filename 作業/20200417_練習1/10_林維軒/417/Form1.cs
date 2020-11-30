using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _417
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<product> NewProd = new List<product>(){ //新集合
                new product {Name = "USB", price = 1000, Count = 20},
                new product {Name = "Keyboard", price = 600, Count = 30 },
                new product {Name = "SSD", price = 3000, Count = 25 } 
            };
            

            foreach (product item in NewProd) //印出
            {
                //listBox1.Items.Add($"產品名稱:{item.Name}, 價格:{item.price} , 數量:{item.Count}");
                listBox1.Items.Add(item.Getinfo());
            }
        }

    }
    class product
    {
        public string Name;
        public int price;
        public int Count;

        public string Getinfo()
        {
            return $"產品名稱:{Name}, 價格:{price} , 數量:{Count}";
        }
        
    }
}
