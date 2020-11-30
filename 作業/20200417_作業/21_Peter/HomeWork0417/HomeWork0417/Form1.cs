using System;
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

namespace HomeWork0417
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<School> schoolList = SchoolUtily.GetSchool();

            foreach (School item in schoolList)
            {
                if (item.Classification.Contains(comboBox1.Text))
                {
                    listBox1.Items.Add(item.GetInfo());

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<School> schoolList = SchoolUntility.GetSchool();
            listBox1.DataSource = null;
            listBox1.Items.Clear();//清空list

            string a = textBox1.Text;

            //schoolList每個值放進item
            foreach (School item in schoolList)
            {
                string region = item.Address.Substring(3, 3);

                if (a == region)
                {
                    listBox1.Items.Add(item.GetInfo());
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<School> schoolList = SchoolUtily.GetSchool();
            listBox1.DataSource = null;
            listBox1.Items.Clear();//清空list

            //schoolList每個值放進item
            foreach (School item in schoolList)
            {
                if (item.Telephone == textBox2.Text)
                {
                    listBox1.Items.Add(item.GetInfo());
                }

            }
        }
    }

    public class School
    {
        public string Classification;
        public string SchoolName;
        public int PostalCode;
        public string Address;
        public string Telephone;
        public string LatLon;

        public string GetInfo()
        {
            return $"{Classification},{SchoolName},{PostalCode},{Address}, {Telephone},{LatLon}";

        }
    }

    public static class SchoolUtily
    {
        public static List<School> GetSchool()
        {
            List<string> strSchoolList = File.ReadAllLines("1080416臺北市各級學校分布圖.csv").ToList();//讀csv檔
            strSchoolList.RemoveAt(0);


            List<School> schoolList = new List<School>();

            foreach (string item in strSchoolList)
            {
                List<string> tempList = item.Split(',').ToList();

                schoolList.Add(new School
                {
                    Classification = tempList[0],
                    SchoolName = tempList[1],
                    PostalCode = Convert.ToInt32(tempList[2]),
                    Address = tempList[3],
                    Telephone = tempList[4],
                    LatLon = tempList[5],

                });
            }

            return schoolList;
        }
    }
}
