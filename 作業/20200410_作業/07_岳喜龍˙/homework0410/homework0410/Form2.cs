using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homework0410
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "tony" && textBox2.Text == "456")
            {
                this.Close();
            }
            else if (textBox1.Text == "admin" && textBox2.Text == "123")
            {
                this.Close();
            }
            else
            {
                Application.Exit();
            }
            
        }
    }
}
