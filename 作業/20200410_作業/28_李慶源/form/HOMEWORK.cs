using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            if (textBox1.Text == "admin" && textBox2.Text == "123") 
            {
                this.Close();
            }
            else if (textBox1.Text == "tony" && textBox2.Text == "456")
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("登入失敗,程式關閉");
                Application.Exit();
            }
        }
    }
}
