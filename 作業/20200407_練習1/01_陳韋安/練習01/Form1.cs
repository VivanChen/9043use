using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 練習01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Numble1 = Convert.ToInt32(textBox1.Text);
            int Numble2 = Convert.ToInt32(textBox2.Text);
            int Total = Numble1 * Numble2;
            label1.Text = Total.ToString();

        }
    }
}
