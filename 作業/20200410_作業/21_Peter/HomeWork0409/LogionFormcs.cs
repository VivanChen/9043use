using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork0409
{
    public partial class LogionFormcs : Form
    {
        List<string> fileText = null;
        public LogionFormcs()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region Read File
            string fString = File.ReadAllText("帳號.txt");
            fileText = fString.Split(',').ToList();

            #endregion
            if (textBox1.Text.Trim() == "" || textBox1.Text.Length <= 0 ||
                String.IsNullOrEmpty(textBox1.Text) ||
                textBox2.Text.Trim() == "" || textBox2.Text.Length <= 0 ||
                String.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Can't Empty Please input UserName");
            }
            else if (textBox1.Text == "tony" && textBox2.Text == "456" ||
                    textBox1.Text == "admin" && textBox2.Text == "123")
            {
                MessageBox.Show("Login Success");
                this.Close();
            }
            else
            {
                Application.Exit();
            }
            

        }
    }
}
