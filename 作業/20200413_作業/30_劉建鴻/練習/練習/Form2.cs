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

namespace 練習
{
    public partial class Form2 : Form
    {
        static void Print(object o)
        {
            MessageBox.Show(o.ToString());
        }
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            String name = textBox1.Text;
            string password = textBox2.Text;
            Form1 ttt = new Form1();

            if(name == "admin" && password == "123")
            {
                MessageBox.Show("登入成功");
               
                this.Close();           
            }
            if (name != "admin" && password != "123")
            {
                MessageBox.Show("密碼錯誤 ");

                Application.Exit();
            }

            if (name == "")
            {
                MessageBox.Show("帳號必填不能為空白");
            }
            else if (password == "")
            {
                MessageBox.Show("密碼必填不能為空白");
                     
            }
            //ttt.Show();
           return;             
        }

    }
}



