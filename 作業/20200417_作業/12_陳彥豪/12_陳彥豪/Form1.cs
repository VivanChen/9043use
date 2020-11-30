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

namespace _12_陳彥豪
{
    //school,school_name,postal_code,address,telephone,lat,lon
    public partial class Form1 : Form
    {
        List<string> GetAllList()
        {
            List<string> allList = File.ReadAllLines("1080416臺北市各級學校分布圖.csv").ToList();
            string.Join(",", allList[0]);
            allList.RemoveAt(0);
            return allList;
        }

         class School  //建立類別 School
        {
            public string school;
            public string school_name;
            public string postal_code;
            public string address;
            public string telephone;
            public string lat;
            public string lon;


            public string GetInfo()  //列出整串字
            {
                return $"{school},{school_name},{postal_code},{address},{telephone},{lat},{lon}";
            }
            
        }

        static class SchoolUtility
        {
            public static List<School> GetSchools()
            {
                List<string> strSchoolList = File.ReadAllLines("1080416臺北市各級學校分布圖.csv").ToList();
                strSchoolList.RemoveAt(0);
                string.Join(",", strSchoolList[0]);
                List<School> schoolList = new List<School>();
                foreach (string item in strSchoolList)
                {
                    List<string> tempList = item.Split(',').ToList<string>();

                    schoolList.Add(new School()
                    {
                        school = tempList[0],
                        school_name = tempList[1],
                        postal_code = tempList[2],
                        address = tempList[3],
                        telephone = tempList[4],
                        lat = tempList[5],
                        lon = tempList[6]
                    });
                   
                }
                return schoolList;
            }

        }


        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            listBox1.Items.Clear();
            School school = new School();
            List<School> sList = SchoolUtility.GetSchools();
            foreach (School item in sList)
            {
                if(item.address.Contains(textBox1.Text))
                {
                    listBox1.Items.Add(item.GetInfo());
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            listBox1.Items.Clear();
            School school = new School();
            List<School> sList = SchoolUtility.GetSchools();
            foreach (School item in sList)
            {

                if (item.school == Convert.ToString(comboBox1.SelectedItem))
                {
                    
                    listBox1.Items.Add(item.GetInfo());

                }
                
            }
            if (Convert.ToString(comboBox1.SelectedItem) == string.Empty)
            {
                MessageBox.Show("查無資料");
            }
        }


        private void button5_Click(object sender, EventArgs e)
        {
            List<string> sList = GetAllList();   //宣告 sList 裝集合
            listBox1.DataSource = sList;     //資料繫結  列出所有資料
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            listBox1.Items.Clear();
            School school = new School();
            List<School> sList = SchoolUtility.GetSchools();
            foreach (School item in sList)
            {

                if (item.telephone == textBox2.Text)
                {

                    listBox1.Items.Add(item.GetInfo());

                }

            }
            if (textBox2.Text == string.Empty)
            {
                MessageBox.Show("請輸入完整電話號碼");
            }
        }

        private void button4_Click(object sender, EventArgs e)  //輸出各地區資料
        {
            School school = new School();
            List<School> sList = SchoolUtility.GetSchools();
            List<string> tmpList = new List<string>().ToList();
            foreach (School item in sList)
            {
                if (item.address.Contains("內湖"))
                {
                    tmpList.Add($"{item.school},{item.school_name},{item.postal_code},{item.address},{item.telephone},{item.lat},{item.lon}");

                }
            }
         File.AppendAllLines("內湖區.csv",tmpList, Encoding.UTF8);
        }                   
    }
}
