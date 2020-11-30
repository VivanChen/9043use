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

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        //註冊按鈕
        private void button2_Click(object sender, EventArgs e)
        {
            string a = textBox1.Text+"+";
            string b = textBox2.Text;

            List<string> arry = new List<string>() {a+b};
            //arry.Add(a+b);
            
            File.AppendAllLines("longin.txt", arry);

            MessageBox.Show("註冊成功");
        }


        //登入按鈕
        private void button1_Click(object sender, EventArgs e)
        {
            List<string> arry2 = File.ReadAllLines("longin.txt").ToList();
            
            string a = textBox1.Text+"+";
            string b = textBox2.Text;

            if (arry2.Contains(a+b))
            {
                MessageBox.Show("登入成功");
                this.Close();
            }
            else
            {
                MessageBox.Show("請先註冊");
                //Application.Exit();
            }
        }
    }
}
