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

namespace _0410
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            File.WriteAllText("product.csv","產品名稱, 價格, 數量, 總價",Encoding.UTF8);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int price, Quantity, Total;
            price = Convert.ToInt32(textBox2.Text);
            Quantity= Convert.ToInt32(textBox3.Text);
            Total = price * Quantity;
            string product = $"\r\n{textBox1.Text},{textBox2.Text},{textBox3.Text},{Total}";
            File.AppendAllText("product.csv", product, Encoding.UTF8);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            //用集合接product.csv的資料

            List<string> AllProduct = File.ReadAllLines("product.csv").ToList();
            
            //用迴圈印資料 int i=1 跳過標題(產品名稱, 價格, 數量, 總價)

            for (int i = 1; i < AllProduct.Count; i++)
            {
                listBox1.Items.Add(AllProduct[i]);
            }
            int ProductTotal = AllProduct.Count - 1;
            label4.Text = $"目前共有{ProductTotal.ToString()}個產品";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            List<string> AllProduct = File.ReadAllLines("product.csv").ToList();

            if (Convert.ToInt32(textBox4.Text) > AllProduct.Count-1)
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("超過範圍，查無產品");
            }
            else
            {
                listBox1.Items.Clear();
                for (int i = 1; i < AllProduct.Count; i++)
                {
                    if (i == Convert.ToInt32(textBox4.Text))
                    {
                        listBox1.Items.Add(AllProduct[i]);
                    }
                }
            }  
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            List<string> AllProduct = File.ReadAllLines("product.csv").ToList();


            for (int i = 1; i < AllProduct.Count; i++)
            {
                if (AllProduct[i].Contains(textBox5.Text))
                {
                    listBox1.Items.Add(AllProduct[i]);
                }

            } 
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string NewUser = $"\r\n{textBox6.Text},{textBox7.Text}";
            File.AppendAllText("Account.txt", NewUser,Encoding.UTF8);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Login door = new Login();
            door.ShowDialog();
        }
    }
}
