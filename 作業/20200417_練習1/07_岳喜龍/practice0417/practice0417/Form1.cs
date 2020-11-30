using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practice0417
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
                new Product(){ ProdName = "記憶體" , ProdPrice = 1000 , ProdCount = 5, },
                new Product(){ ProdName = "顯示卡" , ProdPrice = 800 , ProdCount = 6, },
                new Product(){ ProdName = "RAM" , ProdPrice = 600 , ProdCount = 4, }
            };

            listBox1.Items.Clear();

            foreach (Product item in myList)
            {
                
                listBox1.Items.Add(item.showList());
            }
        }
    }

    class Product
    {
        public string ProdName;
        public int ProdPrice;
        public int ProdCount;

        public string showList()
        {
            return $"產品名稱:{ProdName},價格{ProdPrice},數量{ProdCount}";
        } 
    }
        

}
