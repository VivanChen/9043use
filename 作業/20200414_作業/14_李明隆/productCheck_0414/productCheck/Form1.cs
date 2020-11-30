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
using System.Data.SqlClient;
namespace productCheck
{
    public partial class Form1 : Form
    {
        List<string> product = new List<string>();
        int productTotal;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //LoginHomeWork.LoginForm loginForm = new LoginHomeWork.LoginForm();
            //loginForm.ShowDialog();

            //檔案不存在時，新建檔案
            if (!File.Exists("prod.csv"))
            {
                File.AppendAllText("prod.csv", "產品名稱,價格,數量,總價\r\n", Encoding.UTF8);
            }
            else
            {
                RefreshProduct();
            }

        }

        #region 方法
        //判斷是否為數字
        private void IsNumber(TextBox s)
        {
            string text = s.Text;

            try
            {
                int var = int.Parse(text);
            }
            catch
            {
                if (text != "")
                {
                    MessageBox.Show("請輸入數字");
                    s.ResetText();
                }

            }
        }

        //判斷輸入產品名稱的關鍵字是否存在
        public Product Findkey(int i, string key)
        {
            string[] strTmp = product[i].Split(',');
            string productName = strTmp[0];
            string price = strTmp[1];
            string count = strTmp[2];


            List<Product> productList = new List<Product>()
            {
                new  Product(){ProductName = productName,Price = price,Count = count }
            };

            var result = productList.Find(c => c.ProductName.Contains(key));

            return result;
        }

        //刷新物件product的內容
        public void RefreshProduct()
        {
            product = File.ReadAllLines("prod.csv").ToList();
            product.RemoveAt(0);
            productTotal = product.Count;
        }
        //檢查product的內容是否已存在產品名稱
        public bool productExist(string name)
        {
            foreach (string item in product)
            {
                string[] productName = item.Split(',');
                if (name.Equals(productName[0], StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }
            return false;
        }
        //新增刪除的方法
        public void CheckTextBox(TextBox productName, TextBox productPrice, TextBox productCount, string mode)
        {
            string Name = productName.Text.Trim();
            string price = productPrice.Text.Trim();
            string count = productCount.Text.Trim();

            int priceInt;
            int countInt;
            int total;
            bool edit = false;

            if (Name == "")
            {
                MessageBox.Show("產品名稱必填且不能為空白");
            }
            else if (productExist(Name) && mode=="SAVE")
            {
                MessageBox.Show("產品名稱已存在，請輸入新的產品名稱！");
            }
            else if (price == "" || count == "")
            {
                MessageBox.Show("價格與數量必填");
            }
            else
            {
                priceInt = int.Parse(price);
                countInt = int.Parse(count);

                if (priceInt <= 0 || countInt <= 0)
                {
                    MessageBox.Show("價格與數量不可小於0");
                }
                else
                {
                    if (mode == "SAVE")
                    {
                        total = priceInt * countInt;
                        string allText = $"{Name},{price},{count},{total}\r\n";
                        File.AppendAllText("prod.csv", allText, Encoding.UTF8);
                        MessageBox.Show(Name + "輸出完成！");
                    }
                    else
                    {
                        for (int i = 0; i < product.Count; i++)
                        {
                            string[] productList = product[i].Split(',');

                            if (productList[0].Equals(Name, StringComparison.OrdinalIgnoreCase))
                            {
                                total = priceInt * countInt;
                                string newStr = $"{Name},{price},{count},{total}";

                                product[i] = newStr;

                                edit = true;
                            }
                        }
                        if (edit == true)
                        {
                            File.Delete("prod.csv");
                            File.WriteAllText("prod.csv", "產品名稱,價格,數量,總價\r\n", Encoding.UTF8);

                            for (int i = 0; i < product.Count; i++)
                            {
                                File.AppendAllText("prod.csv", product[i] + "\r\n", Encoding.UTF8);
                            }
                            MessageBox.Show("修改完成！");
                        }
                        else
                        {
                            MessageBox.Show("查無此產品");
                        }
                    }
                    productName.ResetText();
                    productPrice.ResetText();
                    productCount.ResetText();
                    listBox_Show.Items.Clear();
                    RefreshProduct();
                }
            }

        }

        #endregion


        #region TextBox 事件

        private void textBox_Price_TextChanged(object sender, EventArgs e)
        {

            IsNumber(textBox_Price);
        }

        private void textBox_Count_TextChanged(object sender, EventArgs e)
        {

            IsNumber(textBox_Count);
        }

        private void textBox_SearchCount_TextChanged(object sender, EventArgs e)
        {

            IsNumber(textBox_SearchCount);
        }

        private void textBox_PriceSearch_TextChanged(object sender, EventArgs e)
        {
            IsNumber(textBox_PriceSearch);
        }

        private void textBox_EditPrice_TextChanged(object sender, EventArgs e)
        {
            IsNumber(textBox_EditPrice);
        }

        private void textBox_EditCount_TextChanged(object sender, EventArgs e)
        {
            IsNumber(textBox_EditCount);
        }

        #endregion

        #region Button 事件

        private void button_ListboxClear_Click(object sender, EventArgs e)
        {
            listBox_Show.Items.Clear();
        }

        private void button_ProductName_Click(object sender, EventArgs e)
        {
            listBox_Show.Items.Clear();
            string productName = textBox_ProductName.Text;
            //string[] name = new string[product.Count];
            bool found = false;

            foreach (string item in product)
            {
                List<string> tmpList = item.Split(',').ToList();
                if (tmpList[0] == productName)
                {
                    listBox_Show.Items.Add(item);
                    found = true;
                }
            }
            if (found == false)
            {
                MessageBox.Show("查無此產品");
            }

            //for (int i = 0; i < product.Count; i++)
            //{
            //    if (product[i].Contains(productName))
            //    {
            //        string[] nameSplit = product[i].Split(',');
            //        listBox_Show.Items.Add(nameSplit[0]);
            //        found = true;
            //    }
            //}
            //if (found == false)
            //{
            //    MessageBox.Show("查無此產品");
            //}


            //for (int i = 0; i < product.Count; i++)
            //{
            //    string[] tmp = product[i].Split(',');
            //    name[i] = tmp[0];
            //}

            //for (int i = 0; i < name.Length; i++)
            //{
            //    if (productName == name[i])
            //    {
            //        index = i;
            //        listBox_Show.Items.Add(product[index]);
            //    }
            //}

            //if (index == -1)
            //{
            //    MessageBox.Show("查無此產品");
            //}

            textBox_ProductName.ResetText();
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            TextBox product = textBox_Product;
            TextBox price = textBox_Price;
            TextBox count = textBox_Count;
            string mode = "SAVE";
            CheckTextBox(product, price, count, mode);
        }

        private void button_AllProduct_Click(object sender, EventArgs e)
        {

            listBox_Show.Items.Clear();

            for (int i = 0; i < product.Count; i++)
            {
                listBox_Show.Items.Add(product[i]);
            }

        }

        private void button_SearchCount_Click(object sender, EventArgs e)
        {
            if (textBox_SearchCount.Text != "")
            {
                listBox_Show.Items.Clear();

                int searchCount = int.Parse(textBox_SearchCount.Text.Trim());

                string index = textBox_SearchCount.Text.Trim();

                if (searchCount > productTotal)
                {
                    MessageBox.Show("查無此產品！資料總數為:" + productTotal + "\r\n請輸入範圍內數字！");
                    textBox_SearchCount.ResetText();
                }
                else
                {
                    listBox_Show.Items.Add(product[searchCount - 1]);
                    textBox_SearchCount.ResetText();
                }
            }
            else
            {
                MessageBox.Show("請輸入資料");
            }

        }

        private void button__SearchKey_Click(object sender, EventArgs e)
        {
            listBox_Show.Items.Clear();

            string key = textBox_SearchKey.Text.ToUpper();
            bool notFound = true;

            if (textBox_SearchKey.Text != "")
            {
                foreach (string item in product)
                {
                    if (item.ToUpper().Contains(key))
                    {
                        listBox_Show.Items.Add(item.ToString());
                        textBox_SearchKey.ResetText();
                        notFound = false;
                    }
                }
            }
            else
            {
                MessageBox.Show("請輸入資料");
            }

            if (notFound == true)
            {
                MessageBox.Show("查無此產品");
                textBox_SearchKey.ResetText();
            }




            //if (textBox_SearchKey.Text != "")
            //{
            //    for (int i = 0; i < product.Count; i++)
            //    {
            //        if (product[i].Contains(key))
            //        {
            //            listBox_Show.Items.Add(product[i]);
            //        }
            //    }
            //    if (notFound == true)
            //    {
            //        MessageBox.Show("查無此產品");
            //        textBox_SearchKey.ResetText();
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("請輸入資料");
            //}

            //if (textBox_SearchKey.Text != "")
            //{
            //    listBox_Show.Items.Clear();

            //    string key = textBox_SearchKey.Text;
            //    bool notFound = true;

            //    for (int i = 0; i < product.Count; i++)
            //    {
            //        if (Findkey(i, key) != null)
            //        {
            //            listBox_Show.Items.Add(product[i]);
            //            textBox_SearchKey.ResetText();
            //            notFound = false;
            //        }
            //    }
            //    if (notFound == true)
            //    {
            //        MessageBox.Show("查無此產品");
            //        textBox_SearchKey.ResetText();
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("請輸入資料");
            //}
        }

        private void button_PriceSearch_Click(object sender, EventArgs e)
        {
            listBox_Show.Items.Clear();
            string priceText = textBox_PriceSearch.Text.Trim();
            bool notFound = true;

            if (priceText != "")
            {
                foreach (string item in product)
                {
                    List<string> priceList = item.Split(',').ToList();

                    int priceSearchInt = int.Parse(priceText);
                    int priceInt = int.Parse(priceList[1]);

                    if (priceInt >= priceSearchInt)
                    {
                        listBox_Show.Items.Add(item);
                        textBox_PriceSearch.ResetText();
                        notFound = false;
                    }
                }
                if (notFound == true)
                {
                    MessageBox.Show("查無此產品");
                    textBox_PriceSearch.ResetText();
                }
            }
            else
            {
                MessageBox.Show("請輸入資料");
            }
        }

        private void button_PrintAllPrice_Click(object sender, EventArgs e)
        {
            foreach (string item in product)
            {
                List<string> productList = item.Split(',').ToList();

                string name = productList[0];

                string price = productList[1];

                string str = $"名稱:{name}，價格：{price}元";

                listBox_Show.Items.Add(str);
            }

        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            string productName = textBox_DeleteProductName.Text.Trim();
            List<string> newProductList = new List<string>();
            bool found = false;

            if (productName != "")
            {             
                foreach (string item in product)
                {
                    string[] productList = item.Split(',');
                    if (productList[0].Equals(productName, StringComparison.OrdinalIgnoreCase))
                    {
                        int index = product.IndexOf(item);
                        product.RemoveAt(index);
                        found = true;
                        break;
                    }
                }

                if (found == true)
                {
                    File.WriteAllText("prod.csv", "產品名稱,價格,數量,總價\r\n", Encoding.UTF8);
                    File.AppendAllLines("prod.csv", product, Encoding.UTF8);
                    MessageBox.Show("產品：" + productName + "成功刪除！");
                    textBox_DeleteProductName.ResetText();
                    listBox_Show.Items.Clear();
                    RefreshProduct();
                }
                else
                {
                    MessageBox.Show("查無資料！");
                    listBox_Show.Items.Clear();
                    textBox_DeleteProductName.ResetText();
                }
            }
            else
            {
                MessageBox.Show("請輸入資料");
            }
        }

        private void button_Edit_Click(object sender, EventArgs e)
        {
            TextBox productText = textBox_EditProductName;
            TextBox price = textBox_EditPrice;
            TextBox count = textBox_EditCount;
            string mode = "edit";
            CheckTextBox(productText, price, count, mode);
        }

        #endregion
    }

    public class Product
    {
        public string ProductName { get; set; }
        public string Price { get; set; }
        public string Count { get; set; }
    }
}
