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

namespace _0409作業
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static void print(object o)
        {
            MessageBox.Show(o.ToString());
        }
        private void Name_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text == "")
            {
                print("請輸入品名");
            }
            else if (textBox2.Text == "" || textBox3.Text == "")
            {
                print("數量價格不可空白");
            }
            else if (textBox2.Text == "0" || textBox3.Text == "0")

            {
                print("數量不可<=0");
            }
            else
            {
                int tatol = Convert.ToInt32(textBox2.Text) * Convert.ToInt32(textBox3.Text);
                File.AppendAllText("prod.txt",
                    $"{textBox1.Text} \r\n{textBox2.Text},{textBox3.Text}\r\n{tatol}\r\n");
            }
            




        }
    }
}
