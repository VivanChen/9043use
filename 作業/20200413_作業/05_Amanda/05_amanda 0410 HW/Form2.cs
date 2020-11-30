using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05_amanda_0410_HW
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //   if (textBox1.Text == "amanda" && textBox2.Text == "1234") ;
            //   {
            //       this.Close();
            //   }

            //   else if (textBox1.Text == "marco" && textBox2.Text == "5678") ;
            //   {
            //       this.Close();
            //   }

            //   else
            //{
            //       MessageBox.Show("88");
            //       Application.Exit();
            //   }

            //if ((textBox1.Text == "tony" && textBox2.Text == "456") || (textBox1.Text == "mary" && textBox2.Text == "123"))
            //{
            //    this.Close();
            //}
            //else
            //{
            //    MessageBox.Show("88");
            //    Application.Exit();

            //2
            Dictionary<string, string> myDict = new Dictionary<string, string>() { { "amanda", "1234 "}, { "marco", "5678" } };//後面給值

            if (myDict.ContainsKey(textBox1.Text)==true)//如果帳號是對的話 有{ "amanda", "1234 "}, { "marco", "5678" }

            {
                if (myDict[textBox1.Text] == textBox2.Text) //如果密碼對的話
                {
                    this.Close();
                }
                else                                       //如果密碼錯的話
                {
                    MessageBox.Show("密碼不正確");
                    Application.Exit();
                }
            }

            else                                        //如果帳號是錯的話
            {
                MessageBox.Show("帳號不存在");
                Application.Exit();
            }
            //3.
            //優先評估左邊運算元
            if (myDict.ContainsKey(textBox1.Text) == true && myDict[textBox1.Text] == textBox2.Text)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("帳號或密碼不正確");
                Application.Exit();
            }
        }
        
    }
}
