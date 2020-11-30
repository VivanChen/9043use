using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homework0417
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {           

            List<school> schoolList = SchoolUtility.GetSchools();
            listBox1.Items.Clear();
            foreach (school item in schoolList)
            {
                if (comboBox1.Text == item.AllSchool)
                {
                    listBox1.Items.Add(item.GetInfo());
                }                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {            
            List<school> schoolList = SchoolUtility.GetSchools();
            listBox1.Items.Clear();
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
            List<school> schoolList = SchoolUtility.GetSchools();
            listBox1.Items.Clear();
            foreach (school item in schoolList)
            {
                if (item.Telephone == textBox2.Text)
                {
                    listBox1.Items.Add(item.GetInfo());
                }
            }
        }
    }
    class school //類別
    {
        public string AllSchool;
        public string SchoolName;
        public string PostalCode;
        public string Address;
        public string Telephone;
        public string Lat;
        public string Ion;
        public string GetInfo()
        {            
            return $"{AllSchool},{SchoolName},{PostalCode},{Address},{Telephone},{Lat},{Ion}";
        }
    }
    static class SchoolUtility
    {
        public static List<school> GetSchools()
        {
            List<string> strSchoolList = File.ReadAllLines("1080416臺北市各級學校分布圖.csv").ToList();
            strSchoolList.RemoveAt(0);            

            List<school> schoolList = new List<school>();
            foreach (string item in strSchoolList)
            {
                List<string> tempList = item.Split(',').ToList();
                schoolList.Add(new school()
                {
                    AllSchool = tempList[0],
                    SchoolName = tempList[1],
                    PostalCode = tempList[2],
                    Address = tempList[3],
                    Telephone = tempList[4],
                    Lat = tempList[5],
                    Ion = tempList[6]
                });
            }
            return schoolList;
        }
    }
}
    
