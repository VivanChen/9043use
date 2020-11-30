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

namespace _20200410
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string account = (textBox1.Text);
            string password =(textBox2.Text);
            //string saccount = File.ReadAllText("帳號.txt");
            //List<string> myList = saccount.Split(',').ToList();
            //List<string> Saccount = new List<string>() { "admin,user,tony,joy,mary,lisa" };
            //List<int> Spassword = new List<int>() {123,456,789,987,654,321};
            if (account == "admin" && password == "123" ||
                account == "user" && password == "456" ||
                account == "tony" && password == "789" ||
                account == "joy" && password == "987" ||
                account == "mary" && password == "654" ||
                account == "lisa" && password == "321")
            {
                MessageBox.Show("登入成功");
                this.Close();
            }
            else if (account == "" || account.Length <= 0 || account==null
                     ||password == "" || password.Length <= 0 ||password==null)

            {
                MessageBox.Show("帳號密碼格式錯誤,請重新輸入");
            }
            else
            {
                MessageBox.Show("登入錯誤");
                this.Close();
                Environment.Exit(Environment.ExitCode);
            }
        }
        
    }
}
