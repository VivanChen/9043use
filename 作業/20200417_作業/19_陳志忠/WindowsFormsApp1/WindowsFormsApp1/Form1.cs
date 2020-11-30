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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        //第一個按鈕依級別查詢
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            List<SchoolsLevels> data1 = SchoolData.RedData();

            foreach (SchoolsLevels item in data1)
            {
                if (item.Levels.Contains(comboBox1.SelectedItem.ToString()))
                {
                    listBox1.Items.Add(item.StringOut());
                }
                //listBox1.Items.Add($"{item.Levels}{item.SchoolName}{item.PostalCode}{item.Address}{item.Telephone}{item.Lat}{item.Lon}");
            }
        }

        //第二個按鈕依行政區查詢
        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            string AdministrativeDistrict = textBox1.Text;

            List<SchoolsLevels> data2 = SchoolData.RedData();

            foreach (SchoolsLevels item in data2)
            {
                if (item.Address.Contains(AdministrativeDistrict))
                {
                    listBox1.Items.Add(item.StringOut());
                }
            }
        }

        //第三個按鈕依電畫查詢
        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            string numbr = textBox2.Text;

            List<SchoolsLevels> data3 = SchoolData.RedData();

            foreach (SchoolsLevels item in data3)
            {
                if (item.Telephone.Contains(numbr))
                {
                    listBox1.Items.Add(item.StringOut());
                }
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            List<SchoolsLevels> data4 = SchoolData.RedData();

            List<string> saveList1 = new List<string>();

            List<string> saveList2 = new List<string>();

            List<string> saveList3 = new List<string>();

            List<string> saveList4 = new List<string>();

            List<string> saveList5 = new List<string>();

            List<string> saveList6 = new List<string>();

            foreach (SchoolsLevels item in data4)
            {
                switch (item.Levels)
                {
                    case "國小":
                        saveList1.Add(item.StringOut());
                        break;
                    case "國中":
                        saveList2.Add(item.StringOut());
                        break;
                    case "高中":
                        saveList3.Add(item.StringOut());
                        break;
                    case "高職":
                        saveList4.Add(item.StringOut());
                        break;
                    case "特教學校":
                        saveList5.Add(item.StringOut());
                        break;
                    default:
                        saveList6.Add(item.StringOut());
                        break;
                }
                
            }

            File.AppendAllLines("國小.csv", saveList1, Encoding.UTF8);
            File.AppendAllLines("國中.csv", saveList2, Encoding.UTF8);
            File.AppendAllLines("高中.csv",saveList3,Encoding.UTF8);
            File.AppendAllLines("高職.csv",saveList4,Encoding.UTF8);
            File.AppendAllLines("特教學校.csv",saveList5,Encoding.UTF8);
            File.AppendAllLines("市立大專校院.csv",saveList6,Encoding.UTF8);
        }
    }
    class SchoolsLevels
    {
        public string Levels;
        public string SchoolName;
        public int PostalCode;
        public string Address;
        public string Telephone;
        public string Lat;
        public string Lon;
        public SchoolsLevels(string levels, string schoolName, int postalCode, string address, string telephone, string latitude, string longitude)
        {
            Levels = levels;
            SchoolName = schoolName;
            PostalCode = postalCode;
            Address = address;
            Telephone = telephone;
            Lat = latitude;
            Lon = longitude;
        }

        public string StringOut()
        {
            return $"{Levels},學校名稱:  {SchoolName},地址:  {Address},電話:  {Telephone},經緯度: {Lat},{Lon}";
        }
    }

    static class SchoolData
    {
        public static List<SchoolsLevels> RedData()
        {
            List<string> list1 = File.ReadAllLines("1080416臺北市各級學校分布圖.csv").ToList();
            list1.RemoveAt(0);

            //在迴圈外頭建一個新的集合去接重檔案變集合且整理過的資料。而這個集合是上面那個容器類別(SchoolsLevels)
            List<SchoolsLevels> levelsList = new List<SchoolsLevels>();

            foreach (string item in list1)
            {
                List<string> newlist = item.Split(',').ToList();

                levelsList.Add(new SchoolsLevels(
                    newlist[0],
                    newlist[1],
                    Convert.ToInt32(newlist[2]),
                    newlist[3],
                    newlist[4],
                    newlist[5],
                    newlist[6]

                ));
                   
            }
            return levelsList;

        }

    }
}
