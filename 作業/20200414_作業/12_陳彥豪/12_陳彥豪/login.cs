using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12_陳彥豪
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        static void Print(object o)
        {
            MessageBox.Show(o.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "tony" && textBox2.Text == "456") || (textBox1.Text == "admin" && textBox2.Text == "123"))
            {
                //成功
                Print("登入成功");

               
                //this.Close();
              
            }
            else
            //失敗
            {
                Print("帳密錯誤");
                Application.Exit();
            }
                
              
            
            
              
            
        }
    }
}
