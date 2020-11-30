using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        private void button3_Click(object sender, EventArgs e)
        {
            List<Product> prodList = ProductUtility.GetProducts();

            foreach (Product item in prodList)
            {
                listBox1.Items.Add(item.GetInfo());
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(comboBox1.SelectedItem);
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


    static class ProductUtility
    {
        public static List<Product> GetProducts()
        {
            List<string> strProdList = File.ReadAllLines("prod.csv").ToList();
            strProdList.RemoveAt(0);  //去除表頭

            List<Product> prodList = new List<Product>(); //準備正式的Product物件集合

            foreach (string item in strProdList) //取出每一個產品的字串 => "CPU,1000,3,3000"
            {
                List<string> tempList = item.Split(',').ToList();  //把每一個字串("CPU,1000,3,3000") 拆成集合 
                //tempList[0] => 名稱
                //tempList[1] => 價格
                //tempList[2] => 數量

                //把拆出來的字串集合成員，透過類別物件初始設定式來建立Product物件實體,並且放到物件集合
                prodList.Add(
                    new Product() {
                        Name = tempList[0] ,
                        Price = Convert.ToInt32(tempList[1]),
                        Count = Convert.ToInt32(tempList[2])
                    });  
            }

            return prodList;

            //List<Employee> myList = new List<Employee>() {
            //    new Employee( 1, "tony",  1000 ),
            //    new Employee( 2, "mary",  1100 )
            //};

            //return myList;
        }
    }
}
