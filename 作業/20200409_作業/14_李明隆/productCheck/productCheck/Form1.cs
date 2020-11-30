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

namespace productCheck
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            string product = textBox_Product.Text.Trim();
            string price = textBox_Price.Text.Trim();
            string count = textBox_Count.Text.Trim();
            int priceInt;
            int countInt;
            int total;

            if (product == "")
            {
                MessageBox.Show("產品名稱必填且不能為空白");
            }
            else if (price == "" || count == "")
            {
                MessageBox.Show("價格與數量必填");
            }         
            else
            {            
                priceInt = int.Parse(price);
                countInt = int.Parse(count);
                
                if (priceInt <= 0 || countInt<=0)
                {
                    MessageBox.Show("價格與數量不可小於0");
                }
                else
                {
                    total = priceInt * countInt;
                    string allText = $"{product}\r\n{price},{count}\r\n{total}\r\n";
                    File.AppendAllText("prod.txt", allText, Encoding.UTF8);
                }              
            }
        }

        private void textBox_Price_TextChanged(object sender, EventArgs e)
        {
            string price = textBox_Price.Text.Trim();

            if (!IsNumber(price) && price != "")
            {

                MessageBox.Show("請輸入數字");
                textBox_Price.ResetText();
            }
        }


        private void textBox_Count_TextChanged(object sender, EventArgs e)
        {
            string count = textBox_Count.Text.Trim();

            if (!IsNumber(count) && count != "")
            {

                MessageBox.Show("請輸入數字");
                textBox_Count.ResetText();
            }
        }

        private bool IsNumber(string oText)
        {
            try
            {
                int var1 = Convert.ToInt32(oText);
                return true;
            }
            catch
            {

                return false;
            }
        }

    
    }
}
