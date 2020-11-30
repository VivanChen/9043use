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

namespace _03
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        static void print(object o)
        {
            MessageBox.Show(o.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string Acc = textBox1.Text;
            //string Pass = textBox2.Text;

            //if (Acc == "tony" && Pass == "456" || Acc == "admin" && Pass == "123")
            //{
            //    this.Close();
            //}
            //else
            //    MessageBox.Show("錯誤! 程式即將關閉!");
            //    Application.Exit();

            //Dictionary<string, string> Account = new Dictionary<string, string>()
            //{ { "tony", "456"}, { "admin", "123"} };
            //if (Account.ContainsKey(textBox1.Text) == true)//有沒有tony帳號的值, 如果為true
            //{
            //    if (Account[textBox1.Text] == textBox2.Text)//比對帳號與密碼
            //    {
            //        this.Close();
            //    }
            //    else
            //    {
            //        MessageBox.Show("密碼輸入不正確");
            //        Application.Exit();
            //    }
            // }
            //    else
            //    {
            //        MessageBox.Show("輸入錯誤");
            //        Application.Exit();
            //    }

            Dictionary<string, string> Account = new Dictionary<string, string>()
            { { "tony", "456"}, { "admin", "123"} };
            if (Account.ContainsKey(textBox1.Text) == true && Account[textBox1.Text] == textBox2.Text)
            {//若為true才會跑右邊, 這邊使用的是&&的true and false 的觀念

                this.Close();
            }
            else
            {
                MessageBox.Show("密碼或帳號輸入不正確");
                Application.Exit();
            }
            


        }
    }
}
