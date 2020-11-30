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

namespace teacher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            List<School> schoolList = SchoolUtility.GetAllSchool();

            var query = from s in schoolList
                        where s.Type == comboBox1.SelectedItem.ToString()
                        select s;

            dataGridView1.DataSource = query.ToList();


        }

        private void button2_Click(object sender, EventArgs e)
        {


            List<School> schoolList = SchoolUtility.GetAllSchool();

            var query = from s in schoolList
                        where s.Address.Contains(textBox1.Text)
                        select s;

            dataGridView1.DataSource = query.ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            

            List<School> schoolList = SchoolUtility.GetAllSchool();

            var query = from s in schoolList
                        where s.Telephone == textBox2.Text
                        select s;

            dataGridView1.DataSource = query.ToList();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            List<School> schoolList = SchoolUtility.GetAllSchool();

            var group = from s in schoolList
                        group s by s.Address.Substring(3, 3);

            foreach (var item in group)
            {
                var query = from emp in item
                            select emp.GetInfo();

                File.WriteAllLines($"{item.Key}.csv", query.ToList(), Encoding.UTF8);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            List<School> schoolList = SchoolUtility.GetAllSchool();

            foreach (School item in schoolList)
            {
                if (item.Type == comboBox1.SelectedItem.ToString())
                {
                    listBox1.Items.Add(item.GetInfo());
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            List<School> schoolList = SchoolUtility.GetAllSchool();

            foreach (School item in schoolList)
            {
                if (item.Address.Contains(textBox1.Text))
                {
                    listBox1.Items.Add(item.GetInfo());
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            List<School> schoolList = SchoolUtility.GetAllSchool();

            foreach (School item in schoolList)
            {
                if (item.Telephone == textBox2.Text)
                {
                    listBox1.Items.Add(item.GetInfo());
                }
            }
        }
    }
}
