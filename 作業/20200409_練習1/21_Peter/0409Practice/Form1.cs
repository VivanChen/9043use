using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace _0409Practice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            File.WriteAllText("Produce.csv", "產品名稱,價格,數量,總價", Encoding.UTF8);
            MessageBox.Show("File Created~!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string txt1Text = textBox1.Text.ToString();
            double txt2Value = Convert.ToDouble(textBox2.Text);
            double txt3Value = Convert.ToDouble(textBox3.Text);
            double timesValue = txt2Value * txt3Value;

            string stringTxt2 = txt2Value.ToString();
            string stringTxt3 = txt3Value.ToString();
            string stringTimes = timesValue.ToString();

            File.AppendAllText("Produce.csv", "\r\n" + txt1Text +  ","  + stringTxt2 + "," + stringTxt3 + "," + stringTimes, Encoding.UTF8);

        }
    }
}
