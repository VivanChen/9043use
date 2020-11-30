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

namespace Homework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //School school = new School(); //工具拉出來
             
            listBox1.Items.Clear();

            List<string> ALLList = File.ReadAllLines("1080416臺北市各級學校分布圖.csv").ToList();

            ALLList.RemoveAt(0);

            foreach (string item in ALLList)
            {
                List<string> name = item.Split(',').ToList();

                if (name[0]==comboBox1.Text)
                {
                    listBox1.Items.Add(item);
                }
                
            }
        }
         

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            List<string> ALLList = File.ReadAllLines("1080416臺北市各級學校分布圖.csv").ToList();

            //string[] code = new string[3];

            ALLList.RemoveAt(0);

            for (int i = 1; i < ALLList.Count; i++)
            {
                if (ALLList[i].Contains(textBox1.Text))
                {
                    listBox1.Items.Add(ALLList[i]);
                }

            }

            //int a = Convert.ToInt32(textBox1.Text);

            //foreach (string item in ALLList)
            //{
            //    List<string> postal = item.Split(',').ToList();  //w

            //    if (postal[3] == a) ;
            //    {
            //        listBox1.Items.Add(item);
            //    }
            //    else
            //    {
            //        break;
            //    }
            //}




        }

        private void Button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            List<string> ALLList = File.ReadAllLines("1080416臺北市各級學校分布圖.csv").ToList();

            ALLList.RemoveAt(0);

            for (int i = 1; i < ALLList.Count; i++)
            {
                if (ALLList[i].Contains(textBox2.Text))
                {
                    listBox1.Items.Add(ALLList[i]);
                }
                //else if (ALLList[i] != textBox2.Text)
                //{
                //    MessageBox.Show("Test");
                //}
            }


        }

        private void Button4_Click(object sender, EventArgs e)
        {
            School school = new School();

            listBox1.Items.Add(school.school);
        }
    }
}
class School       //這裏要用class 才可以多串  建工具
{  //欄位 field
    public string school;
    public string school_name;
    public int postal_code;
    public string address;
    public int telephone;
    public int lat;
    public int lon;

    public string GetInfo()
    {
        return $"學校: {school}, 學校名字: {school_name}, 地址: {address},電話：{telephone},維度:{lat},Lon:{lon}";
    }

    public string Tool()
    {
        List<string> ALLList = File.ReadAllLines("1080416臺北市各級學校分布圖.csv").ToList();

        return "";
    }
}


    

    



