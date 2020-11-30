using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _16_徐子晴_0413test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 5; i < 101; i+=5)
            {
                listBox1.Items.Add(i);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //清空listBox1, 先將ListBox用成空集合 , 再CLEAR
            listBox1.DataSource = null;
            listBox1.Items.Clear();

            int InputText1 = Convert.ToInt32(textBox1.Text);

            for (int i = InputText1; i < 101; i+=InputText1 )
            {
                listBox1.Items.Add(i);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //清空listBox1, 先將ListBox用成空集合 , 再CLEAR
            listBox1.DataSource = null;
            listBox1.Items.Clear();

            int InputText2 = Convert.ToInt32(textBox2.Text);
            int InputText3 = Convert.ToInt32(textBox3.Text);

            for (int i = InputText2; i < InputText3; i += 5)
            {
                listBox1.Items.Add(i);
            }
        }
    }
}
