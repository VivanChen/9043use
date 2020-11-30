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

        private void button2_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox4.Text);
            string str = Convert.ToString(a, 2);
            str = str.PadLeft(4, '0');
            listBox1.Items.Add(str);
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int count = 0;
            int n = Convert.ToInt32(textBox4.Text);
            string a = Convert.ToString(n, 2);
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == '1')
                {
                    count++;
                }
            }
            listBox1.Items.Add(count);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Random seed = new Random();
            int[] itemsA = new int[20000];
            int[] itemsB = new int[20000];
            for (int i = 0; i < 20000; i++)
            {
                itemsA[i] = seed.Next(10000);
                itemsB[i] = seed.Next(10000);
            }

            DateTime now = DateTime.Now;
            listBox1.Items.Add(
                GetSameValues(itemsA, itemsB).Length);



            //var sameArr2 = itemsA.Intersect(itemsB).ToArray();
            //foreach (var item in sameArr2)
            //{
            //    listBox1.Items.Add(item);
            //}

            
            
        }

        public int[] GetSameValues(int[] itemsA, int[] itemsB)
        {
            //請實作
            var sameArr2 = itemsA.Intersect(itemsB);
            return sameArr2.ToArray();
            //throw new NotImplementedException();
        }

    }



}



