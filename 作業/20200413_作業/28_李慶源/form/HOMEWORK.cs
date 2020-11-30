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

namespace form
{
    public partial class HOMEWORK : Form
    {
        public HOMEWORK()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ////第一種鎖死方式
            //if (textBox1.Text == "admin" && textBox2.Text == "123") 
            //{
            //    this.Close();
            //}
            //else if (textBox1.Text == "tony" && textBox2.Text == "456")
            //{
            //    this.Close();
            //}
            //else
            //{
            //    MessageBox.Show("登入失敗,程式關閉");
            //    Application.Exit();
            //}
            ////第一種的延伸
            //if ((textBox1.Text == "admin" && textBox2.Text == "123") || (textBox1.Text == "tony" && textBox2.Text == "456"))
            //{
            //    this.Close();
            //}          
            //else
            //{
            //    MessageBox.Show("登入失敗,程式關閉");
            //    Application.Exit();
            //}


            // Dictionary<string, string> soruce = new Dictionary<string, string>()
            //{{ "admin","123"},{ "tony","456"} };                    //先設定好兩組帳密利用Dictionary

            // if (soruce.ContainsKey(textBox1.Text) == true)        //利用ContainsKey確認textBox1是否有存在這個索引值
            // { 
            //     if (soruce[textBox1.Text] == textBox2.Text) //textBox1確認有這個索引值 拿這個索引值比較textBox2是否有跟索引值內的Value一樣
            //     {
            //         this.Close();
            //     }
            //     else
            //     {
            //         MessageBox.Show("密碼錯誤!");
            //         Application.Exit();
            //     }
            // }
            // else
            // {
            //     MessageBox.Show("帳號錯誤!");
            //     Application.Exit();
            // }


            //Dictionary縮減版
            Dictionary<string, string> soruce = new Dictionary<string, string>()
            {{ "admin","123"},{ "tony","456"} };

            //優先判斷左邊的運算式
            if ((soruce.ContainsKey(textBox1.Text) == true) && (soruce[textBox1.Text] == textBox2.Text))
            {

                this.Close();
            }
            else
            {
                MessageBox.Show("帳號或密碼錯誤!");
                Application.Exit();
            }

            //第三種確認帳密方式
            //List<string> soruce = File.ReadAllLines("帳號.txt").ToList();

            //foreach (string num in soruce)
            //{
            //    string[] on = num.Split(',');

            //    if (on[0] == textBox1.Text)
            //    {
            //        if (on[1] == textBox2.Text)
            //        {
            //            this.Close();
            //        }
            //    }
            //    else
            //    {
            //        MessageBox.Show("帳號或密碼錯誤!");
            //        Application.Exit();
            //    }

            //}


        }
    }
}
