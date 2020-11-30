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

namespace _0409
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("產品名稱不可空白");
            }
            else if (textBox2.Text == "" || Convert.ToInt32(textBox2.Text) <= 0)
            {
                MessageBox.Show("價格不可小於等於0或是空白");
            }
            else if (textBox3.Text =="" || Convert.ToInt32(textBox3.Text) <= 0)
            {
                MessageBox.Show("數量不可小於等於0或是空白");
            }
            else if (textBox2.Text =="" && textBox3.Text == "")
            {
                MessageBox.Show("價格與數量不可為空白");
            }
            else
            {
                int Price = Convert.ToInt32(textBox2.Text);
                int Quantity = Convert.ToInt32(textBox3.Text);
                int Total = Price * Quantity;
                File.WriteAllText("product.txt", $"{textBox1.Text}\r\n{textBox2.Text}, {textBox3.Text}\r\n{Total}", Encoding.UTF8);
                
            }
        }
    }
}
