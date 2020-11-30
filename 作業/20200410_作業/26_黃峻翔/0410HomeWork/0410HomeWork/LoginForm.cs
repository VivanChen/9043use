using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0410HomeWork
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Name = textBox1.Text;
            string PassWord = textBox2.Text;

            if (Name=="翔"&&PassWord=="1209")
            {
                MessageBox.Show("登入成功");
                this.Close();
            }
            else
            {
                MessageBox.Show("帳號密碼錯誤,請重試");
                textBox1.Clear();
                textBox2.Clear();
            }
        }
    }
}
