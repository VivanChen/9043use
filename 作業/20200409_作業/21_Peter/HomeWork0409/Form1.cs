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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string txtBox1 = textBox1.Text;
            double txtBox2 = Convert.ToDouble(textBox2.Text);
            double txtBox3 = Convert.ToDouble(textBox3.Text);

            bool firstState = false;
            bool secondState = false;

            //string txtTrim = txtBox1.TrimStart();
            //int txtLength = txtTrim.Length;

            if (txtBox1.Length > 0  || String.IsNullOrEmpty(txtBox1))
            {
                MessageBox.Show("Can't Empty");
            }
            else
            {
                firstState = true;
            }
            if (txtBox2 > 0 && txtBox3 > 0)
            {
                secondState = true;
            }
            else
            {
                MessageBox.Show("Can't less 0");
            }

            if (firstState == true && secondState == true)
            {
                string outResult = txtBox1 + "," + "\r\n" + txtBox2.ToString()  + "," + "\r\n" + txtBox3.ToString();
                File.AppendAllText("Product.txt", outResult, Encoding.UTF8);
            }

            
        }
    }
}
