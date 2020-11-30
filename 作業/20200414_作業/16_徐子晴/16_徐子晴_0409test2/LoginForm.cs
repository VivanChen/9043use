using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _16_徐子晴_0409test2
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //成功
            //this.close();
            if (textBox1.Text=="admin"&&textBox2.Text=="123")
            {
                MessageBox.Show("登入成功!!");
                this.Close();
            }
            else if (textBox1.Text == "admin")
            {
                MessageBox.Show("密碼有誤\r\n請重新輸入密碼");
            }
            else if (textBox2.Text == "123")
            {
                MessageBox.Show("帳號有誤\r\n請重新輸入帳號");
            }

            //失敗
            //Application.Exit();
            else
            {
                MessageBox.Show("登入失敗");
                Application.Exit();
            }
        }
    }
}
