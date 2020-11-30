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
using System.Collections;

namespace 練習
{
   
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            File.WriteAllText("product.txt", "\r\n", Encoding.UTF8);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int Price = Convert.ToInt32(textBox2.Text);
            int Count = Convert.ToInt32(textBox3.Text);
            int Total = Price * Count;

            String outputString = textBox1.Text + "," + textBox2.Text + "," + textBox3.Text;

            File.AppendAllText("product.txt", outputString + "," + Convert.ToString(Total) + "\r\n");

            MessageBox.Show(textBox1.Text + "恭喜完成");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.ShowDialog();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            List<string> mylist = File.ReadAllLines("product.txt").ToList();

            listBox1.DataSource = mylist;
            //全部產品
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            
            listBox1.Items.Clear();
            //清除
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            //查詢資料
            listBox1.Items.Clear();

            List<string> Product= File.ReadAllLines("product.txt").ToList();
            int name = Convert.ToInt32(textBox4.Text);

            listBox1.Items.Add(Product[name]);
   
        }

        private void Button5_Click(object sender, EventArgs e)
        {    
            listBox1.Items.Clear();

            List<string> Product
             = File.ReadAllLines("product.txt").ToList();

            
            for (int i = 0; i < Product.Count; i++)
            {
                if (Product[i].Contains(textBox5.Text))
                {
                    listBox1.Items.Add(Product[i]);
                }
                        
            }
            
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
           
            List<string> product = File.ReadAllLines("product.txt").ToList();
            

            foreach (string Name in product)

            {
                string[] str = Name.Split(',');      
                if (str[0] == textBox6.Text)
                {
                    listBox1.Items.Add($"{str[0]},{str[1]}.{str[2]}");

                }
               
            }
            

        }

        private void TextBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
