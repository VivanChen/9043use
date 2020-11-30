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

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            File.WriteAllText("b.csv", "產品名稱,價格,數量,總價\r\n", Encoding.UTF8);
            MessageBox.Show( "建立完成");



        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox2.Text);
            int b = Convert.ToInt32(textBox3.Text);
            int total = a * b;

            //String outputString = textBox1.Text + "," + textBox2.Text + "," + textBox3.Text + "," + total + "\r\n";

            File.AppendAllText("b.csv", $"{textBox1.Text},{a},{b},{total}\r\n",Encoding.UTF8);
            MessageBox.Show(textBox1.Text+"輸出完成");


        }

        private void button3_Click(object sender, EventArgs e)
        {
            string name = "bob";
            int age = 30;
            string phoneNumber = "0505";

            //客戶名稱:'name',年齡:age歲,電話號碼:phoneNumber

            MessageBox.Show($"客戶名稱:'{name}',年齡:{age}歲,電話號碼:{phoneNumber}");
            
        }
    }
}
