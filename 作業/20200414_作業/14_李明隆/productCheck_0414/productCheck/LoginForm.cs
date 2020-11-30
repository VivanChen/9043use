﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginHomeWork
{
    public partial class LoginForm : Form
    {
        int count = 3;
        bool close = true;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void button_Confirm_Click(object sender, EventArgs e)
        {
            string user = textBox_User.Text.Trim();
            string password = textBox_Password.Text.Trim();



            if (user == "")
            {
                MessageBox.Show("帳號必填且不能為空白");
            }
            else if (password == "")
            {
                MessageBox.Show("密碼必填且不能為空白");
            }
            else
            {
                List<string> userAccount = File.ReadAllLines("帳號.txt").ToList();
                Dictionary<string, string> accountDict = new Dictionary<string, string>();

                for (int i = 0; i < userAccount.Count; i++)
                {
                    string[] accountSplit = userAccount[i].Split(',');
                    //string strAccount = accountSplit[0];
                    //string strPassword = accountSplit[1];

                    //加入帳號密碼到Dictionary
                    accountDict.Add(accountSplit[0], accountSplit[1]);
                }


                if (accountDict.ContainsKey(user))
                {
                    if (accountDict[user] == password)
                    {
                        MessageBox.Show("登入成功");
                        this.Close();
                    }
                    else if (count == 1)
                    {
                        MessageBox.Show("密碼錯誤過多，程式即裝關閉！");
                        Application.Exit();
                    }
                    else
                    {
                        count--;
                        MessageBox.Show("密碼錯誤，請重新輸入，剩下" + count + "次機會");
                    }
                }
                else
                {
                    MessageBox.Show("帳號不存在，請重新輸入");
                }



                //for (int i = 0; i < userAccount.Count; i++)
                //{
                //    string[] account = userAccount[i].Split(',');

                //    if (account[0] == user)
                //    {
                //        if (account[1] == password)
                //        {
                //            MessageBox.Show("登入成功");
                //            close = false;
                //            this.Close();
                //            break;
                //        }
                //        else
                //        {
                //            MessageBox.Show("密碼錯誤，程式即將關閉");
                //            //Application.Exit();
                //            Environment.Exit(Environment.ExitCode);
                //            break;
                //        }
                //    }
                //    else
                //    {
                //        MessageBox.Show("帳號錯誤，程式即將關閉");
                //        Environment.Exit(Environment.ExitCode);
                //        break;
                //    }
                //}
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

            this.Location = new Point(700, 400);
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (close != false)
            //    e.Cancel = true;
        }
    }
}
