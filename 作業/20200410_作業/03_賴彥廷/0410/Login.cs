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

namespace _0410
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> AllAccount = File.ReadAllLines("Account.txt").ToList();

            string loginaccountcode = $"{textBox1.Text},{textBox2.Text}";;
            for (int i = 0; i < AllAccount.Count; i++)
            {
                if (AllAccount[i] == loginaccountcode)
                {
                    this.Close();
                    break;
                }
                else
                {
                    label3.Text = "請輸入正確的使用者帳密\r\n或按取消直接進入";
                }
            }
        }
    }
}
