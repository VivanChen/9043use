using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hw
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            List<school> schoolList = schoolUtility.GetAllSchool();

            foreach (school item in schoolList)
            {
                if (item.Type == comboBox1.SelectedItem.ToString())
                {
                    listBox1.Items.Add(item.GetInfo());
                }
            }
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            List<school> schoolList = schoolUtility.GetAllSchool();

            foreach (school item in schoolList)
            {
                if (item.Address.Contains(textBox1.Text))
                {
                    listBox1.Items.Add(item.GetInfo());
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            List<school> schoolList = schoolUtility.GetAllSchool();

            foreach (school item in schoolList)
            {
                if (item.Telephone == textBox2.Text)
                {
                    listBox1.Items.Add(item.GetInfo());
                }
            }
        }
    }
}
