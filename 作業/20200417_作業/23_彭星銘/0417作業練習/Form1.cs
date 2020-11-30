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

namespace _0417作業練習
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
            List<School> SchoolList = SchoolUtility.GetList();
            
            foreach (School item in SchoolList)
            {
                if (item.school==comboBox1.Text)
                {
                    listBox1.Items.Add(item.GetInfo());
                }
                
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            List<School> SchoolList = SchoolUtility.GetList();

            foreach (School item in SchoolList)
            {
                if (item.address.Contains(textBox1.Text)==true)
                {
                    listBox1.Items.Add(item.GetInfo());
                }

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            List<School> SchoolList = SchoolUtility.GetList();

            foreach (School item in SchoolList)
            {
                if (item.telephone.Contains(textBox1.Text) == true)
                {
                    listBox1.Items.Add(item.GetInfo());
                }

            }
        }
    }
    class School
    {
        public string school;
        public string school_name;
        public string postal_code;
        public string address;
        public string telephone;
        public string lat;
        public string lon;

        public string GetInfo()
        {
            return $"{school},{school_name},{postal_code},{address},{telephone},{lat},{lon},";
        }
    }

    static class SchoolUtility
    {
        public static List<School> GetList()
        {
            List<string> schoolList = File.ReadAllLines("1080416臺北市各級學校分布圖.csv").ToList();
            schoolList.RemoveAt(0);
            List<School> sList = new List<School>();
            foreach (string item in schoolList)
            {
                List<string> tempList = item.Split(',').ToList();
                sList.Add(
                          new School()
                               {
                                   school = tempList[0],
                                   school_name = tempList[1],
                                   postal_code = tempList[2],
                                   address = tempList[3],
                                   telephone = tempList[4],
                                   lat = tempList[5],
                                   lon = tempList[6],
                               }
                           );
            }
            return sList;
        }

        
    }
}
