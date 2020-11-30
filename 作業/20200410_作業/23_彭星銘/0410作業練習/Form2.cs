using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0410作業練習
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" && textBox2.Text == "123")
            {
                MessageBox.Show("登入成功," + textBox1.Text);
                this.Close();
            }
            else if (textBox1.Text == "tony" && textBox2.Text == "456")
            {
                MessageBox.Show("登入成功," + textBox1.Text);
                this.Close();
            }
            else if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("帳號或密碼不允許空白");
            }
            else
            {
                this.Close();
            }
        }
    }
}
