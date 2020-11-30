using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassPractice0414
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Product> producList = new List<Product>()
            {
                new Product(){name = "CPU", price = 50000, qua = 1 },
                new Product(){name = "RAM", price = 500, qua = 4 },
                new Product(){name = "FAM", price = 100, qua = 5 },
            };

            foreach (Product item in producList)
            {
                listBox1.Items.Add("Name :" + item.name + " Price: " + item.price + " Qua: " + item.qua);
            }
        }

    }

    public class Product
    {
        public string name;
        public double price;
        public int qua;



    }
}
