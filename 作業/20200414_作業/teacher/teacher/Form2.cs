using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace teacher
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //admin 123
            //tony 456
            Dictionary<string, string> myDict = new Dictionary<string, string>()
            {
                { "tony"  , "456" } ,
                { "admin" , "123" } 
            };

            //使用者輸入的 username , passwrod 
            //textBox1.Text  , textBox2.Text

            //程式內部的 username , passwrod 
            //textBox1.Text  , myDict[textBox1.Text]

            //如果帳號存在"而且"密碼正確
            if (myDict.ContainsKey(textBox1.Text) && textBox2.Text == myDict[textBox1.Text])
            {
                //成功
                this.Close();
            }
            else
            {
                //失敗
                MessageBox.Show("錯誤! 程式即將關閉!");
                Application.Exit();
            }
        }
    }
}
