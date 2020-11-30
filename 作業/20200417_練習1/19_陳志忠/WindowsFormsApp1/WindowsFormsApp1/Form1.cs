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
            List<Product> list1 = new List<Product>();
            list1.Add(new Product {a=textBox1.Text,b=Convert.ToInt32(textBox2.Text),c=Convert.ToInt32(textBox3.Text) });

            foreach (Product item in list1)
            {
                listBox1.Items.Add($"產品名稱: {item.a},價格: {item.b},數量: {item.c}");
            }
        }
      class Product
     {
        public string a;
        public int b;
        public int c;
     }

}

    


}
