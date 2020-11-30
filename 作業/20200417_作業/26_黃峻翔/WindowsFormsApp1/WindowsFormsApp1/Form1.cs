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

namespace WindowsFormsApp1
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
            List<School> schoolList = SchoolUtility.GetSchools();

            foreach (School item in schoolList)
            {
                if (item.Type==comboBox1.SelectedItem.ToString())
                {
                    listBox1.Items.Add(item.GetInfo());
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            List<School> schoolList = SchoolUtility.GetSchools();

            foreach (School item in schoolList)
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
            List<School> schoolList = SchoolUtility.GetSchools();

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
        public string Type;
        public string SchoolName;
        public string PostalCode;
        public string Address;
        public string Telephone;
        public string Lat;
        public string Lon;

        public string GetInfo()
        {
            return $"{Type},{SchoolName},{PostalCode},{Address},{Telephone},{Lat},{Lon}";
        }

    }

    public static class SchoolUtility
    {
        public static List<School> GetSchools()
        {
            List<string> strSchoolList = File.ReadAllLines("臺北市各級學校分布圖.csv").ToList();
            strSchoolList.RemoveAt(0);  //去除表頭

            List<School> SchoolList = new List<School>(); //準備正式的Product物件集合

            foreach (string item in strSchoolList) 
            {
                List<string> tempList = item.Split(',').ToList();   
                

                //把拆出來的字串集合成員，透過類別物件初始設定式來建立Product物件實體,並且放到物件集合
                SchoolList.Add(
                    new School()
                    {
                        Type = tempList[0],
                        SchoolName =tempList[1],
                        PostalCode = tempList[2],
                        Address = tempList[3],
                        Telephone= tempList[4],
                        Lat= tempList[5],
                        Lon= tempList[6]
                    });
            }

            return SchoolList;

        }
    }




}
