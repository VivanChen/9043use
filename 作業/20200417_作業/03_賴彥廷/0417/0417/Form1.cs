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

namespace _0417
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            //listBox1.DataSource = null;
            //listBox1.Items.Clear();
            ClearlistBox();

            //List<string> StrSchoolList = File.ReadAllLines("School.csv").ToList();
            //StrSchoolList.RemoveAt(0);

            List<string> StrSchoolList = GetSchoolInfo();

            //設一個以School容器類別欄位為格式的 SchoolList集合
            List<School> SchoolList = new List<School>();

            //將StrSchoolList字串集合中的資料逐一提出{校級,校名,郵遞,地址,電話...}
            for (int i = 0; i < StrSchoolList.Count; i++)
            {
                //再將每一組資料{校級,校名,郵遞,地址,電話...}，拆分成{校級},{校名},{郵遞},{地址},{電話}...存到dSchoolList中
                List<string> dSchoolList = StrSchoolList[i].Split(',').ToList();

                //將每一組細分的資料，以School容器類別的欄位格式，儲存到SchoolList集合中
                SchoolList.Add(
                    new School()
                    {
                        Level = dSchoolList[0],
                        Name = dSchoolList[1],
                        Post = Convert.ToInt32(dSchoolList[2]),
                        Address = dSchoolList[3],
                        Phone = dSchoolList[4]
                    });
            }


            for (int i = 0; i < SchoolList.Count; i++)
            {
                listBox1.Items.Add(SchoolList[i].GetInfo());
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //listBox1.DataSource = null;
            //listBox1.Items.Clear();
            ClearlistBox();

            //List<string> StrSchoolList = File.ReadAllLines("School.csv").ToList();
            //StrSchoolList.RemoveAt(0);
            List<string> StrSchoolList = GetSchoolInfo();



            for (int i = 0; i < StrSchoolList.Count; i++)
            {
                List<string> dSchoolList = StrSchoolList[i].Split(',').ToList();

                if (comboBox1.SelectedItem.ToString() == dSchoolList[0])
                {
                    listBox1.Items.Add(StrSchoolList[i]);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //listBox1.DataSource = null;
            //listBox1.Items.Clear();
            ClearlistBox();

            //List<string> StrSchoolList = File.ReadAllLines("School.csv").ToList();
            //StrSchoolList.RemoveAt(0);
            List<string> StrSchoolList = GetSchoolInfo();



            for (int i = 0; i < StrSchoolList.Count; i++)
            {
                List<string> dSchoolList = StrSchoolList[i].Split(',').ToList();

                if (dSchoolList[3].Contains(textBox1.Text) == true)
                {
                    listBox1.Items.Add(StrSchoolList[i]);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //listBox1.DataSource = null;
            //listBox1.Items.Clear();
            ClearlistBox();

            //List<string> StrSchoolList = File.ReadAllLines("School.csv").ToList();
            //StrSchoolList.RemoveAt(0);
            List<string> StrSchoolList = GetSchoolInfo();



            for (int i = 0; i < StrSchoolList.Count; i++)
            {
                List<string> dSchoolList = StrSchoolList[i].Split(',').ToList();

                if (dSchoolList[4] == textBox2.Text)
                {
                    listBox1.Items.Add(StrSchoolList[i]);
                    break;
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //listBox1.DataSource = null;
            //listBox1.Items.Clear();
            ClearlistBox();

            //List<string> StrSchoolList = File.ReadAllLines("School.csv").ToList();
            //StrSchoolList.RemoveAt(0);
            List<string> StrSchoolList = GetSchoolInfo();


            string str;
            str = "";
            for (int i = 0; i < StrSchoolList.Count; i++)
            {
                List<string> dSchoolList = StrSchoolList[i].Split(',').ToList();

                if  (dSchoolList[3].Contains(comboBox2.SelectedItem.ToString()))
                {
                    listBox1.Items.Add(StrSchoolList[i]);
                    str += "\r\n" + StrSchoolList[i];
                }
            }
            File.WriteAllText($"{comboBox2.SelectedItem.ToString()}.csv", "校級,校名,郵遞區號,地址,電話", Encoding.UTF8);
            File.AppendAllText($"{comboBox2.SelectedItem.ToString()}.csv", str, Encoding.UTF8);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            listBox1.Items.Clear();

            //List<string> StrSchoolList = File.ReadAllLines("School.csv").ToList();
            //StrSchoolList.RemoveAt(0);
            //用方法呼叫StrShoolList 學校名單集合
            List<string> StrSchoolList = GetSchoolInfo();

            string[] area = {"中正區", "大同區", "中山區", "松山區", "大安區", "萬華區", "信義區", "士林區", "北投區", "內湖區", "南港區", "文山區"};


            
            for (int j = 0; j < area.Length; j++)
            {
                string str;   //str設在迴圈裡 才能每run一次迴圈就把str存的字串清空
                str = "";
                for (int i = 0; i < StrSchoolList.Count; i++)
                {
                    List<string> dSchoolList = StrSchoolList[i].Split(',').ToList();

                    if (dSchoolList[3].Contains(area[j]) == true)
                    {
                        str += "\r\n" + StrSchoolList[i];
                    }
                    File.WriteAllText($"{area[j]}.csv", "校級,校名,郵遞區號,地址,電話", Encoding.UTF8);
                    File.AppendAllText($"{area[j]}.csv", str, Encoding.UTF8);
                    

                }
            }
            listBox1.Items.Add("資料建立成功");
        }
        public List<string> GetSchoolInfo()
        {
            List<string> StrSchoolList = File.ReadAllLines("School.csv").ToList();
            StrSchoolList.RemoveAt(0);
            return StrSchoolList;
        }
        public void ClearlistBox()
        {
            listBox1.DataSource = null;
            listBox1.Items.Clear();
        }
    }
    class School
    {
        public string Level;
        public string Name;
        public int Post;
        public string Address;
        public string Phone;
        //public string lat;
        //public string lon; 

        public string GetInfo()
        {
            return $"{Level},{Name},{Post},{Address},{Phone}";
        }
    }
}
